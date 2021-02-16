namespace Proiect_Diploma
{
    partial class Prezentare_alg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prezentare_alg));
            this.label1 = new System.Windows.Forms.Label();
            this.aes1 = new System.Windows.Forms.PictureBox();
            this.rc41 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnInfoRC4 = new System.Windows.Forms.PictureBox();
            this.BtnInfoAES = new System.Windows.Forms.PictureBox();
            this.BtnIesire = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rc41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInfoRC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInfoAES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnIesire)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(87, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algoritmi de criptare";
            // 
            // aes1
            // 
            this.aes1.BackColor = System.Drawing.Color.Transparent;
            this.aes1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aes1.Image = ((System.Drawing.Image)(resources.GetObject("aes1.Image")));
            this.aes1.Location = new System.Drawing.Point(23, 257);
            this.aes1.Name = "aes1";
            this.aes1.Size = new System.Drawing.Size(133, 124);
            this.aes1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aes1.TabIndex = 1;
            this.aes1.TabStop = false;
            this.aes1.Click += new System.EventHandler(this.aes1_Click);
            // 
            // rc41
            // 
            this.rc41.BackColor = System.Drawing.Color.Transparent;
            this.rc41.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rc41.Image = ((System.Drawing.Image)(resources.GetObject("rc41.Image")));
            this.rc41.Location = new System.Drawing.Point(413, 257);
            this.rc41.Name = "rc41";
            this.rc41.Size = new System.Drawing.Size(133, 124);
            this.rc41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rc41.TabIndex = 2;
            this.rc41.TabStop = false;
            this.rc41.Click += new System.EventHandler(this.rc41_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "AES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(437, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "RC4";
            // 
            // BtnInfoRC4
            // 
            this.BtnInfoRC4.BackColor = System.Drawing.Color.Transparent;
            this.BtnInfoRC4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInfoRC4.Image = ((System.Drawing.Image)(resources.GetObject("BtnInfoRC4.Image")));
            this.BtnInfoRC4.Location = new System.Drawing.Point(430, 387);
            this.BtnInfoRC4.Name = "BtnInfoRC4";
            this.BtnInfoRC4.Size = new System.Drawing.Size(86, 60);
            this.BtnInfoRC4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnInfoRC4.TabIndex = 5;
            this.BtnInfoRC4.TabStop = false;
            this.BtnInfoRC4.Click += new System.EventHandler(this.BtnInfoRC4_Click);
            // 
            // BtnInfoAES
            // 
            this.BtnInfoAES.BackColor = System.Drawing.Color.Transparent;
            this.BtnInfoAES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInfoAES.ErrorImage = null;
            this.BtnInfoAES.Image = ((System.Drawing.Image)(resources.GetObject("BtnInfoAES.Image")));
            this.BtnInfoAES.Location = new System.Drawing.Point(42, 387);
            this.BtnInfoAES.Name = "BtnInfoAES";
            this.BtnInfoAES.Size = new System.Drawing.Size(86, 60);
            this.BtnInfoAES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnInfoAES.TabIndex = 6;
            this.BtnInfoAES.TabStop = false;
            this.BtnInfoAES.Click += new System.EventHandler(this.BtnInfoAES_Click);
            // 
            // BtnIesire
            // 
            this.BtnIesire.BackColor = System.Drawing.Color.Transparent;
            this.BtnIesire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIesire.Image = ((System.Drawing.Image)(resources.GetObject("BtnIesire.Image")));
            this.BtnIesire.Location = new System.Drawing.Point(242, 406);
            this.BtnIesire.Name = "BtnIesire";
            this.BtnIesire.Size = new System.Drawing.Size(78, 71);
            this.BtnIesire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnIesire.TabIndex = 7;
            this.BtnIesire.TabStop = false;
            this.BtnIesire.Click += new System.EventHandler(this.BtnIesire_Click);
            // 
            // Prezentare_alg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(558, 557);
            this.Controls.Add(this.BtnIesire);
            this.Controls.Add(this.BtnInfoAES);
            this.Controls.Add(this.BtnInfoRC4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rc41);
            this.Controls.Add(this.aes1);
            this.Controls.Add(this.label1);
            this.Name = "Prezentare_alg";
            this.Text = "Prezentare Algoritmi";
            ((System.ComponentModel.ISupportInitialize)(this.aes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rc41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInfoRC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInfoAES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnIesire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox aes1;
        private System.Windows.Forms.PictureBox rc41;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox BtnInfoRC4;
        private System.Windows.Forms.PictureBox BtnInfoAES;
        private System.Windows.Forms.PictureBox BtnIesire;
    }
}

