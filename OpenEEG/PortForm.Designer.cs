namespace lucidcode.LucidScribe.Plugin.OpenEEG
{
  partial class PortForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortForm));
      this.pnlPlugins = new lucidcode.Controls.Panel3D();
      this.lstPorts = new System.Windows.Forms.ListView();
      this.mnuPortsList = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuRefreshPorts = new System.Windows.Forms.ToolStripMenuItem();
      this.lstImg = new System.Windows.Forms.ImageList(this.components);
      this.Panel3D4 = new lucidcode.Controls.Panel3D();
      this.Label5 = new System.Windows.Forms.Label();
      this.Label6 = new System.Windows.Forms.Label();
      this.cmbChannels = new System.Windows.Forms.ComboBox();
      this.panel3D3 = new lucidcode.Controls.Panel3D();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cmbBlinkInterval = new System.Windows.Forms.ComboBox();
      this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel3D5 = new lucidcode.Controls.Panel3D();
      this.label4 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.pnlPlugins.SuspendLayout();
      this.mnuPortsList.SuspendLayout();
      this.Panel3D4.SuspendLayout();
      this.panel3D3.SuspendLayout();
      this.panel3D5.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlPlugins
      // 
      this.pnlPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlPlugins.BackColor = System.Drawing.Color.White;
      this.pnlPlugins.Controls.Add(this.lstPorts);
      this.pnlPlugins.Controls.Add(this.Panel3D4);
      this.pnlPlugins.Location = new System.Drawing.Point(12, 130);
      this.pnlPlugins.Name = "pnlPlugins";
      this.pnlPlugins.Size = new System.Drawing.Size(308, 187);
      this.pnlPlugins.TabIndex = 5;
      // 
      // lstPorts
      // 
      this.lstPorts.Activation = System.Windows.Forms.ItemActivation.OneClick;
      this.lstPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lstPorts.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.lstPorts.ContextMenuStrip = this.mnuPortsList;
      this.lstPorts.LargeImageList = this.lstImg;
      this.lstPorts.Location = new System.Drawing.Point(3, 25);
      this.lstPorts.MultiSelect = false;
      this.lstPorts.Name = "lstPorts";
      this.lstPorts.Size = new System.Drawing.Size(302, 159);
      this.lstPorts.TabIndex = 8;
      this.lstPorts.TileSize = new System.Drawing.Size(150, 32);
      this.lstPorts.UseCompatibleStateImageBehavior = false;
      this.lstPorts.View = System.Windows.Forms.View.Tile;
      this.lstPorts.SelectedIndexChanged += new System.EventHandler(this.lstPlaylists_SelectedIndexChanged);
      this.lstPorts.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstPlaylists_MouseMove);
      // 
      // mnuPortsList
      // 
      this.mnuPortsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefreshPorts});
      this.mnuPortsList.Name = "mnuPortsList";
      this.mnuPortsList.Size = new System.Drawing.Size(114, 26);
      // 
      // mnuRefreshPorts
      // 
      this.mnuRefreshPorts.Name = "mnuRefreshPorts";
      this.mnuRefreshPorts.Size = new System.Drawing.Size(113, 22);
      this.mnuRefreshPorts.Text = "&Refresh";
      this.mnuRefreshPorts.Click += new System.EventHandler(this.mnuRefresh_Click);
      // 
      // lstImg
      // 
      this.lstImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImg.ImageStream")));
      this.lstImg.TransparentColor = System.Drawing.Color.Transparent;
      this.lstImg.Images.SetKeyName(0, "Graph.Plugin2.bmp");
      // 
      // Panel3D4
      // 
      this.Panel3D4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.Panel3D4.BackColor = System.Drawing.Color.SteelBlue;
      this.Panel3D4.Controls.Add(this.Label5);
      this.Panel3D4.Controls.Add(this.Label6);
      this.Panel3D4.Location = new System.Drawing.Point(0, 0);
      this.Panel3D4.Name = "Panel3D4";
      this.Panel3D4.Size = new System.Drawing.Size(308, 24);
      this.Panel3D4.TabIndex = 4;
      // 
      // Label5
      // 
      this.Label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
      this.Label5.ForeColor = System.Drawing.Color.White;
      this.Label5.Image = ((System.Drawing.Image)(resources.GetObject("Label5.Image")));
      this.Label5.Location = new System.Drawing.Point(3, 3);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(19, 19);
      this.Label5.TabIndex = 4;
      this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Label6
      // 
      this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.Label6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
      this.Label6.ForeColor = System.Drawing.Color.White;
      this.Label6.Location = new System.Drawing.Point(24, 3);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(281, 19);
      this.Label6.TabIndex = 3;
      this.Label6.Text = "Select port to connect";
      this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cmbChannels
      // 
      this.cmbChannels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbChannels.FormattingEnabled = true;
      this.cmbChannels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
      this.cmbChannels.Location = new System.Drawing.Point(125, 30);
      this.cmbChannels.Name = "cmbChannels";
      this.cmbChannels.Size = new System.Drawing.Size(174, 21);
      this.cmbChannels.TabIndex = 282;
      this.cmbChannels.SelectedIndexChanged += new System.EventHandler(this.cmbChannels_SelectedIndexChanged);
      // 
      // panel3D3
      // 
      this.panel3D3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.panel3D3.BackColor = System.Drawing.Color.LightSteelBlue;
      this.panel3D3.Controls.Add(this.label3);
      this.panel3D3.Controls.Add(this.label2);
      this.panel3D3.Controls.Add(this.cmbBlinkInterval);
      this.panel3D3.Controls.Add(this.cmbAlgorithm);
      this.panel3D3.Controls.Add(this.label1);
      this.panel3D3.Controls.Add(this.panel3D5);
      this.panel3D3.Controls.Add(this.cmbChannels);
      this.panel3D3.Location = new System.Drawing.Point(12, 12);
      this.panel3D3.Name = "panel3D3";
      this.panel3D3.Size = new System.Drawing.Size(308, 112);
      this.panel3D3.TabIndex = 284;
      // 
      // label3
      // 
      this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
      this.label3.Location = new System.Drawing.Point(3, 84);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(116, 21);
      this.label3.TabIndex = 285;
      this.label3.Text = "Blink Interval (MS)";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label2
      // 
      this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
      this.label2.Location = new System.Drawing.Point(3, 57);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(116, 21);
      this.label2.TabIndex = 285;
      this.label2.Text = "Algorithm";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cmbBlinkInterval
      // 
      this.cmbBlinkInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbBlinkInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbBlinkInterval.FormattingEnabled = true;
      this.cmbBlinkInterval.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "210",
            "220",
            "230",
            "240",
            "250",
            "260",
            "270",
            "280",
            "290",
            "300",
            "310",
            "320",
            "330",
            "340",
            "350",
            "360",
            "370",
            "380",
            "390",
            "400",
            "410",
            "420",
            "430",
            "440",
            "450",
            "460",
            "470",
            "480",
            "490",
            "500",
            "510",
            "520",
            "530",
            "540",
            "550",
            "560",
            "570",
            "580",
            "590",
            "600",
            "610",
            "620",
            "630",
            "640",
            "650",
            "660",
            "670",
            "680",
            "690",
            "700",
            "710",
            "720",
            "730",
            "740",
            "750",
            "760",
            "770",
            "780",
            "790",
            "800",
            "810",
            "820",
            "830",
            "840",
            "850",
            "860",
            "870",
            "880",
            "890",
            "900",
            "910",
            "920",
            "930",
            "940",
            "950",
            "960",
            "970",
            "980",
            "990",
            "1000"});
      this.cmbBlinkInterval.Location = new System.Drawing.Point(125, 84);
      this.cmbBlinkInterval.Name = "cmbBlinkInterval";
      this.cmbBlinkInterval.Size = new System.Drawing.Size(174, 21);
      this.cmbBlinkInterval.TabIndex = 284;
      this.cmbBlinkInterval.SelectedIndexChanged += new System.EventHandler(this.cmbBlinkInterval_SelectedIndexChanged);
      // 
      // cmbAlgorithm
      // 
      this.cmbAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbAlgorithm.FormattingEnabled = true;
      this.cmbAlgorithm.Items.AddRange(new object[] {
            "REM Detection",
            "Motion Detection"});
      this.cmbAlgorithm.Location = new System.Drawing.Point(125, 57);
      this.cmbAlgorithm.Name = "cmbAlgorithm";
      this.cmbAlgorithm.Size = new System.Drawing.Size(174, 21);
      this.cmbAlgorithm.TabIndex = 284;
      this.cmbAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cmbAlgorithm_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
      this.label1.Location = new System.Drawing.Point(3, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(116, 21);
      this.label1.TabIndex = 283;
      this.label1.Text = "Channels";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // panel3D5
      // 
      this.panel3D5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.panel3D5.BackColor = System.Drawing.Color.SteelBlue;
      this.panel3D5.Controls.Add(this.label4);
      this.panel3D5.Controls.Add(this.label11);
      this.panel3D5.Location = new System.Drawing.Point(0, 0);
      this.panel3D5.Name = "panel3D5";
      this.panel3D5.Size = new System.Drawing.Size(308, 24);
      this.panel3D5.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
      this.label4.Location = new System.Drawing.Point(3, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(19, 19);
      this.label4.TabIndex = 4;
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label11
      // 
      this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label11.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
      this.label11.ForeColor = System.Drawing.Color.White;
      this.label11.Location = new System.Drawing.Point(24, 3);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(281, 19);
      this.label11.TabIndex = 3;
      this.label11.Text = "Settings";
      this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // PortForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightSteelBlue;
      this.ClientSize = new System.Drawing.Size(332, 329);
      this.Controls.Add(this.panel3D3);
      this.Controls.Add(this.pnlPlugins);
      this.Font = new System.Drawing.Font("Verdana", 8.25F);
      this.ForeColor = System.Drawing.Color.MidnightBlue;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "PortForm";
      this.Text = "Lucid Scribe - OpenEEG";
      this.Load += new System.EventHandler(this.PortForm_Load);
      this.pnlPlugins.ResumeLayout(false);
      this.mnuPortsList.ResumeLayout(false);
      this.Panel3D4.ResumeLayout(false);
      this.panel3D3.ResumeLayout(false);
      this.panel3D5.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    internal lucidcode.Controls.Panel3D pnlPlugins;
    internal lucidcode.Controls.Panel3D Panel3D4;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.Label Label6;
    internal System.Windows.Forms.ListView lstPorts;
    internal System.Windows.Forms.ImageList lstImg;
    private System.Windows.Forms.ContextMenuStrip mnuPortsList;
    private System.Windows.Forms.ToolStripMenuItem mnuRefreshPorts;
    private System.Windows.Forms.ComboBox cmbChannels;
    internal Controls.Panel3D panel3D3;
    internal Controls.Panel3D panel3D5;
    internal System.Windows.Forms.Label label4;
    internal System.Windows.Forms.Label label11;
    internal System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbAlgorithm;
    internal System.Windows.Forms.Label label1;
    internal System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmbBlinkInterval;
  }
}