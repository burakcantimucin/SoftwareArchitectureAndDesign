namespace Odev3
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
            this.btnBasitPencere = new System.Windows.Forms.Button();
            this.btnKenarOlustur = new System.Windows.Forms.Button();
            this.btnGolgeOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBasitPencere
            // 
            this.btnBasitPencere.Location = new System.Drawing.Point(53, 58);
            this.btnBasitPencere.Name = "btnBasitPencere";
            this.btnBasitPencere.Size = new System.Drawing.Size(173, 23);
            this.btnBasitPencere.TabIndex = 0;
            this.btnBasitPencere.Text = "Basit Pencere Oluştur";
            this.btnBasitPencere.UseVisualStyleBackColor = true;
            this.btnBasitPencere.Click += new System.EventHandler(this.btnBasitPencere_Click);
            // 
            // btnKenarOlustur
            // 
            this.btnKenarOlustur.Location = new System.Drawing.Point(53, 108);
            this.btnKenarOlustur.Name = "btnKenarOlustur";
            this.btnKenarOlustur.Size = new System.Drawing.Size(173, 23);
            this.btnKenarOlustur.TabIndex = 0;
            this.btnKenarOlustur.Text = "Pencerenin Kenarını Oluştur";
            this.btnKenarOlustur.UseVisualStyleBackColor = true;
            this.btnKenarOlustur.Click += new System.EventHandler(this.btnKenarOlustur_Click);
            // 
            // btnGolgeOlustur
            // 
            this.btnGolgeOlustur.Location = new System.Drawing.Point(53, 160);
            this.btnGolgeOlustur.Name = "btnGolgeOlustur";
            this.btnGolgeOlustur.Size = new System.Drawing.Size(173, 23);
            this.btnGolgeOlustur.TabIndex = 0;
            this.btnGolgeOlustur.Text = "Pencerenin Gölgesini Oluştur";
            this.btnGolgeOlustur.UseVisualStyleBackColor = true;
            this.btnGolgeOlustur.Click += new System.EventHandler(this.btnGolgeOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGolgeOlustur);
            this.Controls.Add(this.btnKenarOlustur);
            this.Controls.Add(this.btnBasitPencere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBasitPencere;
        private System.Windows.Forms.Button btnKenarOlustur;
        private System.Windows.Forms.Button btnGolgeOlustur;
    }
}

