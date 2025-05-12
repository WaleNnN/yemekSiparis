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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YSBitirmeProjesi
{
    public partial class PuanİşlemleriSyf : Form
    {
        public PuanİşlemleriSyf()
        {
            InitializeComponent();
        }

        private void PuanİşlemleriSyf_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
            connect.Open();
            MySqlCommand komut = new MySqlCommand("SELECT TcNo, AdiSoyadi, TL FROM uyeler", connect);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void tlİslemtlYüklebtn_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
            connect.Open();         
            MySqlCommand komut = new MySqlCommand("UPDATE uyeler SET TL = TL + " + tlİslmTLtxt.Text + " WHERE TcNo='" + tlİslmTcNotxt.Text + "'", connect);
            komut.ExecuteNonQuery();
            MySqlCommand komut2 = new MySqlCommand("SELECT TcNo, AdiSoyadi, TL FROM uyeler", connect);
            MySqlDataAdapter da = new MySqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            connect.Close();
            MessageBox.Show("TL başarıyla güncellendi.");





        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                tlİslmTcNotxt.Text = selectedRow.Cells["TcNo"].Value.ToString();
                tlİslmTLtxt.Text = selectedRow.Cells["TL"].Value.ToString();
                
                

            }
        }
    }
}
