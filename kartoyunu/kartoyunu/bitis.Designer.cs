
namespace kartoyunu
{
    partial class bitis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bitis));
            this.baslik_lbl = new System.Windows.Forms.Label();
            this.isim_lbl = new System.Windows.Forms.Label();
            this.puan_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sure_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baslik_lbl
            // 
            this.baslik_lbl.BackColor = System.Drawing.Color.Transparent;
            this.baslik_lbl.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.baslik_lbl.Location = new System.Drawing.Point(12, 19);
            this.baslik_lbl.Name = "baslik_lbl";
            this.baslik_lbl.Size = new System.Drawing.Size(256, 40);
            this.baslik_lbl.TabIndex = 0;
            this.baslik_lbl.Text = "OYUN BİTTİ";
            this.baslik_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.baslik_lbl.Click += new System.EventHandler(this.baslik_lbl_Click);
            // 
            // isim_lbl
            // 
            this.isim_lbl.BackColor = System.Drawing.Color.Transparent;
            this.isim_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.isim_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.isim_lbl.Location = new System.Drawing.Point(12, 68);
            this.isim_lbl.Name = "isim_lbl";
            this.isim_lbl.Size = new System.Drawing.Size(256, 40);
            this.isim_lbl.TabIndex = 1;
            this.isim_lbl.Text = "İSİM";
            this.isim_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // puan_lbl
            // 
            this.puan_lbl.BackColor = System.Drawing.Color.Transparent;
            this.puan_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.puan_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.puan_lbl.Location = new System.Drawing.Point(12, 108);
            this.puan_lbl.Name = "puan_lbl";
            this.puan_lbl.Size = new System.Drawing.Size(256, 40);
            this.puan_lbl.TabIndex = 2;
            this.puan_lbl.Text = "PUAN";
            this.puan_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(18, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "YENİDEN OYNA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(18, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "MENÜYE DÖN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sure_lbl
            // 
            this.sure_lbl.BackColor = System.Drawing.Color.Transparent;
            this.sure_lbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.sure_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.sure_lbl.Location = new System.Drawing.Point(12, 148);
            this.sure_lbl.Name = "sure_lbl";
            this.sure_lbl.Size = new System.Drawing.Size(256, 40);
            this.sure_lbl.TabIndex = 5;
            this.sure_lbl.Text = "PUAN";
            this.sure_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bitis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(280, 320);
            this.Controls.Add(this.sure_lbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.puan_lbl);
            this.Controls.Add(this.isim_lbl);
            this.Controls.Add(this.baslik_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bitis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bitis";
            this.Load += new System.EventHandler(this.bitis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label baslik_lbl;
        private System.Windows.Forms.Label isim_lbl;
        private System.Windows.Forms.Label puan_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label sure_lbl;
    }
}