using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapcongtru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {
            int so1=int.Parse(txt1.Text);
            int so2=int.Parse(txt2.Text);
            int kq=so1-so2;
            txt3.Text = kq.ToString();
        }

        private void but2_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txt1.Text);
            int so2 = int.Parse(txt2.Text);
            int kq = so1 + so2;
            txt3.Text = kq.ToString();

        }

        private void but3_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txt1.Text);
            int so2 = int.Parse(txt2.Text);
            int kq = so1 * so2;
            txt3.Text = kq.ToString();
        }

        private void but4_Click(object sender, EventArgs e)
        {
            float so1 = float.Parse(txt1.Text);
            float so2 = float.Parse(txt2.Text);
            if (so2 == 0)
            {
                MessageBox.Show("Nhap so khac 0 nha be");
            }
            else
            {
                
                    float kq = so1 / so2;
                    txt3.Text = kq.ToString();
                
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
        }
    }
}
