namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban Vua Chon " + comboBox1.Text);
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text =hScrollBar1.Value.ToString();
            this.label1.Font = new System.Drawing.Font("Segoe UI", hScrollBar1.Value, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string font = cboxfont.Text.ToString();
            float size = float.Parse(cmboxsize.Text);
            
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int t = int.Parse(labgiay.Text);
            int phut=int.Parse(lbphut.Text);
            int gio = int.Parse(labgio.Text);
            t++;
            if (t == 59)
            {
                t=0;
                phut++;
            }
            if (phut == 59)
            {
                phut = 0;
                gio++;
            }
            if (gio == 23)
            {
                gio = 0;
               
            }
           labgiay.Text = t.ToString();
           labgio.Text = gio.ToString();
           lbphut.Text= phut.ToString();
        }

        private void butstop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            butstart.Enabled = true;
            butstop.Enabled = false;
        }

        private void butstart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            butstart.Enabled = false;
            butstop.Enabled = true;
            
        }

        private void lblKQ_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int giay=int.Parse(labden.Text);
            giay--;
            if (pictureBox1.BackColor == Color.Lime)
            {
                if (giay == 0)
                {
                    giay = 10;
                    pictureBox1.BackColor = Color.Orange;
                }
            }
            if(pictureBox1.BackColor == Color.Orange)
            {
                if (giay == 0)
                {
                    giay = 20;
                    pictureBox1.BackColor = Color.Red;
                               
                }
            }
            if (pictureBox1.BackColor == Color.Red)
            {
                if (giay == 0)
                {
                    giay = 30;
                    pictureBox1.BackColor= Color.Lime;
                }
            }
                labden.Text = giay.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
        }
    }
}