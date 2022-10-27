using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butn1_Click(object sender, EventArgs e)
        {
            double d=double.Parse(txtdai.Text);
            double r = double.Parse(txtrong.Text);
            HCN hcn = new HCN(d,r);
            MessageBox.Show(hcn.dienTich().ToString(), "Dien Tich La");

        }

        private void butn2_Click(object sender, EventArgs e)
        {
            double d = double.Parse(txtdai.Text);
            double r = double.Parse(txtrong.Text);
            HCN hcn = new HCN(d, r);
            MessageBox.Show(hcn.chuvi().ToString(), "Chu vi la");
        }

        private void butclick_Click(object sender, EventArgs e)
        {
            Deptrai<String> a = new Deptrai<string>("Qua dep trai");
            MessageBox.Show(a.get(),"dep trai qua");
        }

        private void butok_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) labtien.Text = "30000";
            else if (radioButton2.Checked == true) labtien.Text = "40000";
            if (radioButton3.Checked==true) labtien.Text = "50000";
        }

        private  void labtien_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string s = "Ban da chon: ";
            if (checkBox1.Checked) s += checkBox1.Text + ", ";
            else s.Replace(checkBox1.Text, "");
            if (checkBox2.Checked) s += checkBox2.Text + ", ";
            else s.Replace(checkBox2.Text, "");
            if (checkBox3.Checked) s += checkBox3.Text;
            else s.Replace(checkBox3.Text, "");
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
                testcheck.Text = s;
            else testcheck.Text = "Bạn chưa chọn gì cả!!!";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labtien.Text = listBox1.SelectedItem + " has " +
            listBox1.SelectedItem.ToString().Length.ToString() + " letters.";
        }
    }
}
