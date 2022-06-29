namespace iBoy_RAM
{
    partial class iBoy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iBoy));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_checkdev = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_activate = new System.Windows.Forms.Button();
            this.btn_owner_info = new System.Windows.Forms.Button();
            this.btn_fix_sisv = new System.Windows.Forms.Button();
            this.txt_info = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_boot1 = new System.Windows.Forms.Button();
            this.btn_boot2 = new System.Windows.Forms.Button();
            this.btn_checkSSH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ECID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Type = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CPID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 325);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(686, 10);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_checkdev);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 146);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ramdisk Menu";
            // 
            // btn_checkdev
            // 
            this.btn_checkdev.Location = new System.Drawing.Point(10, 28);
            this.btn_checkdev.Name = "btn_checkdev";
            this.btn_checkdev.Size = new System.Drawing.Size(130, 23);
            this.btn_checkdev.TabIndex = 4;
            this.btn_checkdev.Text = "Check Device (DFU)";
            this.btn_checkdev.UseVisualStyleBackColor = true;
            this.btn_checkdev.Click += new System.EventHandler(this.check_device);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "BOOT 1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "BOOT 2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Check SSH";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_backup);
            this.groupBox3.Controls.Add(this.btn_activate);
            this.groupBox3.Controls.Add(this.btn_owner_info);
            this.groupBox3.Controls.Add(this.btn_fix_sisv);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(165, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 146);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TOOLS";
            // 
            // btn_backup
            // 
            this.btn_backup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.Location = new System.Drawing.Point(10, 28);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(130, 23);
            this.btn_backup.TabIndex = 4;
            this.btn_backup.Text = "Backup Activation";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_activate
            // 
            this.btn_activate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_activate.Location = new System.Drawing.Point(10, 57);
            this.btn_activate.Name = "btn_activate";
            this.btn_activate.Size = new System.Drawing.Size(130, 23);
            this.btn_activate.TabIndex = 5;
            this.btn_activate.Text = "Restore Activation";
            this.btn_activate.UseVisualStyleBackColor = true;
            this.btn_activate.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_owner_info
            // 
            this.btn_owner_info.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_owner_info.Location = new System.Drawing.Point(10, 86);
            this.btn_owner_info.Name = "btn_owner_info";
            this.btn_owner_info.Size = new System.Drawing.Size(130, 23);
            this.btn_owner_info.TabIndex = 6;
            this.btn_owner_info.Text = "Owner Info";
            this.btn_owner_info.UseVisualStyleBackColor = true;
            this.btn_owner_info.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_fix_sisv
            // 
            this.btn_fix_sisv.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fix_sisv.Location = new System.Drawing.Point(10, 115);
            this.btn_fix_sisv.Name = "btn_fix_sisv";
            this.btn_fix_sisv.Size = new System.Drawing.Size(130, 23);
            this.btn_fix_sisv.TabIndex = 7;
            this.btn_fix_sisv.Text = "Fix Notification";
            this.btn_fix_sisv.UseVisualStyleBackColor = true;
            this.btn_fix_sisv.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // txt_info
            // 
            this.txt_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_info.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_info.Location = new System.Drawing.Point(0, 307);
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(686, 18);
            this.txt_info.TabIndex = 9;
            this.txt_info.Text = "INFO HERE";
            this.txt_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.richTextBox1.Location = new System.Drawing.Point(319, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(355, 258);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btn_boot1);
            this.groupBox4.Controls.Add(this.btn_boot2);
            this.groupBox4.Controls.Add(this.btn_checkSSH);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 146);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ramdisk Menu";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Check Device (DFU)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.check_device);
            // 
            // btn_boot1
            // 
            this.btn_boot1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_boot1.Location = new System.Drawing.Point(10, 57);
            this.btn_boot1.Name = "btn_boot1";
            this.btn_boot1.Size = new System.Drawing.Size(130, 23);
            this.btn_boot1.TabIndex = 5;
            this.btn_boot1.Text = "BOOT 1";
            this.btn_boot1.UseVisualStyleBackColor = true;
            this.btn_boot1.Click += new System.EventHandler(this.btn_boot1_Click);
            // 
            // btn_boot2
            // 
            this.btn_boot2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_boot2.Location = new System.Drawing.Point(10, 86);
            this.btn_boot2.Name = "btn_boot2";
            this.btn_boot2.Size = new System.Drawing.Size(130, 23);
            this.btn_boot2.TabIndex = 6;
            this.btn_boot2.Text = "BOOT 2";
            this.btn_boot2.UseVisualStyleBackColor = true;
            this.btn_boot2.Click += new System.EventHandler(this.btn_boot1_Click);
            // 
            // btn_checkSSH
            // 
            this.btn_checkSSH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkSSH.Location = new System.Drawing.Point(10, 115);
            this.btn_checkSSH.Name = "btn_checkSSH";
            this.btn_checkSSH.Size = new System.Drawing.Size(130, 23);
            this.btn_checkSSH.TabIndex = 7;
            this.btn_checkSSH.Text = "Check SSH";
            this.btn_checkSSH.UseVisualStyleBackColor = true;
            this.btn_checkSSH.Click += new System.EventHandler(this.btn_boot1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model  :";
            // 
            // txt_model
            // 
            this.txt_model.AutoSize = true;
            this.txt_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_model.Location = new System.Drawing.Point(54, 36);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(52, 13);
            this.txt_model.TabIndex = 1;
            this.txt_model.Text = "txt_model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ECID    :";
            // 
            // txt_ECID
            // 
            this.txt_ECID.AutoSize = true;
            this.txt_ECID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ECID.Location = new System.Drawing.Point(54, 63);
            this.txt_ECID.Name = "txt_ECID";
            this.txt_ECID.Size = new System.Drawing.Size(49, 13);
            this.txt_ECID.TabIndex = 3;
            this.txt_ECID.Text = "txt_ECID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Type  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "PWNED :";
            // 
            // txt_Type
            // 
            this.txt_Type.AutoSize = true;
            this.txt_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Type.Location = new System.Drawing.Point(237, 36);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(48, 13);
            this.txt_Type.TabIndex = 5;
            this.txt_Type.Text = "txt_Type";
            // 
            // txt_status
            // 
            this.txt_status.AutoSize = true;
            this.txt_status.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.ForeColor = System.Drawing.Color.Lime;
            this.txt_status.Location = new System.Drawing.Point(63, 88);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(59, 13);
            this.txt_status.TabIndex = 7;
            this.txt_status.Text = "CHECKM8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(190, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "MODE :";
            // 
            // txt_mode
            // 
            this.txt_mode.AutoSize = true;
            this.txt_mode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_mode.Location = new System.Drawing.Point(236, 63);
            this.txt_mode.Name = "txt_mode";
            this.txt_mode.Size = new System.Drawing.Size(29, 13);
            this.txt_mode.TabIndex = 9;
            this.txt_mode.Text = "DFU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CPID   :";
            // 
            // txt_CPID
            // 
            this.txt_CPID.AutoSize = true;
            this.txt_CPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CPID.Location = new System.Drawing.Point(237, 88);
            this.txt_CPID.Name = "txt_CPID";
            this.txt_CPID.Size = new System.Drawing.Size(35, 13);
            this.txt_CPID.TabIndex = 11;
            this.txt_CPID.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_CPID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_mode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_status);
            this.groupBox1.Controls.Add(this.txt_Type);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_ECID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_model);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "iDevice Info";
            // 
            // iBoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(686, 335);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "iBoy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iBoy - Ramdisk";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_checkdev;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_activate;
        private System.Windows.Forms.Button btn_owner_info;
        private System.Windows.Forms.Button btn_fix_sisv;
        private System.Windows.Forms.Label txt_info;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_boot1;
        private System.Windows.Forms.Button btn_boot2;
        private System.Windows.Forms.Button btn_checkSSH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_ECID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txt_Type;
        private System.Windows.Forms.Label txt_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_mode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_CPID;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

