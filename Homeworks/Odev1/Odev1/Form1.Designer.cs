namespace Odev1
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
            this.btnTestEt = new System.Windows.Forms.Button();
            this.btnVideoyuBaslat = new System.Windows.Forms.Button();
            this.btnVideoyuDurdur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestEt
            // 
            this.btnTestEt.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTestEt.Location = new System.Drawing.Point(48, 38);
            this.btnTestEt.Name = "btnTestEt";
            this.btnTestEt.Size = new System.Drawing.Size(175, 47);
            this.btnTestEt.TabIndex = 0;
            this.btnTestEt.Text = "Test Et";
            this.btnTestEt.UseVisualStyleBackColor = true;
            this.btnTestEt.Click += new System.EventHandler(this.btnTestEt_Click);
            // 
            // btnVideoyuBaslat
            // 
            this.btnVideoyuBaslat.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVideoyuBaslat.Location = new System.Drawing.Point(48, 104);
            this.btnVideoyuBaslat.Name = "btnVideoyuBaslat";
            this.btnVideoyuBaslat.Size = new System.Drawing.Size(175, 47);
            this.btnVideoyuBaslat.TabIndex = 0;
            this.btnVideoyuBaslat.Text = "Videoyu Başlat";
            this.btnVideoyuBaslat.UseVisualStyleBackColor = true;
            this.btnVideoyuBaslat.Click += new System.EventHandler(this.btnVideoyuBaslat_Click);
            // 
            // btnVideoyuDurdur
            // 
            this.btnVideoyuDurdur.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVideoyuDurdur.Location = new System.Drawing.Point(48, 171);
            this.btnVideoyuDurdur.Name = "btnVideoyuDurdur";
            this.btnVideoyuDurdur.Size = new System.Drawing.Size(175, 47);
            this.btnVideoyuDurdur.TabIndex = 0;
            this.btnVideoyuDurdur.Text = "Videoyu Durdur";
            this.btnVideoyuDurdur.UseVisualStyleBackColor = true;
            this.btnVideoyuDurdur.Click += new System.EventHandler(this.btnVideoyuDurdur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnVideoyuDurdur);
            this.Controls.Add(this.btnVideoyuBaslat);
            this.Controls.Add(this.btnTestEt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestEt;
        private System.Windows.Forms.Button btnVideoyuBaslat;
        private System.Windows.Forms.Button btnVideoyuDurdur;
    }
}

