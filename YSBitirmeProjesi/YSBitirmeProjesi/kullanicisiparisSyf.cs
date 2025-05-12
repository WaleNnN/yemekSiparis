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
        public kullanicisiparisSyf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SepetGörüntülemeSyf sepetGörüntülemeSyf = new SepetGörüntülemeSyf();
            {
                sepetGörüntülemeSyf.Show();
            }
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
    }
}
