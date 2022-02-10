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
    public partial class Investimentos : Form
    {
        public Investimentos()
        {
            InitializeComponent();
        }

        private void btnPoupanca_MouseHover(object sender, EventArgs e)
        {
            btnPoupanca.BackColor = Color.SteelBlue;
            btnCbd.BackColor = Color.DeepSkyBlue;
            btnRenda.BackColor = Color.DeepSkyBlue;

            panPoupanca.Visible = true;
            panCbd.Visible = false;
            panel1.Visible = false;

            cbxCbd.SelectedItem = " ";
        }

        private void btnTesouro_MouseHover(object sender, EventArgs e)
        {
            btnCbd.BackColor = Color.SteelBlue;
            btnPoupanca.BackColor = Color.DeepSkyBlue;
            btnRenda.BackColor = Color.DeepSkyBlue;

            panCbd.Visible = true;
            panPoupanca.Visible = false;
            panel1.Visible = false;

        }

        private void btnRenda_MouseHover(object sender, EventArgs e)
        {
            btnRenda.BackColor = Color.SteelBlue;
            btnPoupanca.BackColor = Color.DeepSkyBlue;
            btnCbd.BackColor = Color.DeepSkyBlue;

            panel1.Visible = true;
            panPoupanca.Visible = false;
            panCbd.Visible = false;

            cbxCbd.SelectedItem = " ";
        }

        private void btnSimule_Click(object sender, EventArgs e)
        {
            poupanca p = new poupanca();
            p.Show();
            this.Close();
        }

        private void btmSimulador_Click(object sender, EventArgs e)
        {
            cdb c = new cdb();
            c.Show();
            this.Close();
        }


        private void btnCdiSim_Click(object sender, EventArgs e)
        {
            cdi cd = new cdi();
            cd.Show();
            this.Close();
        }

        private void btnCdbPos_Click_1(object sender, EventArgs e)
        {
            cdbpos ced = new cdbpos();
            ced.Show();
            this.Close();
        }

        private void cbxCbd_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxCbd.SelectedItem)
            {
                case " " :
                    BtnS.Enabled = false;
                    lblDesc2.Visible = true;
                    lblCdbF.Visible = false;
                    lblCdbp.Visible = false;
                    break;
                case "CDB pré-fixado"  :
                    BtnS.Enabled = true;
                    lblCdbF.Visible = true;
                    lblDesc2.Visible = false;
                    lblCdbp.Visible = false;
                    break;
                case "CDB pós-fixado" :
                    BtnS.Enabled = true;
                    lblCdbp.Visible = true;
                    lblDesc2.Visible = false;
                    lblCdbF.Visible = false;
                    break;
            }
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            switch (cbxCbd.SelectedItem)
            {
                case "CDB pré-fixado":
                    cdb c = new cdb();
                    c.Show();
                    this.Close();
                    break;
                case "CDB pós-fixado":
                    cdbpos ced = new cdbpos();
                    ced.Show();
                    this.Close();
                    break;
            }
        }

        
    }
}
