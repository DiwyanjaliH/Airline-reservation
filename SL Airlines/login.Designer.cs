namespace SL_Airlines
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsignin = new System.Windows.Forms.Button();
            this.mtxtid = new System.Windows.Forms.MaskedTextBox();
            this.mtxtpw = new System.Windows.Forms.MaskedTextBox();
            this.lblclose = new System.Windows.Forms.Label();
            this.btnclr = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 730);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SL_Airlines.Properties.Resources.Srilankan_airline_;
            this.pictureBox2.Location = new System.Drawing.Point(4, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(440, 511);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(440, 511);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(440, 511);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnsignin
            // 
            this.btnsignin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsignin.FlatAppearance.BorderSize = 0;
            this.btnsignin.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.ForeColor = System.Drawing.Color.Black;
            this.btnsignin.Location = new System.Drawing.Point(577, 343);
            this.btnsignin.Margin = new System.Windows.Forms.Padding(4);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(100, 42);
            this.btnsignin.TabIndex = 5;
            this.btnsignin.Text = "Sign In";
            this.btnsignin.UseVisualStyleBackColor = true;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // mtxtid
            // 
            this.mtxtid.Location = new System.Drawing.Point(648, 191);
            this.mtxtid.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtid.Name = "mtxtid";
            this.mtxtid.Size = new System.Drawing.Size(215, 22);
            this.mtxtid.TabIndex = 6;
            // 
            // mtxtpw
            // 
            this.mtxtpw.Location = new System.Drawing.Point(648, 283);
            this.mtxtpw.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtpw.Name = "mtxtpw";
            this.mtxtpw.Size = new System.Drawing.Size(215, 22);
            this.mtxtpw.TabIndex = 7;
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblclose.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclose.ForeColor = System.Drawing.Color.White;
            this.lblclose.Location = new System.Drawing.Point(941, 0);
            this.lblclose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(35, 31);
            this.lblclose.TabIndex = 8;
            this.lblclose.Text = "X";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // btnclr
            // 
            this.btnclr.FlatAppearance.BorderSize = 0;
            this.btnclr.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.Color.Black;
            this.btnclr.Location = new System.Drawing.Point(710, 343);
            this.btnclr.Margin = new System.Windows.Forms.Padding(4);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(107, 42);
            this.btnclr.TabIndex = 9;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SL_Airlines.Properties.Resources.R1;
            this.pictureBox1.Location = new System.Drawing.Point(501, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(973, 507);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.mtxtpw);
            this.Controls.Add(this.mtxtid);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(973, 507);
            this.MinimumSize = new System.Drawing.Size(973, 507);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsignin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox mtxtid;
        private System.Windows.Forms.MaskedTextBox mtxtpw;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Button btnclr;
    }
}