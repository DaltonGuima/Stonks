using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stonks
{
    public partial class frmInvestimentos : Form
    {
        public frmInvestimentos()
        {
            InitializeComponent();
        }

        private void pcbSetat_MouseHover(object sender, EventArgs e)
        {
            pcbSetat.Visible = false;
            pcbSetac.Visible = true;
        }

        private void pcbSetac_MouseLeave(object sender, EventArgs e)
        {
            pcbSetat.Visible = true;
            pcbSetac.Visible = false;
        }

        private void pcbSetac_Click(object sender, EventArgs e)
        {
            panIntro.Visible = false;              
                Investimentos i = new Investimentos();
                i.Show();
                this.Hide();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            frmTrue s = new frmTrue();
            s.Show();
        }

      
    }

}
