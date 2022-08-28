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
    public partial class poupanca : Form
    {
        decimal selic = 5.5m, t1;
        double C, i;
        int t;
        public poupanca()
        {
            InitializeComponent();
        }

        private void poupanca_Load(object sender, EventArgs e)
        {
            
            btnLimpar.PerformClick();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTempo.Text = "0";
            txtDinheiro.Text = 0.ToString();
            selic = 5.5m;
            panCalculo.Visible = false;

        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            Investimentos i = new Investimentos();
            i.Show();
            this.Close();
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            if (txtDinheiro.Text == ",")
            {
                MessageBox.Show("não pode iniciar o número com (,)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDinheiro.Focus();
                txtDinheiro.Text = 0.ToString();
            }

            else if (txtDinheiro.Text != "" && txtDinheiro.Text != 0.ToString() && txtTempo.Text != "" && txtTempo.Text != 0.ToString())
            { 
                    btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }

        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
        {
            if (txtTempo.Text == ",")
            {
                MessageBox.Show("não pode iniciar o número com ( , )", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTempo.Focus();
                txtTempo.Text = "0";
            }
            else if (txtDinheiro.Text != "" && txtDinheiro.Text != 0.ToString() && txtTempo.Text != "" && txtTempo.Text != 0.ToString())
            {             
                    btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

        private void txtSelic_TextChanged(object sender, EventArgs e)
        {
            if (txtSelic.Text != "")
            {
                if (txtSelic.Text == ",")
                {
                    MessageBox.Show("não pode iniciar o número com ( , )", "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    selic = Convert.ToDecimal(txtSelic.Text);
                }
            }
            
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void poupanca_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSelic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //t1;
            lblConta.Text = "Depois de " + txtTempo.Text + " ano(s), você terá:";
            panCalculo.Visible = true;
            if (selic > 8.5m)
            {
                t1 = (0.05m * selic) / 100;
                C = Convert.ToDouble(txtDinheiro.Text);
                i = Convert.ToDouble(t1);
                t = Convert.ToInt32(txtTempo.Text);

                txtTotal.Text = (C * (Math.Pow(1 + i, t))).ToString("C");
            }
            else
            {
                t1 = (0.7m * selic) / 100;
                
                C = Convert.ToDouble(txtDinheiro.Text);
                i = Convert.ToDouble(t1);
                t = Convert.ToInt32(txtTempo.Text);

                txtTotal.Text = (C * (Math.Pow(1 + i,t))).ToString("C");
            }
            
        }
    }
}
