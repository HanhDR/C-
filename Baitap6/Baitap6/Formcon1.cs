using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap6
{
    public partial class Formcon1 : Form
    {
        public Formcon1()
        {
            InitializeComponent();
        }

        private void Formcon1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUS.Text == "abc" && txtPW.Text == "123")
            {
                Mysave.KT = !Mysave.KT;
                MessageBox.Show("Login thanh cong", "Attention");
                Close();
            }
            else MessageBox.Show("Nhap sai kia thang oc cho", "Attention");
        }
    }
}
