namespace MadeSOmePictures
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
            this.pctrbxMain = new System.Windows.Forms.PictureBox();
            this.txtbAngle = new System.Windows.Forms.TextBox();
            this.rdbRadian = new System.Windows.Forms.RadioButton();
            this.rdbAngle = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblAngle = new System.Windows.Forms.Label();
            this.tbpTrig = new System.Windows.Forms.TabControl();
            this.tbpSin = new System.Windows.Forms.TabPage();
            this.pctrbxSin = new System.Windows.Forms.PictureBox();
            this.tbpCos = new System.Windows.Forms.TabPage();
            this.pctrbxCos = new System.Windows.Forms.PictureBox();
            this.tbpCtg = new System.Windows.Forms.TabPage();
            this.pctrbxCtg = new System.Windows.Forms.PictureBox();
            this.tbpTg = new System.Windows.Forms.TabPage();
            this.pctrbxTg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxMain)).BeginInit();
            this.tbpTrig.SuspendLayout();
            this.tbpSin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSin)).BeginInit();
            this.tbpCos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxCos)).BeginInit();
            this.tbpCtg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxCtg)).BeginInit();
            this.tbpTg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxTg)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrbxMain
            // 
            this.pctrbxMain.Location = new System.Drawing.Point(16, 12);
            this.pctrbxMain.Name = "pctrbxMain";
            this.pctrbxMain.Size = new System.Drawing.Size(286, 268);
            this.pctrbxMain.TabIndex = 0;
            this.pctrbxMain.TabStop = false;
            // 
            // txtbAngle
            // 
            this.txtbAngle.Location = new System.Drawing.Point(331, 12);
            this.txtbAngle.Name = "txtbAngle";
            this.txtbAngle.Size = new System.Drawing.Size(100, 22);
            this.txtbAngle.TabIndex = 1;
            this.txtbAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbAngle_KeyPress);
            // 
            // rdbRadian
            // 
            this.rdbRadian.AutoSize = true;
            this.rdbRadian.Location = new System.Drawing.Point(331, 40);
            this.rdbRadian.Name = "rdbRadian";
            this.rdbRadian.Size = new System.Drawing.Size(80, 20);
            this.rdbRadian.TabIndex = 2;
            this.rdbRadian.Text = "Radians";
            this.rdbRadian.UseVisualStyleBackColor = true;
            // 
            // rdbAngle
            // 
            this.rdbAngle.AutoSize = true;
            this.rdbAngle.Checked = true;
            this.rdbAngle.Location = new System.Drawing.Point(331, 72);
            this.rdbAngle.Name = "rdbAngle";
            this.rdbAngle.Size = new System.Drawing.Size(82, 20);
            this.rdbAngle.TabIndex = 3;
            this.rdbAngle.TabStop = true;
            this.rdbAngle.Text = "Degrees";
            this.rdbAngle.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(331, 98);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 46);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(504, 18);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(15, 16);
            this.lblAngle.TabIndex = 5;
            this.lblAngle.Text = "0";
            // 
            // tbpTrig
            // 
            this.tbpTrig.Controls.Add(this.tbpSin);
            this.tbpTrig.Controls.Add(this.tbpCos);
            this.tbpTrig.Controls.Add(this.tbpCtg);
            this.tbpTrig.Controls.Add(this.tbpTg);
            this.tbpTrig.Location = new System.Drawing.Point(12, 286);
            this.tbpTrig.Name = "tbpTrig";
            this.tbpTrig.SelectedIndex = 0;
            this.tbpTrig.Size = new System.Drawing.Size(783, 258);
            this.tbpTrig.TabIndex = 6;
            // 
            // tbpSin
            // 
            this.tbpSin.Controls.Add(this.pctrbxSin);
            this.tbpSin.Location = new System.Drawing.Point(4, 25);
            this.tbpSin.Name = "tbpSin";
            this.tbpSin.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSin.Size = new System.Drawing.Size(775, 229);
            this.tbpSin.TabIndex = 0;
            this.tbpSin.Text = "Sin";
            this.tbpSin.UseVisualStyleBackColor = true;
            // 
            // pctrbxSin
            // 
            this.pctrbxSin.Location = new System.Drawing.Point(3, 3);
            this.pctrbxSin.Name = "pctrbxSin";
            this.pctrbxSin.Size = new System.Drawing.Size(778, 223);
            this.pctrbxSin.TabIndex = 0;
            this.pctrbxSin.TabStop = false;
            // 
            // tbpCos
            // 
            this.tbpCos.Controls.Add(this.pctrbxCos);
            this.tbpCos.Location = new System.Drawing.Point(4, 25);
            this.tbpCos.Name = "tbpCos";
            this.tbpCos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCos.Size = new System.Drawing.Size(775, 229);
            this.tbpCos.TabIndex = 1;
            this.tbpCos.Text = "Cos";
            this.tbpCos.UseVisualStyleBackColor = true;
            // 
            // pctrbxCos
            // 
            this.pctrbxCos.Location = new System.Drawing.Point(3, 3);
            this.pctrbxCos.Name = "pctrbxCos";
            this.pctrbxCos.Size = new System.Drawing.Size(778, 223);
            this.pctrbxCos.TabIndex = 0;
            this.pctrbxCos.TabStop = false;
            // 
            // tbpCtg
            // 
            this.tbpCtg.Controls.Add(this.pctrbxCtg);
            this.tbpCtg.Location = new System.Drawing.Point(4, 25);
            this.tbpCtg.Name = "tbpCtg";
            this.tbpCtg.Size = new System.Drawing.Size(775, 229);
            this.tbpCtg.TabIndex = 2;
            this.tbpCtg.Text = "Ctg";
            this.tbpCtg.UseVisualStyleBackColor = true;
            // 
            // pctrbxCtg
            // 
            this.pctrbxCtg.Location = new System.Drawing.Point(3, 3);
            this.pctrbxCtg.Name = "pctrbxCtg";
            this.pctrbxCtg.Size = new System.Drawing.Size(778, 223);
            this.pctrbxCtg.TabIndex = 0;
            this.pctrbxCtg.TabStop = false;
            // 
            // tbpTg
            // 
            this.tbpTg.Controls.Add(this.pctrbxTg);
            this.tbpTg.Location = new System.Drawing.Point(4, 25);
            this.tbpTg.Name = "tbpTg";
            this.tbpTg.Size = new System.Drawing.Size(775, 229);
            this.tbpTg.TabIndex = 3;
            this.tbpTg.Text = "Tg";
            this.tbpTg.UseVisualStyleBackColor = true;
            // 
            // pctrbxTg
            // 
            this.pctrbxTg.Location = new System.Drawing.Point(3, 3);
            this.pctrbxTg.Name = "pctrbxTg";
            this.pctrbxTg.Size = new System.Drawing.Size(778, 223);
            this.pctrbxTg.TabIndex = 0;
            this.pctrbxTg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ctg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 581);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbpTrig);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rdbAngle);
            this.Controls.Add(this.rdbRadian);
            this.Controls.Add(this.txtbAngle);
            this.Controls.Add(this.pctrbxMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxMain)).EndInit();
            this.tbpTrig.ResumeLayout(false);
            this.tbpSin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSin)).EndInit();
            this.tbpCos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxCos)).EndInit();
            this.tbpCtg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxCtg)).EndInit();
            this.tbpTg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxTg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbxMain;
        private System.Windows.Forms.TextBox txtbAngle;
        private System.Windows.Forms.RadioButton rdbRadian;
        private System.Windows.Forms.RadioButton rdbAngle;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.TabControl tbpTrig;
        private System.Windows.Forms.TabPage tbpSin;
        private System.Windows.Forms.TabPage tbpCos;
        private System.Windows.Forms.TabPage tbpCtg;
        private System.Windows.Forms.TabPage tbpTg;
        private System.Windows.Forms.PictureBox pctrbxSin;
        private System.Windows.Forms.PictureBox pctrbxCos;
        private System.Windows.Forms.PictureBox pctrbxCtg;
        private System.Windows.Forms.PictureBox pctrbxTg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

