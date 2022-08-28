namespace Stonks
{
    partial class poupanca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(poupanca));
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.txtSelic = new System.Windows.Forms.TextBox();
            this.lblSelic = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panCalculo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbStonks = new System.Windows.Forms.PictureBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panCalculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStonks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadora.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCalculadora.Location = new System.Drawing.Point(66, 27);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(201, 18);
            this.lblCalculadora.TabIndex = 3;
            this.lblCalculadora.Text = "Calculadora da poupança";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(12, 155);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(60, 20);
            this.txtDinheiro.TabIndex = 6;
            this.txtDinheiro.TextChanged += new System.EventHandler(this.txtDinheiro_TextChanged);
            this.txtDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDinheiro_KeyPress);
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(12, 114);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(46, 20);
            this.txtTempo.TabIndex = 10;
            this.txtTempo.TextChanged += new System.EventHandler(this.txtTempo_TextChanged);
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempo_KeyPress);
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Location = new System.Drawing.Point(12, 139);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(116, 13);
            this.lblDinheiro.TabIndex = 7;
            this.lblDinheiro.Text = "Quanto será investido?";
            // 
            // txtSelic
            // 
            this.txtSelic.Location = new System.Drawing.Point(12, 200);
            this.txtSelic.Name = "txtSelic";
            this.txtSelic.Size = new System.Drawing.Size(57, 20);
            this.txtSelic.TabIndex = 9;
            this.txtSelic.TextChanged += new System.EventHandler(this.txtSelic_TextChanged);
            this.txtSelic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSelic_KeyPress);
            // 
            // lblSelic
            // 
            this.lblSelic.AutoSize = true;
            this.lblSelic.Location = new System.Drawing.Point(12, 184);
            this.lblSelic.Name = "lblSelic";
            this.lblSelic.Size = new System.Drawing.Size(74, 13);
            this.lblSelic.TabIndex = 8;
            this.lblSelic.Text = "Taxa Selic (%)";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(12, 85);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(161, 26);
            this.lblTempo.TabIndex = 5;
            this.lblTempo.Text = "Quanto Tempo de investimento?\r\n(em anos)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = " ";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(13, 222);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(149, 24);
            this.lblDesc.TabIndex = 12;
            this.lblDesc.Text = "Se deixar em branco será usado \r\no valor de 5,5 (taxa do SELIC 2019)";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 263);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panCalculo
            // 
            this.panCalculo.Controls.Add(this.pictureBox2);
            this.panCalculo.Controls.Add(this.pcbStonks);
            this.panCalculo.Controls.Add(this.txtTotal);
            this.panCalculo.Controls.Add(this.lblConta);
            this.panCalculo.Location = new System.Drawing.Point(168, 85);
            this.panCalculo.Name = "panCalculo";
            this.panCalculo.Size = new System.Drawing.Size(210, 161);
            this.panCalculo.TabIndex = 14;
            this.panCalculo.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Stonks.Properties.Resources.simbolo_igual_png_5;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 36);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pcbStonks
            // 
            this.pcbStonks.BackgroundImage = global::Stonks.Properties.Resources._2f0;
            this.pcbStonks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbStonks.Location = new System.Drawing.Point(80, 54);
            this.pcbStonks.Name = "pcbStonks";
            this.pcbStonks.Size = new System.Drawing.Size(116, 81);
            this.pcbStonks.TabIndex = 3;
            this.pcbStonks.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(61, 23);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(58, 7);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(0, 13);
            this.lblConta.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(99, 263);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.BackgroundImage = global::Stonks.Properties.Resources.seta_esquerda;
            this.btnAnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnt.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnt.Location = new System.Drawing.Point(12, 11);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(49, 51);
            this.btnAnt.TabIndex = 4;
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(278, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // poupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 315);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panCalculo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSelic);
            this.Controls.Add(this.lblSelic);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblDinheiro);
            this.Controls.Add(this.lblCalculadora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDinheiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "poupanca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poupança";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.poupanca_FormClosed);
            this.Load += new System.EventHandler(this.poupanca_Load);
            this.panCalculo.ResumeLayout(false);
            this.panCalculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStonks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.TextBox txtSelic;
        private System.Windows.Forms.Label lblSelic;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panCalculo;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox pcbStonks;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}