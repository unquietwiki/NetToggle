//NetToggle
//Michael Adams, unquietwiki.com, Oct 3, 2011

namespace NetToggle
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStandard = new System.Windows.Forms.Button();
            this.btnNothing = new System.Windows.Forms.Button();
            this.gbNetOpt = new System.Windows.Forms.GroupBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnAggressive = new System.Windows.Forms.Button();
            this.btnHyperV = new System.Windows.Forms.Button();
            this.btnWireless = new System.Windows.Forms.Button();
            this.gbIPv6 = new System.Windows.Forms.GroupBox();
            this.cb6to4 = new System.Windows.Forms.CheckBox();
            this.cbISATAP = new System.Windows.Forms.CheckBox();
            this.cbTeredo = new System.Windows.Forms.CheckBox();
            this.cbPA = new System.Windows.Forms.CheckBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.cbDMA = new System.Windows.Forms.CheckBox();
            this.cbRSS = new System.Windows.Forms.CheckBox();
            this.cbDCA = new System.Windows.Forms.CheckBox();
            this.cbTC = new System.Windows.Forms.CheckBox();
            this.cbCT = new System.Windows.Forms.CheckBox();
            this.cbECN = new System.Windows.Forms.CheckBox();
            this.gbFirewall = new System.Windows.Forms.GroupBox();
            this.cbPing = new System.Windows.Forms.CheckBox();
            this.cbWMI = new System.Windows.Forms.CheckBox();
            this.cbRVM = new System.Windows.Forms.CheckBox();
            this.cbRSM = new System.Windows.Forms.CheckBox();
            this.cbRD = new System.Windows.Forms.CheckBox();
            this.cbRA = new System.Windows.Forms.CheckBox();
            this.cbRM = new System.Windows.Forms.CheckBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.gbRFC1323 = new System.Windows.Forms.GroupBox();
            this.rbYesTSWS = new System.Windows.Forms.RadioButton();
            this.rbNoWS = new System.Windows.Forms.RadioButton();
            this.rbNoTS = new System.Windows.Forms.RadioButton();
            this.rbNoTSWS = new System.Windows.Forms.RadioButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.llDeveloper = new System.Windows.Forms.LinkLabel();
            this.llLicence = new System.Windows.Forms.LinkLabel();
            this.gbNetOpt.SuspendLayout();
            this.gbIPv6.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbFirewall.SuspendLayout();
            this.gbRFC1323.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStandard
            // 
            this.btnStandard.Location = new System.Drawing.Point(6, 18);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(93, 27);
            this.btnStandard.TabIndex = 0;
            this.btnStandard.Text = "&Standard";
            this.btnStandard.UseVisualStyleBackColor = true;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            this.btnStandard.MouseHover += new System.EventHandler(this.btnStandard_MouseHover);
            // 
            // btnNothing
            // 
            this.btnNothing.Location = new System.Drawing.Point(204, 51);
            this.btnNothing.Name = "btnNothing";
            this.btnNothing.Size = new System.Drawing.Size(93, 27);
            this.btnNothing.TabIndex = 5;
            this.btnNothing.Text = "&Nothing";
            this.btnNothing.UseVisualStyleBackColor = true;
            this.btnNothing.Click += new System.EventHandler(this.btnNothing_Click);
            this.btnNothing.MouseHover += new System.EventHandler(this.btnNothing_MouseHover);
            // 
            // gbNetOpt
            // 
            this.gbNetOpt.Controls.Add(this.btnDefault);
            this.gbNetOpt.Controls.Add(this.btnAggressive);
            this.gbNetOpt.Controls.Add(this.btnHyperV);
            this.gbNetOpt.Controls.Add(this.btnWireless);
            this.gbNetOpt.Controls.Add(this.btnStandard);
            this.gbNetOpt.Controls.Add(this.btnNothing);
            this.gbNetOpt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNetOpt.Location = new System.Drawing.Point(12, 12);
            this.gbNetOpt.Name = "gbNetOpt";
            this.gbNetOpt.Size = new System.Drawing.Size(308, 93);
            this.gbNetOpt.TabIndex = 1;
            this.gbNetOpt.TabStop = false;
            this.gbNetOpt.Text = "Network Optimizations";
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(204, 18);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(93, 27);
            this.btnDefault.TabIndex = 4;
            this.btnDefault.Text = "&Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            this.btnDefault.MouseHover += new System.EventHandler(this.btnDefault_MouseHover);
            // 
            // btnAggressive
            // 
            this.btnAggressive.Location = new System.Drawing.Point(105, 18);
            this.btnAggressive.Name = "btnAggressive";
            this.btnAggressive.Size = new System.Drawing.Size(93, 27);
            this.btnAggressive.TabIndex = 2;
            this.btnAggressive.Text = "&Aggressive";
            this.btnAggressive.UseVisualStyleBackColor = true;
            this.btnAggressive.Click += new System.EventHandler(this.btnAggressive_Click);
            this.btnAggressive.MouseHover += new System.EventHandler(this.btnAggressive_MouseHover);
            // 
            // btnHyperV
            // 
            this.btnHyperV.Location = new System.Drawing.Point(105, 51);
            this.btnHyperV.Name = "btnHyperV";
            this.btnHyperV.Size = new System.Drawing.Size(93, 27);
            this.btnHyperV.TabIndex = 3;
            this.btnHyperV.Text = "&Hyper-V";
            this.btnHyperV.UseVisualStyleBackColor = true;
            this.btnHyperV.Click += new System.EventHandler(this.btnHyperV_Click);
            this.btnHyperV.MouseHover += new System.EventHandler(this.btnHyperV_MouseHover);
            // 
            // btnWireless
            // 
            this.btnWireless.Location = new System.Drawing.Point(6, 51);
            this.btnWireless.Name = "btnWireless";
            this.btnWireless.Size = new System.Drawing.Size(93, 27);
            this.btnWireless.TabIndex = 1;
            this.btnWireless.Text = "&Wireless";
            this.btnWireless.UseVisualStyleBackColor = true;
            this.btnWireless.Click += new System.EventHandler(this.btnWireless_Click);
            this.btnWireless.MouseHover += new System.EventHandler(this.btnWireless_MouseHover);
            // 
            // gbIPv6
            // 
            this.gbIPv6.Controls.Add(this.cb6to4);
            this.gbIPv6.Controls.Add(this.cbISATAP);
            this.gbIPv6.Controls.Add(this.cbTeredo);
            this.gbIPv6.Controls.Add(this.cbPA);
            this.gbIPv6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIPv6.Location = new System.Drawing.Point(415, 229);
            this.gbIPv6.Name = "gbIPv6";
            this.gbIPv6.Size = new System.Drawing.Size(290, 74);
            this.gbIPv6.TabIndex = 3;
            this.gbIPv6.TabStop = false;
            this.gbIPv6.Text = "IPv6 toggles";
            // 
            // cb6to4
            // 
            this.cb6to4.AutoSize = true;
            this.cb6to4.Location = new System.Drawing.Point(169, 48);
            this.cb6to4.Name = "cb6to4";
            this.cb6to4.Size = new System.Drawing.Size(52, 20);
            this.cb6to4.TabIndex = 3;
            this.cb6to4.Text = "6to4";
            this.cb6to4.UseVisualStyleBackColor = true;
            this.cb6to4.MouseHover += new System.EventHandler(this.cb6to4_MouseHover);
            // 
            // cbISATAP
            // 
            this.cbISATAP.AutoSize = true;
            this.cbISATAP.Location = new System.Drawing.Point(169, 22);
            this.cbISATAP.Name = "cbISATAP";
            this.cbISATAP.Size = new System.Drawing.Size(70, 20);
            this.cbISATAP.TabIndex = 2;
            this.cbISATAP.Text = "ISATAP";
            this.cbISATAP.UseVisualStyleBackColor = true;
            this.cbISATAP.MouseHover += new System.EventHandler(this.cbISATAP_MouseHover);
            // 
            // cbTeredo
            // 
            this.cbTeredo.AutoSize = true;
            this.cbTeredo.Location = new System.Drawing.Point(6, 47);
            this.cbTeredo.Name = "cbTeredo";
            this.cbTeredo.Size = new System.Drawing.Size(68, 20);
            this.cbTeredo.TabIndex = 1;
            this.cbTeredo.Text = "Teredo";
            this.cbTeredo.UseVisualStyleBackColor = true;
            this.cbTeredo.MouseHover += new System.EventHandler(this.cbTeredo_MouseHover);
            // 
            // cbPA
            // 
            this.cbPA.AutoSize = true;
            this.cbPA.Location = new System.Drawing.Point(6, 22);
            this.cbPA.Name = "cbPA";
            this.cbPA.Size = new System.Drawing.Size(134, 20);
            this.cbPA.TabIndex = 0;
            this.cbPA.Text = "Privacy Addressing";
            this.cbPA.UseVisualStyleBackColor = true;
            this.cbPA.MouseHover += new System.EventHandler(this.cbPA_MouseHover);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.cbDMA);
            this.gbOptions.Controls.Add(this.cbRSS);
            this.gbOptions.Controls.Add(this.cbDCA);
            this.gbOptions.Controls.Add(this.cbTC);
            this.gbOptions.Controls.Add(this.cbCT);
            this.gbOptions.Controls.Add(this.cbECN);
            this.gbOptions.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOptions.Location = new System.Drawing.Point(12, 111);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(210, 186);
            this.gbOptions.TabIndex = 2;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Networking Options";
            // 
            // cbDMA
            // 
            this.cbDMA.AutoSize = true;
            this.cbDMA.Location = new System.Drawing.Point(6, 126);
            this.cbDMA.Name = "cbDMA";
            this.cbDMA.Size = new System.Drawing.Size(120, 20);
            this.cbDMA.TabIndex = 5;
            this.cbDMA.Text = "Net DMA / TCPA";
            this.cbDMA.UseVisualStyleBackColor = true;
            this.cbDMA.MouseHover += new System.EventHandler(this.cbDMA_MouseHover);
            // 
            // cbRSS
            // 
            this.cbRSS.AutoSize = true;
            this.cbRSS.Location = new System.Drawing.Point(6, 100);
            this.cbRSS.Name = "cbRSS";
            this.cbRSS.Size = new System.Drawing.Size(145, 20);
            this.cbRSS.TabIndex = 4;
            this.cbRSS.Text = "Receive Side Scaling";
            this.cbRSS.UseVisualStyleBackColor = true;
            this.cbRSS.MouseHover += new System.EventHandler(this.cbRSS_MouseHover);
            // 
            // cbDCA
            // 
            this.cbDCA.AutoSize = true;
            this.cbDCA.Location = new System.Drawing.Point(6, 152);
            this.cbDCA.Name = "cbDCA";
            this.cbDCA.Size = new System.Drawing.Size(142, 20);
            this.cbDCA.TabIndex = 6;
            this.cbDCA.Text = "Direct Cache Access";
            this.cbDCA.UseVisualStyleBackColor = true;
            this.cbDCA.MouseHover += new System.EventHandler(this.cbDCA_MouseHover);
            // 
            // cbTC
            // 
            this.cbTC.AutoSize = true;
            this.cbTC.Location = new System.Drawing.Point(6, 74);
            this.cbTC.Name = "cbTC";
            this.cbTC.Size = new System.Drawing.Size(103, 20);
            this.cbTC.TabIndex = 3;
            this.cbTC.Text = "TCP Chimney";
            this.cbTC.UseVisualStyleBackColor = true;
            this.cbTC.MouseHover += new System.EventHandler(this.cbTC_MouseHover);
            // 
            // cbCT
            // 
            this.cbCT.AutoSize = true;
            this.cbCT.Location = new System.Drawing.Point(6, 22);
            this.cbCT.Name = "cbCT";
            this.cbCT.Size = new System.Drawing.Size(115, 20);
            this.cbCT.TabIndex = 1;
            this.cbCT.Text = "Compound TCP";
            this.cbCT.UseVisualStyleBackColor = true;
            this.cbCT.MouseHover += new System.EventHandler(this.cbCT_MouseHover);
            // 
            // cbECN
            // 
            this.cbECN.AutoSize = true;
            this.cbECN.Location = new System.Drawing.Point(6, 48);
            this.cbECN.Name = "cbECN";
            this.cbECN.Size = new System.Drawing.Size(200, 20);
            this.cbECN.TabIndex = 2;
            this.cbECN.Text = "Explicit Congestion Notification";
            this.cbECN.UseVisualStyleBackColor = true;
            this.cbECN.MouseHover += new System.EventHandler(this.cbECN_MouseHover);
            // 
            // gbFirewall
            // 
            this.gbFirewall.Controls.Add(this.cbPing);
            this.gbFirewall.Controls.Add(this.cbWMI);
            this.gbFirewall.Controls.Add(this.cbRVM);
            this.gbFirewall.Controls.Add(this.cbRSM);
            this.gbFirewall.Controls.Add(this.cbRD);
            this.gbFirewall.Controls.Add(this.cbRA);
            this.gbFirewall.Controls.Add(this.cbRM);
            this.gbFirewall.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFirewall.Location = new System.Drawing.Point(347, 13);
            this.gbFirewall.Name = "gbFirewall";
            this.gbFirewall.Size = new System.Drawing.Size(283, 211);
            this.gbFirewall.TabIndex = 4;
            this.gbFirewall.TabStop = false;
            this.gbFirewall.Text = "Firewall Options (Checked = Allow)";
            this.gbFirewall.MouseHover += new System.EventHandler(this.gbFirewall_MouseHover);
            // 
            // cbPing
            // 
            this.cbPing.AutoSize = true;
            this.cbPing.Location = new System.Drawing.Point(6, 22);
            this.cbPing.Name = "cbPing";
            this.cbPing.Size = new System.Drawing.Size(116, 20);
            this.cbPing.TabIndex = 0;
            this.cbPing.Text = "Pinging (v4+v6)";
            this.cbPing.UseVisualStyleBackColor = true;
            this.cbPing.MouseHover += new System.EventHandler(this.gbFirewall_MouseHover);
            // 
            // cbWMI
            // 
            this.cbWMI.AutoSize = true;
            this.cbWMI.Location = new System.Drawing.Point(6, 178);
            this.cbWMI.Name = "cbWMI";
            this.cbWMI.Size = new System.Drawing.Size(251, 20);
            this.cbWMI.TabIndex = 6;
            this.cbWMI.Text = "Windows Management Instrumentation";
            this.cbWMI.UseVisualStyleBackColor = true;
            this.cbWMI.MouseHover += new System.EventHandler(this.gbFirewall_MouseHover);
            // 
            // cbRVM
            // 
            this.cbRVM.AutoSize = true;
            this.cbRVM.Location = new System.Drawing.Point(6, 152);
            this.cbRVM.Name = "cbRVM";
            this.cbRVM.Size = new System.Drawing.Size(196, 20);
            this.cbRVM.TabIndex = 5;
            this.cbRVM.Text = "Remote Volume Management";
            this.cbRVM.UseVisualStyleBackColor = true;
            this.cbRVM.MouseHover += new System.EventHandler(this.gbFirewall_MouseHover);
            // 
            // cbRSM
            // 
            this.cbRSM.AutoSize = true;
            this.cbRSM.Location = new System.Drawing.Point(6, 126);
            this.cbRSM.Name = "cbRSM";
            this.cbRSM.Size = new System.Drawing.Size(195, 20);
            this.cbRSM.TabIndex = 4;
            this.cbRSM.Text = "Remote Service Management";
            this.cbRSM.UseVisualStyleBackColor = true;
            this.cbRSM.MouseHover += new System.EventHandler(this.gbFirewall_MouseHover);
            // 
            // cbRD
            // 
            this.cbRD.AutoSize = true;
            this.cbRD.Location = new System.Drawing.Point(6, 100);
            this.cbRD.Name = "cbRD";
            this.cbRD.Size = new System.Drawing.Size(120, 20);
            this.cbRD.TabIndex = 3;
            this.cbRD.Text = "Remote Desktop";
            this.cbRD.UseVisualStyleBackColor = true;
            this.cbRD.MouseHover += new System.EventHandler(this.gbFirewall_MouseHover);
            // 
            // cbRA
            // 
            this.cbRA.AutoSize = true;
            this.cbRA.Location = new System.Drawing.Point(6, 74);
            this.cbRA.Name = "cbRA";
            this.cbRA.Size = new System.Drawing.Size(157, 20);
            this.cbRA.TabIndex = 2;
            this.cbRA.Text = "Remote Administration";
            this.cbRA.UseVisualStyleBackColor = true;
            this.cbRA.MouseHover += new System.EventHandler(this.gbFirewall_MouseHover);
            // 
            // cbRM
            // 
            this.cbRM.AutoSize = true;
            this.cbRM.Location = new System.Drawing.Point(6, 48);
            this.cbRM.Name = "cbRM";
            this.cbRM.Size = new System.Drawing.Size(149, 20);
            this.cbRM.TabIndex = 1;
            this.cbRM.Text = "Remote Management";
            this.cbRM.UseVisualStyleBackColor = true;
            this.cbRM.MouseHover += new System.EventHandler(this.gbFirewall_MouseHover);
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.Location = new System.Drawing.Point(12, 309);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(695, 60);
            this.tbInfo.TabIndex = 6;
            this.tbInfo.Text = "Hover over a control to see info on it.";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Green;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(229, 274);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(181, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Make &Adjustments";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // gbRFC1323
            // 
            this.gbRFC1323.Controls.Add(this.rbYesTSWS);
            this.gbRFC1323.Controls.Add(this.rbNoWS);
            this.gbRFC1323.Controls.Add(this.rbNoTS);
            this.gbRFC1323.Controls.Add(this.rbNoTSWS);
            this.gbRFC1323.Location = new System.Drawing.Point(228, 112);
            this.gbRFC1323.Name = "gbRFC1323";
            this.gbRFC1323.Size = new System.Drawing.Size(113, 112);
            this.gbRFC1323.TabIndex = 7;
            this.gbRFC1323.TabStop = false;
            this.gbRFC1323.Text = "RFC 1323";
            this.gbRFC1323.MouseHover += new System.EventHandler(this.gbRFC1323_MouseHover);
            // 
            // rbYesTSWS
            // 
            this.rbYesTSWS.AutoSize = true;
            this.rbYesTSWS.Location = new System.Drawing.Point(6, 87);
            this.rbYesTSWS.Name = "rbYesTSWS";
            this.rbYesTSWS.Size = new System.Drawing.Size(47, 17);
            this.rbYesTSWS.TabIndex = 3;
            this.rbYesTSWS.TabStop = true;
            this.rbYesTSWS.Text = "Both";
            this.rbYesTSWS.UseVisualStyleBackColor = true;
            this.rbYesTSWS.MouseHover += new System.EventHandler(this.gbRFC1323_MouseHover);
            // 
            // rbNoWS
            // 
            this.rbNoWS.AutoSize = true;
            this.rbNoWS.Location = new System.Drawing.Point(6, 64);
            this.rbNoWS.Name = "rbNoWS";
            this.rbNoWS.Size = new System.Drawing.Size(81, 17);
            this.rbNoWS.TabIndex = 2;
            this.rbNoWS.TabStop = true;
            this.rbNoWS.Text = "Timestamps";
            this.rbNoWS.UseVisualStyleBackColor = true;
            this.rbNoWS.MouseHover += new System.EventHandler(this.gbRFC1323_MouseHover);
            // 
            // rbNoTS
            // 
            this.rbNoTS.AutoSize = true;
            this.rbNoTS.Location = new System.Drawing.Point(6, 41);
            this.rbNoTS.Name = "rbNoTS";
            this.rbNoTS.Size = new System.Drawing.Size(102, 17);
            this.rbNoTS.TabIndex = 1;
            this.rbNoTS.TabStop = true;
            this.rbNoTS.Text = "Window Scaling";
            this.rbNoTS.UseVisualStyleBackColor = true;
            this.rbNoTS.MouseHover += new System.EventHandler(this.gbRFC1323_MouseHover);
            // 
            // rbNoTSWS
            // 
            this.rbNoTSWS.AutoSize = true;
            this.rbNoTSWS.Location = new System.Drawing.Point(6, 18);
            this.rbNoTSWS.Name = "rbNoTSWS";
            this.rbNoTSWS.Size = new System.Drawing.Size(51, 17);
            this.rbNoTSWS.TabIndex = 0;
            this.rbNoTSWS.TabStop = true;
            this.rbNoTSWS.Text = "None";
            this.rbNoTSWS.UseVisualStyleBackColor = true;
            this.rbNoTSWS.MouseHover += new System.EventHandler(this.gbRFC1323_MouseHover);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 372);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(526, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Network optimization program for Windows Vista and 7. Requires admin rights. No w" +
                "arranty is implied in its use.";
            // 
            // llDeveloper
            // 
            this.llDeveloper.AutoSize = true;
            this.llDeveloper.Location = new System.Drawing.Point(12, 396);
            this.llDeveloper.Name = "llDeveloper";
            this.llDeveloper.Size = new System.Drawing.Size(161, 13);
            this.llDeveloper.TabIndex = 9;
            this.llDeveloper.TabStop = true;
            this.llDeveloper.Text = "Michael Adams, unquietwiki.com";
            this.llDeveloper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDeveloper_LinkClicked);
            // 
            // llLicence
            // 
            this.llLicence.AutoSize = true;
            this.llLicence.Location = new System.Drawing.Point(661, 396);
            this.llLicence.Name = "llLicence";
            this.llLicence.Size = new System.Drawing.Size(44, 13);
            this.llLicence.TabIndex = 10;
            this.llLicence.TabStop = true;
            this.llLicence.Text = "License";
            this.llLicence.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLicence_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 419);
            this.Controls.Add(this.llLicence);
            this.Controls.Add(this.llDeveloper);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gbRFC1323);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.gbFirewall);
            this.Controls.Add(this.gbIPv6);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbNetOpt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NetToggle: October 2011 v2";
            this.gbNetOpt.ResumeLayout(false);
            this.gbIPv6.ResumeLayout(false);
            this.gbIPv6.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbFirewall.ResumeLayout(false);
            this.gbFirewall.PerformLayout();
            this.gbRFC1323.ResumeLayout(false);
            this.gbRFC1323.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStandard;
        private System.Windows.Forms.Button btnNothing;
        private System.Windows.Forms.GroupBox gbNetOpt;
        private System.Windows.Forms.Button btnHyperV;
        private System.Windows.Forms.Button btnWireless;
        private System.Windows.Forms.GroupBox gbIPv6;
        private System.Windows.Forms.CheckBox cbPA;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.CheckBox cbTC;
        private System.Windows.Forms.CheckBox cbCT;
        private System.Windows.Forms.CheckBox cbECN;
        private System.Windows.Forms.CheckBox cbDMA;
        private System.Windows.Forms.CheckBox cbRSS;
        private System.Windows.Forms.CheckBox cbDCA;
        private System.Windows.Forms.GroupBox gbFirewall;
        private System.Windows.Forms.CheckBox cbPing;
        private System.Windows.Forms.CheckBox cbWMI;
        private System.Windows.Forms.CheckBox cbRVM;
        private System.Windows.Forms.CheckBox cbRSM;
        private System.Windows.Forms.CheckBox cbRD;
        private System.Windows.Forms.CheckBox cbRA;
        private System.Windows.Forms.CheckBox cbRM;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnAggressive;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.GroupBox gbRFC1323;
        private System.Windows.Forms.RadioButton rbYesTSWS;
        private System.Windows.Forms.RadioButton rbNoWS;
        private System.Windows.Forms.RadioButton rbNoTS;
        private System.Windows.Forms.RadioButton rbNoTSWS;
        private System.Windows.Forms.CheckBox cb6to4;
        private System.Windows.Forms.CheckBox cbISATAP;
        private System.Windows.Forms.CheckBox cbTeredo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.LinkLabel llDeveloper;
        private System.Windows.Forms.LinkLabel llLicence;
    }
}

