
namespace BruteForce
{
    partial class BruteForce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BruteForce));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.OpenFileChoose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TryPassword = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_ServerName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ServerName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Text Dosyasını Seçiniz !!";
            this.openFileDialog1.Title = "Text Dosyasını Seçiniz !!";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.numericUpDown1.InterceptArrowKeys = false;
            this.numericUpDown1.Location = new System.Drawing.Point(387, 91);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 34);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OpenFileChoose
            // 
            this.OpenFileChoose.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OpenFileChoose.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.OpenFileChoose.Appearance.Options.UseBackColor = true;
            this.OpenFileChoose.Appearance.Options.UseFont = true;
            this.OpenFileChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileChoose.Location = new System.Drawing.Point(293, 158);
            this.OpenFileChoose.Name = "OpenFileChoose";
            this.OpenFileChoose.Size = new System.Drawing.Size(184, 38);
            this.OpenFileChoose.TabIndex = 2;
            this.OpenFileChoose.Text = "Dosyal Yolu Seç";
            this.OpenFileChoose.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 95);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(352, 30);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Text Dosyanızda Kaç Satır Var ?";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 164);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(263, 30);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "TXT Dosya Yolu Nedir ?";
            // 
            // TryPassword
            // 
            this.TryPassword.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TryPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.TryPassword.Appearance.Options.UseBackColor = true;
            this.TryPassword.Appearance.Options.UseFont = true;
            this.TryPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TryPassword.Enabled = false;
            this.TryPassword.Location = new System.Drawing.Point(12, 236);
            this.TryPassword.Name = "TryPassword";
            this.TryPassword.Size = new System.Drawing.Size(184, 38);
            this.TryPassword.TabIndex = 5;
            this.TryPassword.Text = "Şifreyi Dene";
            this.TryPassword.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(176, 30);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "SQL Sunucu/IP:";
            // 
            // Txt_ServerName
            // 
            this.Txt_ServerName.Location = new System.Drawing.Point(204, 28);
            this.Txt_ServerName.Name = "Txt_ServerName";
            this.Txt_ServerName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Txt_ServerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Txt_ServerName.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Txt_ServerName.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_ServerName.Properties.Appearance.Options.UseFont = true;
            this.Txt_ServerName.Properties.Appearance.Options.UseForeColor = true;
            this.Txt_ServerName.Size = new System.Drawing.Size(303, 36);
            this.Txt_ServerName.TabIndex = 7;
            // 
            // BruteForce
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(573, 301);
            this.Controls.Add(this.Txt_ServerName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TryPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.OpenFileChoose);
            this.Controls.Add(this.numericUpDown1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BruteForce.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "BruteForce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BruteForce";
            this.Load += new System.EventHandler(this.BruteForce_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BruteForce_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ServerName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private DevExpress.XtraEditors.SimpleButton OpenFileChoose;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton TryPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txt_ServerName;
    }
}