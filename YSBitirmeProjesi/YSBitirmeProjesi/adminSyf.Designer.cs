namespace YSBitirmeProjesi
{
    partial class adminSyf
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
            this.üyeİşlemleribtn = new System.Windows.Forms.Button();
            this.ürünİslemleriSyf = new System.Windows.Forms.Button();
            this.puanİslemleriSyf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // üyeİşlemleribtn
            // 
            this.üyeİşlemleribtn.Location = new System.Drawing.Point(34, 35);
            this.üyeİşlemleribtn.Name = "üyeİşlemleribtn";
            this.üyeİşlemleribtn.Size = new System.Drawing.Size(84, 31);
            this.üyeİşlemleribtn.TabIndex = 0;
            this.üyeİşlemleribtn.Text = "Üye İşlemleri";
            this.üyeİşlemleribtn.UseVisualStyleBackColor = true;
            this.üyeİşlemleribtn.Click += new System.EventHandler(this.üyeİşlemleribtn_Click);
            // 
            // ürünİslemleriSyf
            // 
            this.ürünİslemleriSyf.Location = new System.Drawing.Point(34, 96);
            this.ürünİslemleriSyf.Name = "ürünİslemleriSyf";
            this.ürünİslemleriSyf.Size = new System.Drawing.Size(84, 31);
            this.ürünİslemleriSyf.TabIndex = 1;
            this.ürünİslemleriSyf.Text = "Ürün İşlemleri";
            this.ürünİslemleriSyf.UseVisualStyleBackColor = true;
            this.ürünİslemleriSyf.Click += new System.EventHandler(this.ürünİslemleriSyf_Click);
            // 
            // puanİslemleriSyf
            // 
            this.puanİslemleriSyf.Location = new System.Drawing.Point(34, 160);
            this.puanİslemleriSyf.Name = "puanİslemleriSyf";
            this.puanİslemleriSyf.Size = new System.Drawing.Size(84, 31);
            this.puanİslemleriSyf.TabIndex = 2;
            this.puanİslemleriSyf.Text = "TL İşlemleri";
            this.puanİslemleriSyf.UseVisualStyleBackColor = true;
            this.puanİslemleriSyf.Click += new System.EventHandler(this.puanİslemleriSyf_Click);
            // 
            // adminSyf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 257);
            this.Controls.Add(this.puanİslemleriSyf);
            this.Controls.Add(this.ürünİslemleriSyf);
            this.Controls.Add(this.üyeİşlemleribtn);
            this.Name = "adminSyf";
            this.Text = "adminSyf";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button üyeİşlemleribtn;
        private System.Windows.Forms.Button ürünİslemleriSyf;
        private System.Windows.Forms.Button puanİslemleriSyf;
    }
}