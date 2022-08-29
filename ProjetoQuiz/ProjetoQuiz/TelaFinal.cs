using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoQuiz
{
    public partial class TelaFinal : Form
    {
        public TelaFinal()
        {
            InitializeComponent();
        }

        private void TelaFinal_Load(object sender, EventArgs e)
        {
            lblAcertos.Text = Respostas.getAcertos().ToString();
            lblErros.Text = Respostas.getErros().ToString();
            if ((Respostas.getAcertos() >= 0) && (Respostas.getAcertos() <= 2))
            {
                lblMs.Text = "Você errou muitas.";
            }
            if ((Respostas.getAcertos() >= 3) && (Respostas.getAcertos() <= 4))
            {
                lblMs.Text = "Acertou muitas, Parabéns!";
            }
            if (Respostas.getAcertos() == 5)
            {
                lblMs.Text = "Acertou tudo Parabéns!";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                frmTelaIni.ReleaseCapture();
                frmTelaIni.SendMessage(Handle, frmTelaIni.WM_NCLBUTTONDOWN, frmTelaIni.HT_CAPTION, 0);
            }
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
