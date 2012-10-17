using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.IO.Ports;
using System.Windows.Forms;

namespace lucidcode.LucidScribe.Plugin.OpenEEG
{

    public static class Device
    {
        static bool Initialized;
        static bool InitError;
        static SerialPort serialPort;
        static int[] eegChannels;
        static double eegValue;

        static int blockLength = 0x100;
        static int[] buffer;
        static Queue<DataFrame> fifo;
        static int index = 100;
        static int lastByte = -1;
        static int channels = 6;

        public static Boolean Initialize()
        {
            eegChannels = new int[channels];

            if (!Initialized & !InitError)
            {
                PortForm formPort = new PortForm();
                if (formPort.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Open the COM port
                        serialPort = new SerialPort(formPort.SelectedPort);
                        serialPort.BaudRate = 0xe100;
                        serialPort.Parity = Parity.None;
                        serialPort.DataBits = 8;
                        serialPort.StopBits = StopBits.One;
                        serialPort.Handshake = Handshake.None;
                        serialPort.ReadTimeout = 500;
                        serialPort.WriteTimeout = 500;
                        serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
                        serialPort.Open();
                    }
                    catch (Exception ex)
                    {
                        if (!InitError)
                        {
                            MessageBox.Show(ex.Message, "LucidScribe.InitializePlugin()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        InitError = true;
                    }
                }
                else
                {
                    InitError = true;
                    return false;
                }

                Initialized = true;
            }
            return true;
        }

        struct DataFrame
        {
            public int counter;
            public int[] samples;
        }

        static void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort.BytesToRead > 0)
            {
                int num = serialPort.ReadByte();
                if ((lastByte == 0xa5) && (num == 90))
                {
                    index = 0;
                }
                if ((index >= 1) && (index < 0x10))
                {
                    buffer[index - 1] = num;
                }
                if (index == 15)
                {
                    DataFrame frame;
                    frame.samples = new int[channels];
                    frame.counter = buffer[1];

                    int total = 0;
                    for (int i = 0; i < channels; i++)
                    {
                        eegChannels[i] = (buffer[(i * 2) + 2] * 0x100) + buffer[(i * 2) + 3];
                        frame.samples[i] = (buffer[(i * 2) + 2] * 0x100) + buffer[(i * 2) + 3];
                        total += eegChannels[i];
                    }

                    eegValue = total / channels;

                    //fifo.Enqueue(frame);
                    //if (fifo.Count == blockLength)
                    //{
                    //    DataFrame[] block;
                    //    block = new DataFrame[blockLength];
                    //    for (int i = 0; i < blockLength; i++)
                    //    {
                    //        block[i] = fifo.Dequeue();
                    //    }

                    //    for (int i = 0; i < blockLength; i++)
                    //    {
                    //        block[i] = fifo.Dequeue();
                    //    }
                    //}
                }
                index++;
                lastByte = num;
            }

        }

        public static void Dispose()
        {
            if (Initialized)
            {
                Initialized = false;
            }
        }

        public static Double GetEEG()
        {
            return eegValue;
        }

        public static Double GetChannel1()
        {
            if (channels > 0)
            {
                return eegChannels[0];
            }
            return 0;
        }

        public static Double GetChannel2()
        {
            if (channels > 0)
            {
                return eegChannels[1];
            }
            return 0;
        }
    }

    namespace EEG
    {   
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

    namespace EEG1
    {
        public class PluginHandler : lucidcode.LucidScribe.Interface.LucidPluginBase
        {

            public override string Name
            {
                get
                {
                    return "OpenEEG Ch1";
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
                    double tempValue = Device.GetChannel1();
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

    namespace EEG2
    {
        public class PluginHandler : lucidcode.LucidScribe.Interface.LucidPluginBase
        {

            public override string Name
            {
                get
                {
                    return "OpenEEG Ch2";
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
                    double tempValue = Device.GetChannel2();
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
