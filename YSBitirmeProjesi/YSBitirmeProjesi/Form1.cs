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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisYapbtn_Click(object sender, EventArgs e)
        {
            adminSyf adminSyf = new adminSyf();
            int kuladi = Convert.ToInt32(kuladitxtbox.Text);
            int sifre = Convert.ToInt32(sifretxtbox.Text);
            if(kuladi ==0 && sifre == 0)
            {
                adminSyf.Show();
            }
        }

        private void kayıtOlLabel_Click(object sender, EventArgs e)
        {
            kayitolsyf kayitolsyf = new kayitolsyf();
            kayitolsyf.Show(); 
        }
    }
}
