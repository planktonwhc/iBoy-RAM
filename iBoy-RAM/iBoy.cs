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
        }

        private void check_device(object sender, EventArgs e)
        {
			using (Process process = new Process())
			{
				process.StartInfo.FileName = Environment.CurrentDirectory + "/files/irecovery.exe";
				process.StartInfo.Arguments = "-q";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				Text = process.StandardOutput.ReadToEnd();
				process.WaitForExit();
			}
			if (Text.Contains("Error"))
			{
				MessageBox.Show("Please unlock your device and press Trust !", "NOT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
			
		}
    }
}
