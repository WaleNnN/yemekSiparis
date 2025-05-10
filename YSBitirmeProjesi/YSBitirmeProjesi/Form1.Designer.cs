namespace YSBitirmeProjesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kuladitxtbox = new System.Windows.Forms.TextBox();
            this.sifretxtbox = new System.Windows.Forms.TextBox();
            this.girisYapbtn = new System.Windows.Forms.Button();
            this.kayıtOlLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kuladitxtbox
            // 
            this.kuladitxtbox.Location = new System.Drawing.Point(138, 75);
            this.kuladitxtbox.Name = "kuladitxtbox";
            this.kuladitxtbox.Size = new System.Drawing.Size(100, 20);
            this.kuladitxtbox.TabIndex = 0;
            // 
            // sifretxtbox
            // 
            this.sifretxtbox.Location = new System.Drawing.Point(138, 119);
            this.sifretxtbox.Name = "sifretxtbox";
            this.sifretxtbox.Size = new System.Drawing.Size(100, 20);
            this.sifretxtbox.TabIndex = 1;
            // 
            // girisYapbtn
            // 
            this.girisYapbtn.Location = new System.Drawing.Point(138, 165);
            this.girisYapbtn.Name = "girisYapbtn";
            this.girisYapbtn.Size = new System.Drawing.Size(75, 23);
            this.girisYapbtn.TabIndex = 2;
            this.girisYapbtn.Text = "Giriş Yap";
            this.girisYapbtn.UseVisualStyleBackColor = true;
            this.girisYapbtn.Click += new System.EventHandler(this.girisYapbtn_Click);
            // 
            // kayıtOlLabel
            // 
            this.kayıtOlLabel.AutoSize = true;
            this.kayıtOlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtOlLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.kayıtOlLabel.Location = new System.Drawing.Point(135, 209);
            this.kayıtOlLabel.Name = "kayıtOlLabel";
            this.kayıtOlLabel.Size = new System.Drawing.Size(135, 13);
            this.kayıtOlLabel.TabIndex = 3;
            this.kayıtOlLabel.Text = "Hesabınız yoksa Kayıt Olun";
            this.kayıtOlLabel.Click += new System.EventHandler(this.kayıtOlLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kayıtOlLabel);
            this.Controls.Add(this.girisYapbtn);
            this.Controls.Add(this.sifretxtbox);
            this.Controls.Add(this.kuladitxtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kuladitxtbox;
        private System.Windows.Forms.TextBox sifretxtbox;
        private System.Windows.Forms.Button girisYapbtn;
        private System.Windows.Forms.Label kayıtOlLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

