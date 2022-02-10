namespace Stonks
{
    partial class Investimentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Investimentos));
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.btnRenda = new System.Windows.Forms.Button();
            this.btnPoupanca = new System.Windows.Forms.Button();
            this.btnCbd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCdiSim = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCdi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panCbd = new System.Windows.Forms.Panel();
            this.BtnS = new System.Windows.Forms.Button();
            this.cbxCbd = new System.Windows.Forms.ComboBox();
            this.pcbSetal = new System.Windows.Forms.PictureBox();
            this.lblCdb = new System.Windows.Forms.Label();
            this.lblInto2 = new System.Windows.Forms.Label();
            this.lblCdbF = new System.Windows.Forms.Label();
            this.lblCdbp = new System.Windows.Forms.Label();
            this.lblDesc2 = new System.Windows.Forms.Label();
            this.panPoupanca = new System.Windows.Forms.Panel();
            this.btnSimule = new System.Windows.Forms.Button();
            this.pcbIndicacao = new System.Windows.Forms.PictureBox();
            this.lblChama = new System.Windows.Forms.Label();
            this.lblExpli = new System.Windows.Forms.Label();
            this.lblEx = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panCbd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSetal)).BeginInit();
            this.panPoupanca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndicacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panPrincipal
            // 
            this.panPrincipal.Controls.Add(this.btnRenda);
            this.panPrincipal.Controls.Add(this.btnPoupanca);
            this.panPrincipal.Controls.Add(this.btnCbd);
            this.panPrincipal.Controls.Add(this.panel1);
            this.panPrincipal.Controls.Add(this.panCbd);
            this.panPrincipal.Controls.Add(this.panPoupanca);
            this.panPrincipal.Location = new System.Drawing.Point(0, 121);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(389, 195);
            this.panPrincipal.TabIndex = 1;
            // 
            // btnRenda
            // 
            this.btnRenda.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRenda.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRenda.FlatAppearance.BorderSize = 0;
            this.btnRenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRenda.Location = new System.Drawing.Point(244, 3);
            this.btnRenda.Name = "btnRenda";
            this.btnRenda.Size = new System.Drawing.Size(142, 23);
            this.btnRenda.TabIndex = 3;
            this.btnRenda.Text = "CDI";
            this.btnRenda.UseVisualStyleBackColor = false;
            this.btnRenda.MouseHover += new System.EventHandler(this.btnRenda_MouseHover);
            // 
            // btnPoupanca
            // 
            this.btnPoupanca.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPoupanca.FlatAppearance.BorderSize = 0;
            this.btnPoupanca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoupanca.Location = new System.Drawing.Point(3, 3);
            this.btnPoupanca.Name = "btnPoupanca";
            this.btnPoupanca.Size = new System.Drawing.Size(131, 23);
            this.btnPoupanca.TabIndex = 1;
            this.btnPoupanca.Text = "Poupança";
            this.btnPoupanca.UseVisualStyleBackColor = false;
            this.btnPoupanca.MouseHover += new System.EventHandler(this.btnPoupanca_MouseHover);
            // 
            // btnCbd
            // 
            this.btnCbd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCbd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCbd.FlatAppearance.BorderSize = 0;
            this.btnCbd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCbd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCbd.Location = new System.Drawing.Point(133, 3);
            this.btnCbd.Name = "btnCbd";
            this.btnCbd.Size = new System.Drawing.Size(113, 23);
            this.btnCbd.TabIndex = 2;
            this.btnCbd.Text = "CBD";
            this.btnCbd.UseVisualStyleBackColor = false;
            this.btnCbd.MouseHover += new System.EventHandler(this.btnTesouro_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnCdiSim);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCdi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 169);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // btnCdiSim
            // 
            this.btnCdiSim.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCdiSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCdiSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCdiSim.Location = new System.Drawing.Point(272, 120);
            this.btnCdiSim.Name = "btnCdiSim";
            this.btnCdiSim.Size = new System.Drawing.Size(75, 23);
            this.btnCdiSim.TabIndex = 3;
            this.btnCdiSim.Text = "Simulador";
            this.btnCdiSim.UseVisualStyleBackColor = false;
            this.btnCdiSim.Click += new System.EventHandler(this.btnCdiSim_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Stonks.Properties.Resources.Setac1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(201, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 32);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neste simulador será usado o\r\n CDI Pré-fixado.\r\n";
            // 
            // lblCdi
            // 
            this.lblCdi.AutoSize = true;
            this.lblCdi.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCdi.Location = new System.Drawing.Point(8, 26);
            this.lblCdi.Name = "lblCdi";
            this.lblCdi.Size = new System.Drawing.Size(341, 80);
            this.lblCdi.TabIndex = 1;
            this.lblCdi.Text = resources.GetString("lblCdi.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "O que é?";
            // 
            // panCbd
            // 
            this.panCbd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panCbd.Controls.Add(this.BtnS);
            this.panCbd.Controls.Add(this.cbxCbd);
            this.panCbd.Controls.Add(this.pcbSetal);
            this.panCbd.Controls.Add(this.lblCdb);
            this.panCbd.Controls.Add(this.lblInto2);
            this.panCbd.Controls.Add(this.lblCdbF);
            this.panCbd.Controls.Add(this.lblCdbp);
            this.panCbd.Controls.Add(this.lblDesc2);
            this.panCbd.Location = new System.Drawing.Point(0, 26);
            this.panCbd.Name = "panCbd";
            this.panCbd.Size = new System.Drawing.Size(392, 169);
            this.panCbd.TabIndex = 2;
            this.panCbd.Visible = false;
            // 
            // BtnS
            // 
            this.BtnS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnS.Enabled = false;
            this.BtnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnS.Location = new System.Drawing.Point(272, 120);
            this.BtnS.Name = "BtnS";
            this.BtnS.Size = new System.Drawing.Size(75, 23);
            this.BtnS.TabIndex = 4;
            this.BtnS.Text = "Simulador";
            this.BtnS.UseVisualStyleBackColor = false;
            this.BtnS.Click += new System.EventHandler(this.BtnS_Click);
            // 
            // cbxCbd
            // 
            this.cbxCbd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbxCbd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCbd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCbd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxCbd.FormattingEnabled = true;
            this.cbxCbd.Items.AddRange(new object[] {
            " ",
            "CDB pré-fixado",
            "CDB pós-fixado"});
            this.cbxCbd.Location = new System.Drawing.Point(12, 120);
            this.cbxCbd.Name = "cbxCbd";
            this.cbxCbd.Size = new System.Drawing.Size(121, 21);
            this.cbxCbd.TabIndex = 3;
            this.cbxCbd.SelectedIndexChanged += new System.EventHandler(this.cbxCbd_SelectedIndexChanged);
            // 
            // pcbSetal
            // 
            this.pcbSetal.BackgroundImage = global::Stonks.Properties.Resources.Setac1;
            this.pcbSetal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbSetal.Location = new System.Drawing.Point(201, 115);
            this.pcbSetal.Name = "pcbSetal";
            this.pcbSetal.Size = new System.Drawing.Size(65, 32);
            this.pcbSetal.TabIndex = 2;
            this.pcbSetal.TabStop = false;
            // 
            // lblCdb
            // 
            this.lblCdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCdb.Location = new System.Drawing.Point(9, 100);
            this.lblCdb.Name = "lblCdb";
            this.lblCdb.Size = new System.Drawing.Size(183, 23);
            this.lblCdb.TabIndex = 0;
            this.lblCdb.Text = "Selecione qual tipo de CDB\r\n";
            // 
            // lblInto2
            // 
            this.lblInto2.AutoSize = true;
            this.lblInto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInto2.Location = new System.Drawing.Point(2, 6);
            this.lblInto2.Name = "lblInto2";
            this.lblInto2.Size = new System.Drawing.Size(74, 20);
            this.lblInto2.TabIndex = 0;
            this.lblInto2.Text = "O que é?";
            // 
            // lblCdbF
            // 
            this.lblCdbF.AutoSize = true;
            this.lblCdbF.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCdbF.Location = new System.Drawing.Point(10, 26);
            this.lblCdbF.Name = "lblCdbF";
            this.lblCdbF.Size = new System.Drawing.Size(382, 48);
            this.lblCdbF.TabIndex = 5;
            this.lblCdbF.Text = resources.GetString("lblCdbF.Text");
            this.lblCdbF.Visible = false;
            // 
            // lblCdbp
            // 
            this.lblCdbp.AutoSize = true;
            this.lblCdbp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCdbp.Location = new System.Drawing.Point(9, 26);
            this.lblCdbp.Name = "lblCdbp";
            this.lblCdbp.Size = new System.Drawing.Size(363, 64);
            this.lblCdbp.TabIndex = 6;
            this.lblCdbp.Text = resources.GetString("lblCdbp.Text");
            this.lblCdbp.Visible = false;
            // 
            // lblDesc2
            // 
            this.lblDesc2.AutoSize = true;
            this.lblDesc2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc2.Location = new System.Drawing.Point(8, 29);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(372, 60);
            this.lblDesc2.TabIndex = 1;
            this.lblDesc2.Text = "Investimento de renda fixa que você empresta o seu dinheiro para \r\numa instituiçã" +
    "o bancária e em troca,você recebe uma taxa de \r\nrentabilidade que é definida no " +
    "momento da compra.";
            // 
            // panPoupanca
            // 
            this.panPoupanca.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panPoupanca.Controls.Add(this.btnSimule);
            this.panPoupanca.Controls.Add(this.pcbIndicacao);
            this.panPoupanca.Controls.Add(this.lblChama);
            this.panPoupanca.Controls.Add(this.lblExpli);
            this.panPoupanca.Controls.Add(this.lblEx);
            this.panPoupanca.Location = new System.Drawing.Point(0, 26);
            this.panPoupanca.Name = "panPoupanca";
            this.panPoupanca.Size = new System.Drawing.Size(389, 169);
            this.panPoupanca.TabIndex = 2;
            // 
            // btnSimule
            // 
            this.btnSimule.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSimule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimule.Location = new System.Drawing.Point(272, 120);
            this.btnSimule.Name = "btnSimule";
            this.btnSimule.Size = new System.Drawing.Size(75, 23);
            this.btnSimule.TabIndex = 4;
            this.btnSimule.Text = "Simulador";
            this.btnSimule.UseVisualStyleBackColor = false;
            this.btnSimule.Click += new System.EventHandler(this.btnSimule_Click);
            // 
            // pcbIndicacao
            // 
            this.pcbIndicacao.BackgroundImage = global::Stonks.Properties.Resources.Setac1;
            this.pcbIndicacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbIndicacao.Location = new System.Drawing.Point(201, 115);
            this.pcbIndicacao.Name = "pcbIndicacao";
            this.pcbIndicacao.Size = new System.Drawing.Size(65, 32);
            this.pcbIndicacao.TabIndex = 3;
            this.pcbIndicacao.TabStop = false;
            // 
            // lblChama
            // 
            this.lblChama.AutoSize = true;
            this.lblChama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChama.Location = new System.Drawing.Point(4, 120);
            this.lblChama.Name = "lblChama";
            this.lblChama.Size = new System.Drawing.Size(165, 26);
            this.lblChama.TabIndex = 2;
            this.lblChama.Text = "Venha usar nosso simulador\r\nClicando onde é indicado\r\n";
            // 
            // lblExpli
            // 
            this.lblExpli.AutoSize = true;
            this.lblExpli.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpli.Location = new System.Drawing.Point(8, 29);
            this.lblExpli.Name = "lblExpli";
            this.lblExpli.Size = new System.Drawing.Size(369, 80);
            this.lblExpli.TabIndex = 1;
            this.lblExpli.Text = resources.GetString("lblExpli.Text");
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEx.Location = new System.Drawing.Point(2, 6);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(74, 20);
            this.lblEx.TabIndex = 0;
            this.lblEx.Text = "O que é?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(73, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Investimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 315);
            this.Controls.Add(this.panPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Investimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investimentos";
            this.panPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panCbd.ResumeLayout(false);
            this.panCbd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSetal)).EndInit();
            this.panPoupanca.ResumeLayout(false);
            this.panPoupanca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndicacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.Button btnCbd;
        private System.Windows.Forms.Button btnPoupanca;
        private System.Windows.Forms.Panel panPoupanca;
        private System.Windows.Forms.Button btnRenda;
        private System.Windows.Forms.Label lblEx;
        private System.Windows.Forms.Label lblExpli;
        private System.Windows.Forms.Label lblChama;
        private System.Windows.Forms.PictureBox pcbIndicacao;
        private System.Windows.Forms.Button btnSimule;
        private System.Windows.Forms.Panel panCbd;
        private System.Windows.Forms.Label lblInto2;
        private System.Windows.Forms.Label lblDesc2;
        private System.Windows.Forms.Label lblCdb;
        private System.Windows.Forms.PictureBox pcbSetal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCdiSim;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCbd;
        private System.Windows.Forms.Button BtnS;
        private System.Windows.Forms.Label lblCdbF;
        private System.Windows.Forms.Label lblCdbp;
    }
}