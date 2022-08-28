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
    public partial class cdb : Form
    {
        decimal taxa = 0.12m;
        double  c,t,i;
        public cdb()
        {
            InitializeComponent();
        }

        private void txtInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            } 
        }

        private void txtInv_TextChanged(object sender, EventArgs e)
        {
            if (txtInv.Text == ",")
            {
                MessageBox.Show("não pode iniciar o numéro com ( , )", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txtInv.Focus();
                 txtInv.Text = "0";
            }

            else if (txtInv.Text != "0" && txtInv.Text != "" && txtAno.Text != 0.ToString() && txtAno.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtAno.Text = 0.ToString();
            txtInv.Text = 0.ToString();
            c = 0;
            t = 0;
            taxa = 0.12m;

            panCalculo.Visible = false;
        }

        private void cdb_Load(object sender, EventArgs e)
        {
            btnLimpar.PerformClick();
        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {
            if (txtInv.Text != "0" && txtInv.Text != "" && txtAno.Text != 0.ToString() && txtAno.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtTaxa_TextChanged(object sender, EventArgs e)
        {
            if (txtTaxa.Text == ",")
            {
                MessageBox.Show("não pode iniciar o número com ( , )", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                taxa = Convert.ToDecimal(txtTaxa.Text);
            }
        }

        private void txtTaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void cdb_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            Investimentos i = new Investimentos();
            i.Show();
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            c = Convert.ToDouble(txtInv.Text);
            t = Convert.ToDouble(txtAno.Text);
            i = Convert.ToDouble(taxa);
            lblConta.Text = "Depois de " + txtAno.Text + " ano(s), você terá:";

           
            txtTotal.Text = (c * Math.Pow(1 + i, t)).ToString("C");
            
        
            panCalculo.Visible = true;
        }
    }
}
