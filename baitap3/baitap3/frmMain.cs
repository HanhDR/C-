using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ho ten: "+txtht.Text + "\nTuoi: " + txtt.Text, "Thong Bao");
        }

        private void but2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtt_Leave(object sender, EventArgs e)
        {
            if (txtht.Text != "" && txtt.Text != "")
                but1.Enabled = true;
        }
    }
}
