﻿namespace YSBitirmeProjesi
{
    partial class kayitolsyf
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tcNotxtbox = new System.Windows.Forms.TextBox();
            this.adisoyaditxt = new System.Windows.Forms.TextBox();
            this.kullaniciaditxt = new System.Windows.Forms.TextBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.adrestxt = new System.Windows.Forms.TextBox();
            this.telefontxt = new System.Windows.Forms.TextBox();
            this.kayitOlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon:";
            // 
            // tcNotxtbox
            // 
            this.tcNotxtbox.Location = new System.Drawing.Point(134, 37);
            this.tcNotxtbox.Name = "tcNotxtbox";
            this.tcNotxtbox.Size = new System.Drawing.Size(100, 20);
            this.tcNotxtbox.TabIndex = 6;
            // 
            // adisoyaditxt
            // 
            this.adisoyaditxt.Location = new System.Drawing.Point(134, 83);
            this.adisoyaditxt.Name = "adisoyaditxt";
            this.adisoyaditxt.Size = new System.Drawing.Size(100, 20);
            this.adisoyaditxt.TabIndex = 7;
            // 
            // kullaniciaditxt
            // 
            this.kullaniciaditxt.Location = new System.Drawing.Point(134, 128);
            this.kullaniciaditxt.Name = "kullaniciaditxt";
            this.kullaniciaditxt.Size = new System.Drawing.Size(100, 20);
            this.kullaniciaditxt.TabIndex = 8;
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(134, 179);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(100, 20);
            this.sifretxt.TabIndex = 9;
            // 
            // adrestxt
            // 
            this.adrestxt.Location = new System.Drawing.Point(134, 226);
            this.adrestxt.Name = "adrestxt";
            this.adrestxt.Size = new System.Drawing.Size(100, 20);
            this.adrestxt.TabIndex = 10;
            // 
            // telefontxt
            // 
            this.telefontxt.Location = new System.Drawing.Point(134, 269);
            this.telefontxt.Name = "telefontxt";
            this.telefontxt.Size = new System.Drawing.Size(100, 20);
            this.telefontxt.TabIndex = 11;
            // 
            // kayitOlBtn
            // 
            this.kayitOlBtn.Location = new System.Drawing.Point(134, 324);
            this.kayitOlBtn.Name = "kayitOlBtn";
            this.kayitOlBtn.Size = new System.Drawing.Size(75, 23);
            this.kayitOlBtn.TabIndex = 12;
            this.kayitOlBtn.Text = "Kayıt Ol";
            this.kayitOlBtn.UseVisualStyleBackColor = true;
            this.kayitOlBtn.Click += new System.EventHandler(this.kayitOlBtn_Click);
            // 
            // kayitolsyf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 400);
            this.Controls.Add(this.kayitOlBtn);
            this.Controls.Add(this.telefontxt);
            this.Controls.Add(this.adrestxt);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kullaniciaditxt);
            this.Controls.Add(this.adisoyaditxt);
            this.Controls.Add(this.tcNotxtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kayitolsyf";
            this.Text = "kayitolsyf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tcNotxtbox;
        private System.Windows.Forms.TextBox adisoyaditxt;
        private System.Windows.Forms.TextBox kullaniciaditxt;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.TextBox adrestxt;
        private System.Windows.Forms.TextBox telefontxt;
        private System.Windows.Forms.Button kayitOlBtn;
    }
}