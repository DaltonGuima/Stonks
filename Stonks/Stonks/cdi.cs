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
    public partial class cdi : Form
    {
        public cdi()
        {
            InitializeComponent();
        }

        private void txtInv_TextChanged(object sender, EventArgs e)
        {
            if (txtInv.Text == ",")
            {
                MessageBox.Show("não pode iniciar o número com ( , )", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInv.Focus();
                txtInv.Text = "0";
            }

            else if (txtInv.Text != "0" && txtInv.Text != "" && txtCdi.Text != 0.ToString() && txtCdi.Text != "" && txtLci.Text != "" && txtLci.Text != 0.ToString())
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
            if (txtInv.Text == ",")
            {
                MessageBox.Show("não pode iniciar o número com (,)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInv.Focus();
                txtInv.Text = "0";
            }

            else if (txtInv.Text != "0" && txtInv.Text != "" && txtCdi.Text != 0.ToString() && txtCdi.Text != "" && txtLci.Text != "" && txtLci.Text != 0.ToString())
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtInv.Text == ",")
            {
                MessageBox.Show("não pode iniciar o número com (,)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInv.Focus();
                txtInv.Text = "0";
            }

            else if (txtInv.Text != "0" && txtInv.Text != "" && txtCdi.Text != 0.ToString() && txtCdi.Text != "" && txtLci.Text != "" && txtLci.Text != 0.ToString())
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtLci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtCdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblConta.Text = "Depois 1 ano, você terá:";

            txtTotal.Text = (Convert.ToDecimal(txtInv.Text) * ((0.01m * Convert.ToDecimal(txtCdi.Text)) * (0.01m * Convert.ToDecimal(txtLci.Text)))).ToString("C");
            panCalculo.Visible = true;
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            Investimentos i = new Investimentos();
            i.Show();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLci.Text = 0.ToString();
            txtCdi.Text = 0.ToString();
            txtInv.Text = 0.ToString();
            panCalculo.Visible = false;
        }

        private void cdi_Load(object sender, EventArgs e)
        {
            btnLimpar.PerformClick();
        }

        private void cdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
