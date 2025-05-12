using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YSBitirmeProjesi
{
    public partial class ÜrünİşlemleriSyf : Form
    {
        public ÜrünİşlemleriSyf()
        {
            InitializeComponent();
        }

        private void ÜrünİslmÜrünEkle_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            string sorgu = $"INSERT INTO yemekler (YemekTuru, YemekAdi, Stok, TL) " +
                   $"VALUES ('{ÜrünİslmÜrünTürütxt.Text}', '{ÜrünİslmÜrünAditxt.Text}', '{ÜrünİslmÜrünStoktxt.Text}', '{ÜrünİslmÜrünFiyatitxt.Text}')";
            MySqlCommand komut = new MySqlCommand(sorgu, connect);
            komut.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Ürün başarı ile eklendi");
            string komut2 = "select * from yemekler";
            connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(komut2, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();

        }

        private void ÜrünİşlemleriSyf_Load(object sender, EventArgs e)
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

        private void ÜrünİslmÜrünBilgileriGüncelle_Click(object sender, EventArgs e)
        {
            
             MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
                connect.Open();
                MySqlCommand komut = new MySqlCommand("Update yemekler set YemekTuru='" + ÜrünİslmÜrünTürütxt.Text + "',Stok='" + ÜrünİslmÜrünStoktxt.Text + "',TL='" + ÜrünİslmÜrünFiyatitxt.Text + "' where YemekAdi='" + ÜrünİslmÜrünAditxt.Text + "'", connect);
                komut.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Güncelleme Başarılı");
                string komut2 = "select * from yemekler";
                connect.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(komut2, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connect.Close(); 
          
                   

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                ÜrünİslmÜrünTürütxt.Text = selectedRow.Cells["YemekTuru"].Value.ToString();
                ÜrünİslmÜrünAditxt.Text = selectedRow.Cells["YemekAdi"].Value.ToString();
                ÜrünİslmÜrünStoktxt.Text = selectedRow.Cells["Stok"].Value.ToString();
                ÜrünİslmÜrünFiyatitxt.Text = selectedRow.Cells["TL"].Value.ToString();
               
            }
        }

        private void ÜrünİslmÜrünSil_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            MySqlCommand komut = new MySqlCommand($"delete from yemekler where YemekAdi='{ÜrünİslmÜrünAditxt.Text}'", connect);
            komut.ExecuteNonQuery();
            connect.Close();
            string komut2 = "select * from yemekler";
            connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(komut2, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
    }
}
