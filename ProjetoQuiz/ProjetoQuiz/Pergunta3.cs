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
    public partial class Pergunta3 : Form
    {
        public Pergunta3()
        {
            InitializeComponent();
        }

        Respostas resp = new Respostas();
        Pergunta4 p4 = new Pergunta4();

        private void Proximo()
        {
            p4.Show();
            Close();
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

        private void btn1_MouseHover(object sender, EventArgs e)
        {
            btn1.BackgroundImage = Properties.Resources.Amarelo;
            lbl1.BackColor = Color.Gold;
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btn1.BackgroundImage = Properties.Resources.RadioButton;
            lbl1.BackColor = Color.White;
        }

        private void btn2_MouseHover(object sender, EventArgs e)
        {
            btn2.BackgroundImage = Properties.Resources.Amarelo;
            lbl2.BackColor = Color.Gold;
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            btn2.BackgroundImage = Properties.Resources.RadioButton;
            lbl2.BackColor = Color.White;
        }

        private void btn3_MouseHover(object sender, EventArgs e)
        {
            btn3.BackgroundImage = Properties.Resources.Amarelo;
            lbl3.BackColor = Color.Gold;
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            btn3.BackgroundImage = Properties.Resources.RadioButton;
            lbl3.BackColor = Color.White;
        }

        private void btn4_MouseHover(object sender, EventArgs e)
        {
            btn4.BackgroundImage = Properties.Resources.Amarelo;
            lbl4.BackColor = Color.Gold;
        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            btn4.BackgroundImage = Properties.Resources.RadioButton;
            lbl4.BackColor = Color.White;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            resp.Reposta(0);
            Proximo();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            resp.Reposta(0);
            Proximo();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            resp.Reposta(0);
            Proximo();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            resp.Reposta(1);
            Proximo();
        }
    }
}
