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
    public partial class üyeİşlemleriSyf : Form
    {
        public üyeİşlemleriSyf()
        {
            InitializeComponent();
        }

        private void üyeİşlemleriSyf_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
            string komut = "select * from Uyeler";
            connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void üyeİslmGüncelleBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            MySqlCommand komut = new MySqlCommand(
            "UPDATE uyeler SET " +
            "AdiSoyadi='" + üyeİslmAdiSoyaditxt.Text + "', " +
            "KullaniciAdi='" + üyeİslmKuladitxt.Text + "', " +
            "Sifre='" + üyeİslemSifretxt.Text + "', " +
            "Adres='" + üyeİslmAdrestxt.Text + "', " +
            "Telefon='" + üyeİslmTelefontxt.Text + "' " +
            "WHERE TcNo='" + üyeİslemTcNotxt.Text + "'", connect);

            komut.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Güncelleme Başarılı");
            string komut2 = "select * from uyeler";
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
                üyeİslemTcNotxt.Text = selectedRow.Cells["TcNo"].Value.ToString();
                üyeİslmAdiSoyaditxt.Text = selectedRow.Cells["AdiSoyadi"].Value.ToString();
                üyeİslmKuladitxt.Text = selectedRow.Cells["KullaniciAdi"].Value.ToString();
                üyeİslemSifretxt.Text = selectedRow.Cells["Sifre"].Value.ToString();
                üyeİslmAdrestxt.Text = selectedRow.Cells["Adres"].Value.ToString();
                üyeİslmTelefontxt.Text = selectedRow.Cells["Telefon"].Value.ToString();
               
            }
        }

        private void üyeİslmSilBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            MySqlCommand komut = new MySqlCommand($"delete from uyeler where TcNo='{üyeİslemTcNotxt.Text}'", connect);
            komut.ExecuteNonQuery();
            connect.Close();
            string komut2 = "select * from uyeler";
            connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(komut2, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
            MessageBox.Show("Üye başarı ile silindi");
        }
    }
}
