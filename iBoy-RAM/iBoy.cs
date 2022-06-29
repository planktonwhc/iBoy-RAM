using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Renci.SshNet;
using System.Net;

namespace iBoy_RAM
{
    public partial class iBoy : Form
    {
        //Form LOAD
        public iBoy()
        {
            //check if running
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                MessageBox.Show("Program Already Running", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            InitializeComponent();
            Empty_text();
        }
        private void check_device(object sender, EventArgs e)
        {
            Empty_text();
            getDeviceInfo();
        }

        string path = Environment.CurrentDirectory;

        public void Empty_text()
        {
            txt_ECID.Text = "";
            txt_mode.Text = "";
            txt_CPID.Text = "";
            txt_model.Text = "";
            txt_status.Text = "";
            txt_Type.Text = "";
            progressBar1.Value = 0;
            txt_info.Text = "";
        }
        private bool getDeviceInfo(string argument = @"")
        {
            CheckForIllegalCrossThreadCalls = false;
            txt_info.Text = "Checking Device in DFU Mode";

            // start process
            var ideviceinfo = new Process();
            ideviceinfo.StartInfo.FileName = path + "/files/irecovery.exe";
            ideviceinfo.StartInfo.Arguments = "-q";
            ideviceinfo.StartInfo.UseShellExecute = false;
            ideviceinfo.StartInfo.RedirectStandardOutput = true;
            ideviceinfo.StartInfo.CreateNoWindow = true;
            ideviceinfo.StartInfo.RedirectStandardError = true;  
            ideviceinfo.Start();
            progressBar1.Value = 100;
            
            //error query
            var error = ideviceinfo.StandardError.ReadToEnd();
            if (error.Length > 0)
            {
                richTextBox1.Text = error;
                txt_info.Text = "No Device Detected, Please check Driver/Cable"; 
                MessageBox.Show("No Device Detected, Please check Driver/Cable");
            }
            var lines = 0;
            //extract content
            while (!ideviceinfo.StandardOutput.EndOfStream)
            {
                
                lines++;
                string line = ideviceinfo.StandardOutput.ReadLine();
                var text2 = line.Replace("\r", "");
                richTextBox1.Text = "Click To Copy ECID";
                if (text2.StartsWith("ECID: "))
                {
                    var ECID = text2.Replace("ECID: ", "");
                    txt_ECID.Text = ECID;
                }
                else if (text2.StartsWith("CPID: "))
                {
                    var CPID = text2.Replace("CPID: ", "");
                    txt_CPID.Text = CPID;
                }
                else if (text2.StartsWith("PRODUCT: "))
                {
                    var productType = text2.Replace("PRODUCT: ", "");
                    txt_Type.Text = productType;
                }
                else if (text2.StartsWith("MODE: "))
                {
                    var mode = text2.Replace("MODE: ", "");
                    txt_mode.Text = mode;
                }
                else if (text2.StartsWith("MODEL: "))
                {
                    var text3 = text2.Replace("MODEL: ", "");
                    txt_model.Text = text3;
                }
                txt_info.Text = txt_Type.Text + " Connected in " + txt_mode.Text + " Mode";
            }
            if (lines <= 2) return false;
            return true;
        }


        //check SSH
        public void SSH_check()
        {

        }
        
        //Backup Aktivasi Records
        public void Backup_act()
        {

        }

        //Restore Activation
        public void Restore_act()
        {

        }

        //Boot to Ramdisk1
        public void BOOT_RAM1()
        {
            var send_boot = new Process();
            send_boot.StartInfo.FileName = path + "/files/irecovery.exe";
            send_boot.StartInfo.Arguments = "-f";
            send_boot.StartInfo.UseShellExecute = false;
            send_boot.StartInfo.RedirectStandardOutput = true;
            send_boot.StartInfo.CreateNoWindow = true;
            send_boot.StartInfo.RedirectStandardError = true;
            send_boot.Start();
        }

        //Boot to Ramdisk2
        public void BOOT_RAM2()
        {
            var send_boot = new Process();
            send_boot.StartInfo.FileName = path + "/files/irecovery.exe";
            send_boot.StartInfo.Arguments = "-f";
            send_boot.StartInfo.UseShellExecute = false;
            send_boot.StartInfo.RedirectStandardOutput = true;
            send_boot.StartInfo.CreateNoWindow = true;
            send_boot.StartInfo.RedirectStandardError = true;
            send_boot.Start();
        }

        private void btn_boot1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FOR Demo Only!"+ "\n" + "Source Code For Sale !", "ERROR !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Access Denied !" + "\n" + "Source Code For Sale !", "Access Denied !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
