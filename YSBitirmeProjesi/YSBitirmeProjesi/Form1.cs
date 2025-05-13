using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YSBitirmeProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void girisYapbtn_Click(object sender, EventArgs e)
        {



            string connectionString = "Server=localhost;Database=yemek;Uid=root;Pwd=233789975668mM_";
            MySqlConnection connect = new MySqlConnection(connectionString);
            string sorgu = $"SELECT TcNo,AdiSoyadi, Adres, Telefon, TL FROM Uyeler WHERE KullaniciAdi = '{kuladitxtbox.Text}' AND Sifre = '{sifretxtbox.Text}'";

            MySqlCommand komut = new MySqlCommand(sorgu, connect);

            connect.Open();
            MySqlDataReader reader = komut.ExecuteReader();

            if (reader.Read())
            {

                kullanicisiparisSyf kul = new kullanicisiparisSyf();
                string adiSoyadi = reader["AdiSoyadi"].ToString();
                string tL = reader["TL"].ToString();
                string visibleTc = reader["TcNo"].ToString();
                kul.lblAdiSoyadi.Text = adiSoyadi;
                kul.lblTL.Text = tL;
                kul.visibleofftc.Text = visibleTc;
                kul.ShowDialog();




            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.");
            }

            reader.Close();
            connect.Close();

        }

        private void kayıtOlLabel_Click(object sender, EventArgs e)
        {
            kayitolsyf kayitolsyf = new kayitolsyf();
            kayitolsyf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kuladi = Convert.ToInt32(kuladitxtbox.Text);
                int sifre = Convert.ToInt32(sifretxtbox.Text);
                if (kuladi == 1 && sifre == 1)
                {
                    adminSyf admin = new adminSyf();
                    admin.Show();
                }
            }
            catch
            {
                MessageBox.Show("Lütfen alanı boş bırakmayınız");
            }
        }
    }
}