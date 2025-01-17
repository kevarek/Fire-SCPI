﻿namespace SCPI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_capture = new System.Windows.Forms.Button();
            this.cBox_Extension = new System.Windows.Forms.ComboBox();
            this.chBox_Color = new System.Windows.Forms.CheckBox();
            this.chBox_Invert = new System.Windows.Forms.CheckBox();
            this.TextBoxFilePath = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.IP3 = new System.Windows.Forms.NumericUpDown();
            this.IP4 = new System.Windows.Forms.NumericUpDown();
            this.IP2 = new System.Windows.Forms.NumericUpDown();
            this.IP1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyToClipboardCB = new System.Windows.Forms.CheckBox();
            this.BeepCB = new System.Windows.Forms.CheckBox();
            this.HotkeyCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.IP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_capture
            // 
            this.btn_capture.Location = new System.Drawing.Point(21, 95);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(334, 40);
            this.btn_capture.TabIndex = 10;
            this.btn_capture.Text = "Capture";
            this.btn_capture.UseVisualStyleBackColor = true;
            this.btn_capture.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBox_Extension
            // 
            this.cBox_Extension.FormattingEnabled = true;
            this.cBox_Extension.Items.AddRange(new object[] {
            "BMP24",
            "BMP8",
            "PNG",
            "JPEG",
            "TIFF"});
            this.cBox_Extension.Location = new System.Drawing.Point(261, 68);
            this.cBox_Extension.Name = "cBox_Extension";
            this.cBox_Extension.Size = new System.Drawing.Size(94, 21);
            this.cBox_Extension.TabIndex = 9;
            // 
            // chBox_Color
            // 
            this.chBox_Color.AutoSize = true;
            this.chBox_Color.Checked = true;
            this.chBox_Color.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBox_Color.Location = new System.Drawing.Point(21, 70);
            this.chBox_Color.Name = "chBox_Color";
            this.chBox_Color.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBox_Color.Size = new System.Drawing.Size(50, 17);
            this.chBox_Color.TabIndex = 7;
            this.chBox_Color.Text = "Color";
            this.chBox_Color.UseVisualStyleBackColor = true;
            // 
            // chBox_Invert
            // 
            this.chBox_Invert.AutoSize = true;
            this.chBox_Invert.Location = new System.Drawing.Point(76, 70);
            this.chBox_Invert.Name = "chBox_Invert";
            this.chBox_Invert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBox_Invert.Size = new System.Drawing.Size(53, 17);
            this.chBox_Invert.TabIndex = 8;
            this.chBox_Invert.Text = "Invert";
            this.chBox_Invert.UseVisualStyleBackColor = true;
            // 
            // TextBoxFilePath
            // 
            this.TextBoxFilePath.Location = new System.Drawing.Point(21, 44);
            this.TextBoxFilePath.Name = "TextBoxFilePath";
            this.TextBoxFilePath.Size = new System.Drawing.Size(334, 20);
            this.TextBoxFilePath.TabIndex = 6;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(280, 15);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // IP3
            // 
            this.IP3.Location = new System.Drawing.Point(178, 18);
            this.IP3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IP3.Name = "IP3";
            this.IP3.Size = new System.Drawing.Size(45, 20);
            this.IP3.TabIndex = 3;
            // 
            // IP4
            // 
            this.IP4.Location = new System.Drawing.Point(229, 18);
            this.IP4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IP4.Name = "IP4";
            this.IP4.Size = new System.Drawing.Size(45, 20);
            this.IP4.TabIndex = 4;
            // 
            // IP2
            // 
            this.IP2.Location = new System.Drawing.Point(127, 18);
            this.IP2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IP2.Name = "IP2";
            this.IP2.Size = new System.Drawing.Size(45, 20);
            this.IP2.TabIndex = 2;
            // 
            // IP1
            // 
            this.IP1.Location = new System.Drawing.Point(76, 18);
            this.IP1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IP1.Name = "IP1";
            this.IP1.Size = new System.Drawing.Size(45, 20);
            this.IP1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP Address";
            // 
            // CopyToClipboardCB
            // 
            this.CopyToClipboardCB.AutoSize = true;
            this.CopyToClipboardCB.Location = new System.Drawing.Point(21, 142);
            this.CopyToClipboardCB.Name = "CopyToClipboardCB";
            this.CopyToClipboardCB.Size = new System.Drawing.Size(108, 17);
            this.CopyToClipboardCB.TabIndex = 11;
            this.CopyToClipboardCB.Text = "Copy to clipboard";
            this.CopyToClipboardCB.UseVisualStyleBackColor = true;
            // 
            // BeepCB
            // 
            this.BeepCB.AutoSize = true;
            this.BeepCB.Location = new System.Drawing.Point(136, 142);
            this.BeepCB.Name = "BeepCB";
            this.BeepCB.Size = new System.Drawing.Size(125, 17);
            this.BeepCB.TabIndex = 12;
            this.BeepCB.Text = "Beep when captured";
            this.BeepCB.UseVisualStyleBackColor = true;
            // 
            // HotkeyCB
            // 
            this.HotkeyCB.AutoSize = true;
            this.HotkeyCB.Location = new System.Drawing.Point(21, 165);
            this.HotkeyCB.Name = "HotkeyCB";
            this.HotkeyCB.Size = new System.Drawing.Size(252, 17);
            this.HotkeyCB.TabIndex = 13;
            this.HotkeyCB.Text = "Enable global hotkey for capture (Alt + Shift + S)";
            this.HotkeyCB.UseVisualStyleBackColor = true;
            this.HotkeyCB.CheckedChanged += new System.EventHandler(this.HotkeyCB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 194);
            this.Controls.Add(this.HotkeyCB);
            this.Controls.Add(this.BeepCB);
            this.Controls.Add(this.CopyToClipboardCB);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.IP3);
            this.Controls.Add(this.IP4);
            this.Controls.Add(this.IP2);
            this.Controls.Add(this.IP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxFilePath);
            this.Controls.Add(this.chBox_Invert);
            this.Controls.Add(this.chBox_Color);
            this.Controls.Add(this.cBox_Extension);
            this.Controls.Add(this.btn_capture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rigol DS1054Z screen capture 1.0-RC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.IP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_capture;
        private System.Windows.Forms.ComboBox cBox_Extension;
        private System.Windows.Forms.CheckBox chBox_Color;
        private System.Windows.Forms.CheckBox chBox_Invert;
        private System.Windows.Forms.TextBox TextBoxFilePath;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.NumericUpDown IP3;
        private System.Windows.Forms.NumericUpDown IP4;
        private System.Windows.Forms.NumericUpDown IP2;
        private System.Windows.Forms.NumericUpDown IP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CopyToClipboardCB;
        private System.Windows.Forms.CheckBox BeepCB;
        private System.Windows.Forms.CheckBox HotkeyCB;
    }
}

