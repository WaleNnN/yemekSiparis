using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YSBitirmeProjesi
{
    public partial class kullanicisiparisSyf : Form
    {
        SepetGörüntülemeSyf sepetForm = new SepetGörüntülemeSyf();
        public kullanicisiparisSyf()
        {
            InitializeComponent();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void kullanicisiparisSyf_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
            string komut = "select * from yemekler";
            connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void kulSiparisÜrünaditxt_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from yemekler where YemekAdi like '%" + kulSiparisÜrünaditxt.Text + "%'", connect);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenTur = comboBox1.SelectedItem.ToString();

            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM yemekler WHERE YemekTuru='" + secilenTur + "'", connect);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
            string komut = "select * from yemekler";
            connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void kulsiparisSepeteEkle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtYemekSayisi.Text, out int adet))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
            }
            else if (dataGridView1.SelectedRows.Count > 0)
            {
                string secilenYemek = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); // YemekAdi
                string secilenFiyat = dataGridView1.SelectedRows[0].Cells[3].Value.ToString(); // TL

                listBox1.Items.Add(secilenYemek);
                listBox2.Items.Add(adet.ToString());
                listBox3.Items.Add(secilenFiyat + " TL");
            }
            else
            {
                MessageBox.Show("Lütfen sepete eklenecek bir yemek seçin.");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplam = 0;

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                int adet = Convert.ToInt32(listBox2.Items[i]); // listBox2: adet
                string fiyatStr = listBox3.Items[i].ToString().Replace(" TL", ""); // listBox3: fiyat (örn: 20 TL)
                double fiyat = Convert.ToDouble(fiyatStr);
                toplam += adet * fiyat;
            }

            odenecekTutartxt.Text = toplam.ToString();



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void odemeYapbtn_Click(object sender, EventArgs e)
        {
            double odenecektutar = Convert.ToDouble(odenecekTutartxt.Text);
            double tL = Convert.ToDouble(lblTL.Text);

            if (odenecektutar <= tL)
            {
                double yeniTL = tL - odenecektutar;
                lblTL.Text = yeniTL.ToString();

                MessageBox.Show("Ödeme başarılı!");

                // Veritabanı güncelleme
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=yemek;Uid=root;Pwd=233789975668mM_;"))
                {
                    conn.Open();

                    // Giriş yapan kullanıcının adıyla güncelle (örneğin lblKullaniciAd.Text kullanıcı adını tutuyor olsun)
                    string kullaniciAdi = lblAdiSoyadi.Text;
                    string sql = $"UPDATE uyeler SET TL = '{lblTL.Text}' WHERE AdiSoyadi = '{kullaniciAdi}'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Yetersiz bakiye.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Seçili indexi kontrol et
            int seciliIndex = listBox1.SelectedIndex;

            if (seciliIndex >= 0 && seciliIndex < listBox1.Items.Count &&
                seciliIndex < listBox2.Items.Count && seciliIndex < listBox3.Items.Count)
            {
                listBox1.Items.RemoveAt(seciliIndex);
                listBox2.Items.RemoveAt(seciliIndex);
                listBox3.Items.RemoveAt(seciliIndex);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir öğe seçin.");
            }
        }
    }
}
