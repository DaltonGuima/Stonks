namespace Stonks
{
    partial class frmInvestimentos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvestimentos));
            this.panIntro = new System.Windows.Forms.Panel();
            this.pcbSetac = new System.Windows.Forms.PictureBox();
            this.pcbSetat = new System.Windows.Forms.PictureBox();
            this.lblSiga = new System.Windows.Forms.Label();
            this.lblInto = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panIntro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSetac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSetat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panIntro
            // 
            this.panIntro.Controls.Add(this.pcbSetac);
            this.panIntro.Controls.Add(this.pcbSetat);
            this.panIntro.Controls.Add(this.lblSiga);
            this.panIntro.Controls.Add(this.lblInto);
            resources.ApplyResources(this.panIntro, "panIntro");
            this.panIntro.Name = "panIntro";
            // 
            // pcbSetac
            // 
            this.pcbSetac.BackgroundImage = global::Stonks.Properties.Resources.Setac;
            resources.ApplyResources(this.pcbSetac, "pcbSetac");
            this.pcbSetac.Name = "pcbSetac";
            this.pcbSetac.TabStop = false;
            this.pcbSetac.Click += new System.EventHandler(this.pcbSetac_Click);
            this.pcbSetac.MouseLeave += new System.EventHandler(this.pcbSetac_MouseLeave);
            // 
            // pcbSetat
            // 
            this.pcbSetat.BackgroundImage = global::Stonks.Properties.Resources.setaT;
            resources.ApplyResources(this.pcbSetat, "pcbSetat");
            this.pcbSetat.Name = "pcbSetat";
            this.pcbSetat.TabStop = false;
            this.pcbSetat.MouseHover += new System.EventHandler(this.pcbSetat_MouseHover);
            // 
            // lblSiga
            // 
            resources.ApplyResources(this.lblSiga, "lblSiga");
            this.lblSiga.Name = "lblSiga";
            // 
            // lblInto
            // 
            resources.ApplyResources(this.lblInto, "lblInto");
            this.lblInto.Name = "lblInto";
            // 
            // imgLogo
            // 
            resources.ApplyResources(this.imgLogo, "imgLogo");
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // frmInvestimentos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panIntro);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmInvestimentos";
            this.panIntro.ResumeLayout(false);
            this.panIntro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSetac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSetat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel panIntro;
        private System.Windows.Forms.Label lblInto;
        private System.Windows.Forms.Label lblSiga;
        private System.Windows.Forms.PictureBox pcbSetac;
        private System.Windows.Forms.PictureBox pcbSetat;
    }
}

