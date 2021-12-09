
namespace AdamAsmaca
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
            this.buttonSec = new System.Windows.Forms.Button();
            this.labelSec = new System.Windows.Forms.Label();
            this.labelYildiz = new System.Windows.Forms.Label();
            this.textBoxHarf = new System.Windows.Forms.TextBox();
            this.buttonTahmin = new System.Windows.Forms.Button();
            this.labelKalanHak = new System.Windows.Forms.Label();
            this.pictureBoxAdam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdam)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSec
            // 
            this.buttonSec.Location = new System.Drawing.Point(296, 12);
            this.buttonSec.Name = "buttonSec";
            this.buttonSec.Size = new System.Drawing.Size(75, 23);
            this.buttonSec.TabIndex = 0;
            this.buttonSec.Text = "Kelime Seç";
            this.buttonSec.UseVisualStyleBackColor = true;
            this.buttonSec.Click += new System.EventHandler(this.buttonSec_Click);
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec.Location = new System.Drawing.Point(89, 68);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(102, 55);
            this.labelSec.TabIndex = 1;
            this.labelSec.Text = "......";
            // 
            // labelYildiz
            // 
            this.labelYildiz.AutoSize = true;
            this.labelYildiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYildiz.Location = new System.Drawing.Point(89, 159);
            this.labelYildiz.Name = "labelYildiz";
            this.labelYildiz.Size = new System.Drawing.Size(102, 55);
            this.labelYildiz.TabIndex = 2;
            this.labelYildiz.Text = "......";
            // 
            // textBoxHarf
            // 
            this.textBoxHarf.Location = new System.Drawing.Point(296, 55);
            this.textBoxHarf.MaxLength = 1;
            this.textBoxHarf.Name = "textBoxHarf";
            this.textBoxHarf.Size = new System.Drawing.Size(100, 20);
            this.textBoxHarf.TabIndex = 3;
            // 
            // buttonTahmin
            // 
            this.buttonTahmin.Location = new System.Drawing.Point(403, 53);
            this.buttonTahmin.Name = "buttonTahmin";
            this.buttonTahmin.Size = new System.Drawing.Size(75, 23);
            this.buttonTahmin.TabIndex = 4;
            this.buttonTahmin.Text = "Tahmin Et";
            this.buttonTahmin.UseVisualStyleBackColor = true;
            this.buttonTahmin.Click += new System.EventHandler(this.buttonTahmin_Click);
            // 
            // labelKalanHak
            // 
            this.labelKalanHak.AutoSize = true;
            this.labelKalanHak.Location = new System.Drawing.Point(590, 21);
            this.labelKalanHak.Name = "labelKalanHak";
            this.labelKalanHak.Size = new System.Drawing.Size(35, 13);
            this.labelKalanHak.TabIndex = 5;
            this.labelKalanHak.Text = "label1";
            // 
            // pictureBoxAdam
            // 
            this.pictureBoxAdam.Location = new System.Drawing.Point(403, 124);
            this.pictureBoxAdam.Name = "pictureBoxAdam";
            this.pictureBoxAdam.Size = new System.Drawing.Size(188, 155);
            this.pictureBoxAdam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAdam.TabIndex = 6;
            this.pictureBoxAdam.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 326);
            this.Controls.Add(this.pictureBoxAdam);
            this.Controls.Add(this.labelKalanHak);
            this.Controls.Add(this.buttonTahmin);
            this.Controls.Add(this.textBoxHarf);
            this.Controls.Add(this.labelYildiz);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.buttonSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSec;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label labelYildiz;
        private System.Windows.Forms.TextBox textBoxHarf;
        private System.Windows.Forms.Button buttonTahmin;
        private System.Windows.Forms.Label labelKalanHak;
        private System.Windows.Forms.PictureBox pictureBoxAdam;
    }
}

