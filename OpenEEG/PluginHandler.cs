using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace lucidcode.LucidScribe.Plugin.OpenEEG
{

    // This class is shard by OpenEEG and OpenREM to access the hardware
    public static class Device
    {

        private static bool Initialized;
        static double eegValue;
        static Thread eegDeviceThread;

        public static Boolean Initialize()
        {
            if (!Initialized)
            {
                // Start the update thread
                Initialized = true;
                eegDeviceThread = new Thread(new ThreadStart(UpdateEEG));
                eegDeviceThread.Start();
            }
            return true;
        }

        public static void Dispose()
        {
            if (Initialized)
            {
                Initialized = false;
            }
        }

        private static void UpdateEEG()
        {
            do
            {
                // This is where we will get the data from the device
                Thread.Sleep(100);
                eegValue = 256 + (new Random().NextDouble() * 64);

                if (!Initialized) { return; }

            } while (true);
        }

        public static Double GetEEG()
        {
            return eegValue;
        }
    }

    namespace EEG
    {   
        // This class passes the eeg value to Lucid Scribe through the interface - copies could be created for multiple channels
        public class PluginHandler : lucidcode.LucidScribe.Interface.LucidPluginBase
        {

            private double m_dblValue = 256;

            public override string Name
            {
                get
                {
                    return "OpenEEG";
                }
            }

            public override bool Initialize()
            {
                try
                {
                    return Device.Initialize();
                }
                catch (Exception ex)
                {
                    throw (new Exception("The '" + Name + "' plugin failed to initialize: " + ex.Message));
                }
            }

            public override double Value
            {
                get
                {
                    double tempValue = Device.GetEEG();
                    if (tempValue > 999) { tempValue = 999; }
                    if (tempValue < 0) { tempValue = 0; }
                    return tempValue;
                }
            }

            public override void Dispose()
            {
                Device.Dispose();
            }
        }
    }

    namespace REM
    {
        public class PluginHandler : lucidcode.LucidScribe.Interface.LucidPluginBase
        {

            public override string Name
            {
                get
                {
                    return "OpenREM";
                }
            }

            public override bool Initialize()
            {
                try
                {
                    return Device.Initialize();
                }
                catch (Exception ex)
                {
                    throw (new Exception("The '" + Name + "' plugin failed to initialize: " + ex.Message));
                }
            }

            public override double Value
            {
                get
                {
                    // This is where we will detect patterns indicative of REM sleep
                    double eegValue = Device.GetEEG();

                    if ((new Random().NextDouble() * 10000) == 1)
                    {
                        return 888;
                    }

                    return 0;
                }
            }

            public override void Dispose()
            {
                Device.Dispose();
            }
        }
    }

}
