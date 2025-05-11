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
    }
}
