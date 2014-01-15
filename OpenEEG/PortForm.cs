using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml;
using System.IO;

namespace lucidcode.LucidScribe.Plugin.OpenEEG
{
    public partial class PortForm : Form
    {

        public String SelectedPort = "";
        public int Channels = 2;
        public String Algorithm = "REM Detection";
        public int BlinkInterval = 280;

        private Boolean loaded = false;
        private string m_strPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\lucidcode\\Lucid Scribe\\";

        public PortForm()
        {
            InitializeComponent();
        }

        private void PortForm_Load(object sender, EventArgs e)
        {
          LoadPortList();
          LoadSettings();
          loaded = true;
        }

        private void LoadPortList()
        {
          lstPorts.Clear();
          foreach (string strPort in SerialPort.GetPortNames())
          {
            String strPortName = strPort;
            strPortName = strPortName.Replace("a", "");
            strPortName = strPortName.Replace("b", "");
            strPortName = strPortName.Replace("c", "");
            strPortName = strPortName.Replace("d", "");
            strPortName = strPortName.Replace("e", "");
            strPortName = strPortName.Replace("f", "");
            strPortName = strPortName.Replace("g", "");
            strPortName = strPortName.Replace("h", "");
            strPortName = strPortName.Replace("i", "");
            strPortName = strPortName.Replace("j", "");
            strPortName = strPortName.Replace("k", "");
            strPortName = strPortName.Replace("l", "");
            strPortName = strPortName.Replace("m", "");
            strPortName = strPortName.Replace("n", "");
            strPortName = strPortName.Replace("o", "");
            strPortName = strPortName.Replace("p", "");
            strPortName = strPortName.Replace("q", "");
            strPortName = strPortName.Replace("r", "");
            strPortName = strPortName.Replace("s", "");
            strPortName = strPortName.Replace("t", "");
            strPortName = strPortName.Replace("u", "");
            strPortName = strPortName.Replace("v", "");
            strPortName = strPortName.Replace("w", "");
            strPortName = strPortName.Replace("x", "");
            strPortName = strPortName.Replace("y", "");
            strPortName = strPortName.Replace("z", "");

            ListViewItem lstItem = new ListViewItem(strPortName);
            lstItem.ImageIndex = 0;
            lstPorts.Items.Add(lstItem);
          } 
        }

        private void LoadSettings()
        {
          XmlDocument xmlSettings = new XmlDocument();

          if (!File.Exists(m_strPath + "Plugins\\OpenEEG.User.lsd"))
          {
            String defaultSettings = "<LucidScribeData>";
            defaultSettings += "<Plugin>";
            defaultSettings += "<Channels>2</Channels>";
            defaultSettings += "<Algorithm>REM Detection</Algorithm>";
            defaultSettings += "<BlinkInterval>280</BlinkInterval>";
            defaultSettings += "</Plugin>";
            defaultSettings += "</LucidScribeData>";
            File.WriteAllText(m_strPath + "Plugins\\OpenEEG.User.lsd", defaultSettings);
          }

          xmlSettings.Load(m_strPath + "Plugins\\OpenEEG.User.lsd");

          if (xmlSettings.DocumentElement.SelectSingleNode("//Channels") != null)
          {
            cmbChannels.Text = xmlSettings.DocumentElement.SelectSingleNode("//Channels").InnerText;
          }
          if (xmlSettings.DocumentElement.SelectSingleNode("//Algorithm") != null)
          {
            cmbAlgorithm.Text = xmlSettings.DocumentElement.SelectSingleNode("//Algorithm").InnerText;
          }
          if (xmlSettings.DocumentElement.SelectSingleNode("//BlinkInterval") != null)
          {
            cmbBlinkInterval.Text = xmlSettings.DocumentElement.SelectSingleNode("//BlinkInterval").InnerText;
          }
          else
          {
            cmbBlinkInterval.Text = "280";
          }
        }

        private void cmbChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
          if (!loaded) { return; }
          Channels = Convert.ToInt32(cmbChannels.Text);
          SaveSettings();
        }

        private void cmbAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
          if (!loaded) { return; }
          Algorithm = cmbAlgorithm.Text;
          SaveSettings();
        }

        private void cmbBlinkInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
          if (!loaded) { return; }
          BlinkInterval = Convert.ToInt32(cmbBlinkInterval.Text);
          SaveSettings();
        }

        private void SaveSettings()
        {
          String defaultSettings = "<LucidScribeData>";
          defaultSettings += "<Plugin>";
          defaultSettings += "<Channels>" + cmbChannels.Text + "</Channels>";
          defaultSettings += "<Algorithm>" + cmbAlgorithm.Text + "</Algorithm>";
          defaultSettings += "<BlinkInterval>" + cmbBlinkInterval.Text + "</BlinkInterval>";
          defaultSettings += "</Plugin>";
          defaultSettings += "</LucidScribeData>";
          File.WriteAllText(m_strPath + "Plugins\\OpenEEG.User.lsd", defaultSettings);
        }

        private void lstPlaylists_MouseMove(object sender, MouseEventArgs e)
        {
            if (lstPorts.GetItemAt(e.X, e.Y) != null)
            {
                lstPorts.Cursor = Cursors.Hand;
            }
            else
            {
                lstPorts.Cursor = Cursors.Default;
            }
        }

        private void lstPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPorts.SelectedItems.Count > 0)
            {
                SelectedPort = lstPorts.SelectedItems[0].Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void mnuRefresh_Click(object sender, EventArgs e)
        {
          LoadPortList();
        }

    }
}
