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

namespace iBoy_RAM
{
    public partial class iBoy : Form
    {
        public iBoy()
        {
            InitializeComponent();
            txt_ECID.Text = "";
            txt_mode.Text = "";
            txt_model.Text = "";
            txt_status.Text = "";
            txt_Type.Text = "";
            progressBar1.Value = 0;
            txt_info.Text = "";

        }
        private void check_device(object sender, EventArgs e)
        {
            getIdeviceInfo();
        }

        string path = Environment.CurrentDirectory;
        public void getIdeviceInfo()
        {
            //process identify
            progressBar1.Value = 0;
            ProcessStartInfo ideviceinfo = new ProcessStartInfo();
            ideviceinfo.FileName = path + "/files/irecovery.exe";
            ideviceinfo.Arguments = "-q";
            ideviceinfo.UseShellExecute = false;
            ideviceinfo.CreateNoWindow = true;    
            ideviceinfo.RedirectStandardOutput = true;
            ideviceinfo.RedirectStandardError = true;

            //start process
            using (Process exeProcess = Process.Start(ideviceinfo))
            {
                exeProcess.WaitForExit();
                progressBar1.Value = 100;
                var exitCode = exeProcess.ExitCode;
                var output = exeProcess.StandardOutput.ReadToEnd();
                var error = exeProcess.StandardError.ReadToEnd();

                if (output.Length > 0)
                {
                    txt_info.Text = "Device Connected in DFU Mode";
                    richTextBox1.Text = output;
                } else
                {
                    txt_info.Text = "No Device Detected, Please check Driver/Cable";
                    richTextBox1.Text = error;
                }
            }
        }
    }
}
