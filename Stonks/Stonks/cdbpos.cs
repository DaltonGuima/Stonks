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
    public partial class cdbpos : Form
    {
        public cdbpos()
        {
            InitializeComponent();
        }
        double taxa;
        private void txtInv_TextChanged(object sender, EventArgs e)
        {
            if (txtInv.Text == ",")
            {
                MessageBox.Show("não pode iniciar o número com ( , )", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInv.Focus();
                txtInv.Text = "0";
            }

            else if (txtInv.Text != "0" && txtInv.Text != "" && txtAno.Text != 0.ToString() && txtAno.Text != "" && txtCDI.Text != "" && txtCDI.Text != "0" && txtPorc.Text != "" && txtPorc.Text != "0")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtCDI_TextChanged(object sender, EventArgs e)
        {
            if (txtCDI.Text == ",")
            {
                MessageBox.Show("não pode iniciar o número com ( , )", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCDI.Focus();
                txtCDI.Text = "0";
            }
             else if (txtInv.Text != "0" && txtInv.Text != "" && txtAno.Text != 0.ToString() && txtAno.Text != "" && txtCDI.Text != "" && txtCDI.Text != "0" && txtPorc.Text != "" && txtPorc.Text != "0")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtPorc_TextChanged(object sender, EventArgs e)
        {
            if (txtPorc.Text == ",")
            {
                MessageBox.Show("não pode iniciar o número com ( , )", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPorc.Focus();
                txtPorc.Text = "0";
            }

            else if (txtInv.Text != "0" && txtInv.Text != "" && txtAno.Text != 0.ToString() && txtAno.Text != "" && txtCDI.Text != "" && txtCDI.Text != "0" && txtPorc.Text != "" && txtPorc.Text != "0")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {
            if (txtInv.Text != "0" && txtInv.Text != "" && txtAno.Text != 0.ToString() && txtAno.Text != "" && txtCDI.Text != "" && txtCDI.Text != "0" && txtPorc.Text != "" && txtPorc.Text != "0")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            Investimentos i = new Investimentos();
            i.Show();
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            taxa = Convert.ToDouble(txtCDI.Text);
            double c = Convert.ToDouble(txtInv.Text);
            double t = Convert.ToDouble(txtAno.Text);
            double porc = Convert.ToDouble(txtPorc.Text);

            porc = porc / 100;
            taxa = taxa / 100;
 
                lblConta.Text = "Depois de " + txtAno.Text + " ano(s), você terá:";

                txtTotal.Text = ((Math.Pow(taxa*porc, t) * c)).ToString("C");
                panCalculo.Visible = true;
       
        }

        private void txtInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtCDI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtPorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAno.Text = 0.ToString();
            txtPorc.Text = 0.ToString();
            txtCDI.Text = 0.ToString();
            txtInv.Text = 0.ToString();
            panCalculo.Visible = false;
        }

        private void cdbpos_Load(object sender, EventArgs e)
        {
            btnLimpar.PerformClick();
        }

        private void cdbpos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
