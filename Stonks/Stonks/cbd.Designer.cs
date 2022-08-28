namespace Stonks
{
    partial class cdb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cdb));
            this.btnAnt = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblInvestimento = new System.Windows.Forms.Label();
            this.txtInv = new System.Windows.Forms.TextBox();
            this.lblTempoa = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.panCalculo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbStonks = new System.Windows.Forms.PictureBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panCalculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStonks)).BeginInit();
            this.SuspendLayout();
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
            this.btnAnt.TabIndex = 5;
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            this.lblTitulo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTitulo.Location = new System.Drawing.Point(66, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 18);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Simulador CDB Pré fixado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(278, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(12, 280);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblInvestimento
            // 
            this.lblInvestimento.AutoSize = true;
            this.lblInvestimento.Location = new System.Drawing.Point(9, 87);
            this.lblInvestimento.Name = "lblInvestimento";
            this.lblInvestimento.Size = new System.Drawing.Size(118, 13);
            this.lblInvestimento.TabIndex = 9;
            this.lblInvestimento.Text = "Quanto deseja investir?";
            // 
            // txtInv
            // 
            this.txtInv.Location = new System.Drawing.Point(12, 103);
            this.txtInv.Name = "txtInv";
            this.txtInv.Size = new System.Drawing.Size(100, 20);
            this.txtInv.TabIndex = 10;
            this.txtInv.TextChanged += new System.EventHandler(this.txtInv_TextChanged);
            this.txtInv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInv_KeyPress);
            // 
            // lblTempoa
            // 
            this.lblTempoa.AutoSize = true;
            this.lblTempoa.Location = new System.Drawing.Point(9, 126);
            this.lblTempoa.Name = "lblTempoa";
            this.lblTempoa.Size = new System.Drawing.Size(97, 26);
            this.lblTempoa.TabIndex = 11;
            this.lblTempoa.Text = "Por quanto tempo?\r\n(em meses)";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(12, 155);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(49, 20);
            this.txtAno.TabIndex = 12;
            this.txtAno.TextChanged += new System.EventHandler(this.txtAno_TextChanged);
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(93, 280);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.Location = new System.Drawing.Point(12, 221);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(137, 36);
            this.lblTaxa.TabIndex = 16;
            this.lblTaxa.Text = "Se deixar em branco será usado \r\ncomo taxa de\r\n12% do Banco Stonks";
            // 
            // panCalculo
            // 
            this.panCalculo.Controls.Add(this.label1);
            this.panCalculo.Controls.Add(this.pictureBox2);
            this.panCalculo.Controls.Add(this.pcbStonks);
            this.panCalculo.Controls.Add(this.txtTotal);
            this.panCalculo.Controls.Add(this.lblConta);
            this.panCalculo.Location = new System.Drawing.Point(168, 85);
            this.panCalculo.Name = "panCalculo";
            this.panCalculo.Size = new System.Drawing.Size(210, 161);
            this.panCalculo.TabIndex = 17;
            this.panCalculo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Renda Líquida:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Stonks.Properties.Resources.simbolo_igual_png_5;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 36);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pcbStonks
            // 
            this.pcbStonks.BackgroundImage = global::Stonks.Properties.Resources._2f0;
            this.pcbStonks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbStonks.Location = new System.Drawing.Point(78, 70);
            this.pcbStonks.Name = "pcbStonks";
            this.pcbStonks.Size = new System.Drawing.Size(116, 81);
            this.pcbStonks.TabIndex = 3;
            this.pcbStonks.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(94, 28);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(4, 2);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(0, 13);
            this.lblConta.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Taxa do banco";
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(12, 198);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(49, 20);
            this.txtTaxa.TabIndex = 19;
            this.txtTaxa.TextChanged += new System.EventHandler(this.txtTaxa_TextChanged);
            this.txtTaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxa_KeyPress);
            // 
            // cdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 315);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panCalculo);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblTempoa);
            this.Controls.Add(this.txtInv);
            this.Controls.Add(this.lblInvestimento);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cdb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDB pré-fixado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cdb_FormClosed);
            this.Load += new System.EventHandler(this.cdb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panCalculo.ResumeLayout(false);
            this.panCalculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStonks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblInvestimento;
        private System.Windows.Forms.TextBox txtInv;
        private System.Windows.Forms.Label lblTempoa;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Panel panCalculo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pcbStonks;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaxa;
    }
}