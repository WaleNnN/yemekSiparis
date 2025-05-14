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

    public partial class siparisGecmisi : Form
    {
        string tc;
      //  kullanicisiparisSyf tc=new kullanicisiparisSyf();
        public siparisGecmisi(string f)
        {
            InitializeComponent();
            tc= f;
        }

        private void siparisGecmisi_Load(object sender, EventArgs e)
        {

            int tccik = Convert.ToInt32(tc);
           
            MySqlConnection connect = new MySqlConnection("Server='localhost';Database='yemek';Uid='root';Pwd='233789975668mM_'");
            string komut = $"select * from siparisler where TcNo= {tccik} ";
            connect.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
    }
}