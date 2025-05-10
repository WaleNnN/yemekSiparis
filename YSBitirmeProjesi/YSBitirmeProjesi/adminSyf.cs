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
    public partial class adminSyf : Form
    {
        public adminSyf()
        {
            InitializeComponent();
        }

        private void üyeİşlemleribtn_Click(object sender, EventArgs e)
        {
            üyeİşlemleriSyf üyeİşlemleriSyf = new üyeİşlemleriSyf();
            üyeİşlemleriSyf.Show();
        }

        private void ürünİslemleriSyf_Click(object sender, EventArgs e)
        {
            ÜrünİşlemleriSyf ürünİşlemleri = new ÜrünİşlemleriSyf();
            {
                ürünİşlemleri.Show();
            }
        }

        private void puanİslemleriSyf_Click(object sender, EventArgs e)
        {
            PuanİşlemleriSyf puanİşlemleriSyf = new PuanİşlemleriSyf();
            {
                puanİşlemleriSyf.Show();
            }
        }
    }
}
