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
    public partial class FormC : Form
    {
        public FormC()
        {
            InitializeComponent();
            Lock_Unlock(Mysave.KT);
        }

        void Lock_Unlock(bool kt)
        {
            mnuLogin.Enabled = mnuClose.Enabled = kt;
            mnuFind.Enabled = mnuLogout.Enabled = mnuWork.Enabled = !kt;
        }

        private void workToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            Formcon1 f = new Formcon1();
            f.Show();
        }

        private void FormC_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(Mysave.KT);
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            Mysave.KT = !Mysave.KT;
            Lock_Unlock(Mysave.KT);
        }
    }
}
