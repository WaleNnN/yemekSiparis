namespace YSBitirmeProjesi
{
    partial class kullanicisiparisSyf
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanicisiparisSyf));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.kulSiparisÜrünaditxt = new System.Windows.Forms.TextBox();
            this.kulsiparisSepeteEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdiSoyadi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 153);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Canım ne çekiyor?";
            // 
            // kulSiparisÜrünaditxt
            // 
            this.kulSiparisÜrünaditxt.Location = new System.Drawing.Point(129, 21);
            this.kulSiparisÜrünaditxt.Name = "kulSiparisÜrünaditxt";
            this.kulSiparisÜrünaditxt.Size = new System.Drawing.Size(100, 20);
            this.kulSiparisÜrünaditxt.TabIndex = 2;
            this.kulSiparisÜrünaditxt.TextChanged += new System.EventHandler(this.kulSiparisÜrünaditxt_TextChanged);
            // 
            // kulsiparisSepeteEkle
            // 
            this.kulsiparisSepeteEkle.Location = new System.Drawing.Point(32, 259);
            this.kulsiparisSepeteEkle.Name = "kulsiparisSepeteEkle";
            this.kulsiparisSepeteEkle.Size = new System.Drawing.Size(91, 41);
            this.kulsiparisSepeteEkle.TabIndex = 3;
            this.kulsiparisSepeteEkle.Text = "Sepete Ekle";
            this.kulsiparisSepeteEkle.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "purchase.png");
            this.ımageList1.Images.SetKeyName(1, "user (2).png");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sipariş Geçmişi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ImageKey = "purchase.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(309, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 54);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTL.Location = new System.Drawing.Point(323, 46);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(13, 13);
            this.lblTL.TabIndex = 17;
            this.lblTL.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "TL:";
            // 
            // lblAdiSoyadi
            // 
            this.lblAdiSoyadi.AutoSize = true;
            this.lblAdiSoyadi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAdiSoyadi.Location = new System.Drawing.Point(359, 21);
            this.lblAdiSoyadi.Name = "lblAdiSoyadi";
            this.lblAdiSoyadi.Size = new System.Drawing.Size(35, 13);
            this.lblAdiSoyadi.TabIndex = 19;
            this.lblAdiSoyadi.Text = "label8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adı Soyadı:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tatlı",
            "Meyve",
            "Sebze"});
            this.comboBox1.Location = new System.Drawing.Point(144, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kullanicisiparisSyf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 390);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblAdiSoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kulsiparisSepeteEkle);
            this.Controls.Add(this.kulSiparisÜrünaditxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kullanicisiparisSyf";
            this.Text = "kullanicisiparisSyf";
            this.Load += new System.EventHandler(this.kullanicisiparisSyf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kulSiparisÜrünaditxt;
        private System.Windows.Forms.Button kulsiparisSepeteEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblAdiSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}