namespace YSBitirmeProjesi
{
    partial class SepetGörüntülemeSyf
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
            this.label1 = new System.Windows.Forms.Label();
            this.sptGrntleÖdemeYap = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEPETİM";
            // 
            // sptGrntleÖdemeYap
            // 
            this.sptGrntleÖdemeYap.Location = new System.Drawing.Point(38, 248);
            this.sptGrntleÖdemeYap.Name = "sptGrntleÖdemeYap";
            this.sptGrntleÖdemeYap.Size = new System.Drawing.Size(88, 35);
            this.sptGrntleÖdemeYap.TabIndex = 2;
            this.sptGrntleÖdemeYap.Text = "Ödeme Yap";
            this.sptGrntleÖdemeYap.UseVisualStyleBackColor = true;
            this.sptGrntleÖdemeYap.Click += new System.EventHandler(this.sptGrntleÖdemeYap_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 160);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(180, 61);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(50, 160);
            this.listBox2.TabIndex = 3;
            // 
            // SepetGörüntülemeSyf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 318);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.sptGrntleÖdemeYap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "SepetGörüntülemeSyf";
            this.Text = "SepetGörüntülemeSyf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sptGrntleÖdemeYap;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ListBox listBox2;
    }
}