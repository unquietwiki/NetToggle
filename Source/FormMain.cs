//NetToggle
//Michael Adams, unquietwiki.com, Oct 10, 2011

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace NetToggle
{
    public partial class frmMain : Form
    {
        //Default constructor
        public frmMain()
        {
            InitializeComponent();
        }

        //Netsh command handler
        private void netsh(string cmd)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = System.Environment.SystemDirectory + "\\netsh.exe";
            ps.Arguments = cmd;
            ps.CreateNoWindow = true;
            Process.Start(ps);
        }

        //Clear all checkboxes
        private void naked()
        {
            cbCT.Checked = false;
            cbTC.Checked = false;
            cbECN.Checked = false;
            cbRSS.Checked = false;
            cbDCA.Checked = false;
            cbDMA.Checked = false;
            cbPA.Checked = false;
            cbPing.Checked = false;
            cbRM.Checked = false;
            cbRA.Checked = false;
            cbRD.Checked = false;
            cbRSM.Checked = false;
            cbRVM.Checked = false;
            cbWMI.Checked = false;
            rbNoTSWS.Checked = true;
            cb6to4.Checked = false;
            cbISATAP.Checked = false;
            cbTeredo.Checked = false;
        }

        //Standard profile
        private void standard()
        {
            naked();
            cbCT.Checked = true;
            cbTC.Checked = true;
            cbPing.Checked = true;
            rbYesTSWS.Checked = true;
        }

        //"Nothing"
        private void btnNothing_Click(object sender, EventArgs e)
        {
            naked();
        }

        //"Standard"
        private void btnStandard_Click(object sender, EventArgs e)
        {
            standard();
        }

        //"Aggressive" (formerly "Turbo")
        private void btnAggressive_Click(object sender, EventArgs e)
        {
            standard();
            cbECN.Checked = true;
            cbRSS.Checked = true;
            cbDCA.Checked = true;
            cbDMA.Checked = true;
            cbTC.Checked = false;
        }

        //"Wireless"
        private void btnWireless_Click(object sender, EventArgs e)
        {
            naked();
            cbCT.Checked = true;
            cbPing.Checked = true;
            rbNoWS.Checked = true;
        }

        //"Hyper-V"
        private void btnHyperV_Click(object sender, EventArgs e)
        {
            standard();
            cbECN.Checked = true;
            cbRM.Checked = true;
            cbRA.Checked = true;
            cbRD.Checked = true;
            cbRSM.Checked = true;
            cbRVM.Checked = true;
            cbWMI.Checked = true;
            rbYesTSWS.Checked = true;
        }

        //"Default"
        private void btnDefault_Click(object sender, EventArgs e)
        {
            naked();
            cbCT.Checked = true;
            cbPA.Checked = true;
            cb6to4.Checked = true;
            cbISATAP.Checked = true;
            cbTeredo.Checked = true;
        }

        //Enact 1323 options
        //Reference http://technet.microsoft.com/en-us/library/cc938205.aspx
        private void enact1323()
        {            
            int choice = 0;
            if (rbNoTS.Checked) choice = 1;
            if (rbNoWS.Checked) choice = 2;
            if (rbYesTSWS.Checked) choice = 3;
            RegistryKey regkey = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters");
            regkey.SetValue("RFC1323Opts", choice, RegistryValueKind.DWord);
        }

        //"Make Adjustments", aka go button
        private void btnGo_Click(object sender, EventArgs e)
        {
            //Quick routines
            enact1323();

            //General rules
            if (cbPing.Checked == true) netsh("firewall set icmpsetting 8 enable"); else netsh("firewall set icmpsetting 8 disable");
            if (cbCT.Checked == true) netsh("int tcp set global congestion=ctcp"); else netsh("int tcp set global congestion=none");
            if (cbTC.Checked == true) netsh("int tcp set global chimney=enable"); else netsh("int tcp set global chimney=disable");
            if (cbECN.Checked == true) netsh("int tcp set global ecn=enable"); else netsh("int tcp set global ecn=disable");
            if (cbRSS.Checked == true) netsh("int tcp set global rss=enable"); else netsh("int tcp set global rss=disable");
            if (cbDCA.Checked == true) netsh("int tcp set global dca=enable"); else netsh("int tcp set global dca=disable");
            if (cbDMA.Checked == true) netsh("int tcp set global netdma=enable"); else netsh("int tcp set global netdma=disable");
            if (cb6to4.Checked == true) netsh("int ipv6 6to4 set state state=enable"); else netsh("int ipv6 6to4 set state state=disable");
            if (cbISATAP.Checked == true) netsh("int ipv6 isatap set state state=enable"); else netsh("int ipv6 isatap set state state=disable");
            if (cbTeredo.Checked == true) netsh("int ipv6 set teredo enable"); else netsh("int ipv6 set teredo disable");

            //Firewall rules
            if (cbRM.Checked == true) netsh("advfirewall set currentprofile settings remotemanagement enable");
                else netsh("advfirewall set currentprofile settings remotemanagement disable");
            if (cbRA.Checked == true) netsh("advfirewall firewall set rule group=\"Remote Administration\" new enable=yes");
                else netsh("advfirewall firewall set rule group=\"Remote Administration\" enable=no");
            if (cbRD.Checked == true) netsh("advfirewall firewall set rule group=\"Remote Desktop\" new enable=yes");
                else netsh("advfirewall firewall set rule group=\"Remote Desktop\" enable=no");
            if (cbRSM.Checked == true) netsh("advfirewall firewall set rule group=\"Remote Service Management\" new enable=yes");
                else netsh("advfirewall firewall set rule group=\"Remote Service Management\" enable=no");
            if (cbRVM.Checked == true) netsh("advfirewall firewall set rule group=\"Remote Volume Management\" new enable=yes");
                else netsh("advfirewall firewall set rule group=\"Remote Volume Management\" enable=no");
            if (cbWMI.Checked == true) netsh("advfirewall firewall set rule group=\"Windows Management Instrumentation (WMI)\" new enable=yes");
                else netsh("advfirewall firewall set rule group=\"Windows Management Instrumentation (WMI)\" enable=no");
            if (cbPA.Checked == true) netsh("int ipv6 set privacy state=enable"); else netsh("int ipv6 set privacy state=disable");

            //Done
            MessageBox.Show("Adjustments completed. You may need to restart your networking, or system, for some to take effect.","NetToggle");
        }

        //Hovertext tips
        private void setHoverText(int choice)
        {
            string hovertext = "";
            switch (choice)
            {
                case 1: hovertext = "Standard networking optimization, using safe settings."; break;
                case 2: hovertext = "Wireless optimization. Glanced at RFC3481 for the 1323 options. ECN breaks on some wireless setups."; break;
                case 3: hovertext = "Aggressive optimization. Requires newest hardware for some options to work right."; break;
                case 4: hovertext = "Hyper-V optimization. You should use HVRemote (http://archive.msdn.microsoft.com/HVRemote) for additional settings."; break;
                case 5: hovertext = "Default: my best attempt at OS-default settings. Vista and 7 have their own ideas."; break;
                case 6: hovertext = "Nothing: all options are disabled."; break;
                case 7: hovertext = "Compound TCP is Microsoft's improved TCP congestion control. Ref: http://en.wikipedia.org/wiki/Compound_TCP"; break;
                case 8: hovertext = "ECN is supposed to figure out when networking lines are jammed. Doesn't always work. Ref: http://en.wikipedia.org/wiki/Explicit_Congestion_Notification"; break;
                case 9: hovertext = "TCP Chimney is supposed to offload networking activity to the networking adapter (vs the CPU). Ref: http://technet.microsoft.com/en-us/network/dd277645"; break;
                case 10: hovertext = "Receive-Side Scaling allows networking to be handled by multiple CPUs. Ref: http://msdn.microsoft.com/en-us/library/windows/hardware/ff556942%28v=vs.85%29.aspx"; break;
                case 11: hovertext = "NetDMA accelerates memory use by a networking adapter. Requires newer system. Ref: http://technet.microsoft.com/en-us/library/gg162687%28WS.10%29.aspx"; break;
                case 12: hovertext = "Direct Cache Access is used to tie NetDMA to a CPU cache. Ref: http://msdn.microsoft.com/en-us/library/windows/hardware/ff546436%28v=vs.85%29.aspx"; break;
                case 13: hovertext = "RFC1323 is an older set of tools to improve TCP performance. Window scaling helps with large transfers, but doesn't always work. Timestamps prevent packet duplication, but adds overhead. Ref: http://technet.microsoft.com/en-us/library/cc938205.aspx"; break;
                case 14: hovertext = "Assorted firewall rules: they're more for sysadmin use."; break;
                case 15: hovertext = "RFC4941 defines temporary addresses for IPv6 use. Increases privacy, but makes troubleshooting harder. Linux and OSX disable them by default."; break;
                case 16: hovertext = "RFC4380 (Teredo) was created by Microsoft to tunnel IPv6 through home networks, using UDP. Business networks HATE this. Doesn't always work."; break;
                case 17: hovertext = "RFC5214 (ISATAP) builds automatic IPv6 tunnels between IPv4 hosts. More info: http://www.isatap.org/"; break;
                case 18: hovertext = "RFC3056 (6to4) is normally used to enable global IPv6 access via a public relay router. RFC4213 (6in4) is a far more stable alternative."; break;
                default: break;
            }
            tbInfo.Text = hovertext;
        }

        private void btnStandard_MouseHover(object sender, EventArgs e)
        {
            setHoverText(1);
        }

        private void llDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://unquietwiki.com/");
        }

        private void llLicence_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.apache.org/licenses/LICENSE-2.0.html");
        }

        private void btnWireless_MouseHover(object sender, EventArgs e)
        {
            setHoverText(2);
        }

        private void btnAggressive_MouseHover(object sender, EventArgs e)
        {
            setHoverText(3);
        }

        private void btnHyperV_MouseHover(object sender, EventArgs e)
        {
            setHoverText(4);
        }

        private void btnDefault_MouseHover(object sender, EventArgs e)
        {
            setHoverText(5);
        }

        private void btnNothing_MouseHover(object sender, EventArgs e)
        {
            setHoverText(6);
        }

        private void cbCT_MouseHover(object sender, EventArgs e)
        {
            setHoverText(7);
        }

        private void cbECN_MouseHover(object sender, EventArgs e)
        {
            setHoverText(8);
        }

        private void cbTC_MouseHover(object sender, EventArgs e)
        {
            setHoverText(9);
        }

        private void cbDCA_MouseHover(object sender, EventArgs e)
        {
            setHoverText(12);
        }

        private void cbRSS_MouseHover(object sender, EventArgs e)
        {
            setHoverText(10);
        }

        private void cbDMA_MouseHover(object sender, EventArgs e)
        {
            setHoverText(11);
        }

        private void gbRFC1323_MouseHover(object sender, EventArgs e)
        {
            setHoverText(13);
        }

        private void gbFirewall_MouseHover(object sender, EventArgs e)
        {
            setHoverText(14);
        }

        private void cbPA_MouseHover(object sender, EventArgs e)
        {
            setHoverText(15);
        }

        private void cbTeredo_MouseHover(object sender, EventArgs e)
        {
            setHoverText(16);
        }

        private void cbISATAP_MouseHover(object sender, EventArgs e)
        {
            setHoverText(17);
        }

        private void cb6to4_MouseHover(object sender, EventArgs e)
        {
            setHoverText(18);
        }

    }
}
