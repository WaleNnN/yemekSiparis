using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace YSBitirmeProjesi
{
    public partial class kayitolsyf : Form
    {
        public kayitolsyf()
        {
            InitializeComponent();
        }

        private void kayitOlBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            string sorgu = $"INSERT INTO Uyeler (TcNo, AdiSoyadi, KullaniciAdi, Sifre, Adres, Telefon) " +
                   $"VALUES ('{tcNotxtbox.Text}', '{adisoyaditxt.Text}', '{kullaniciaditxt.Text}', '{sifretxt.Text}', '{adrestxt.Text}', '{telefontxt.Text}')";
            MySqlCommand komut = new MySqlCommand(sorgu, connect);
            komut.ExecuteNonQuery();
            string sorgu2 = "INSERT INTO siparisler (TcNo) " +
                $"VALUES ('{tcNotxtbox.Text}')";
            MySqlCommand komut2 = new MySqlCommand(sorgu2, connect);
            komut2.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Üye başarı ile eklendi");

        }
    }
}
