﻿namespace Stonks
{
    partial class cdbpos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cdbpos));
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblTempoa = new System.Windows.Forms.Label();
            this.txtInv = new System.Windows.Forms.TextBox();
            this.lblInvestimento = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCDI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPorc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnt = new System.Windows.Forms.Button();
            this.panCalculo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbStonks = new System.Windows.Forms.PictureBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panCalculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStonks)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(12, 230);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(49, 20);
            this.txtAno.TabIndex = 24;
            this.txtAno.TextChanged += new System.EventHandler(this.txtAno_TextChanged);
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // lblTempoa
            // 
            this.lblTempoa.AutoSize = true;
            this.lblTempoa.Location = new System.Drawing.Point(9, 201);
            this.lblTempoa.Name = "lblTempoa";
            this.lblTempoa.Size = new System.Drawing.Size(97, 26);
            this.lblTempoa.TabIndex = 23;
            this.lblTempoa.Text = "Por quanto tempo?\r\n(em anos)";
            // 
            // txtInv
            // 
            this.txtInv.Location = new System.Drawing.Point(12, 100);
            this.txtInv.Name = "txtInv";
            this.txtInv.Size = new System.Drawing.Size(100, 20);
            this.txtInv.TabIndex = 22;
            this.txtInv.TextChanged += new System.EventHandler(this.txtInv_TextChanged);
            this.txtInv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInv_KeyPress);
            // 
            // lblInvestimento
            // 
            this.lblInvestimento.AutoSize = true;
            this.lblInvestimento.Location = new System.Drawing.Point(9, 84);
            this.lblInvestimento.Name = "lblInvestimento";
            this.lblInvestimento.Size = new System.Drawing.Size(118, 13);
            this.lblInvestimento.TabIndex = 21;
            this.lblInvestimento.Text = "Quanto deseja investir?";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 271);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 20;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            this.lblTitulo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTitulo.Location = new System.Drawing.Point(67, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 18);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Simulador CDB Pós fixado";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(96, 270);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCDI
            // 
            this.txtCDI.Location = new System.Drawing.Point(12, 139);
            this.txtCDI.Name = "txtCDI";
            this.txtCDI.Size = new System.Drawing.Size(49, 20);
            this.txtCDI.TabIndex = 29;
            this.txtCDI.TextChanged += new System.EventHandler(this.txtCDI_TextChanged);
            this.txtCDI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCDI_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "CDI (%)";
            // 
            // txtPorc
            // 
            this.txtPorc.Location = new System.Drawing.Point(12, 178);
            this.txtPorc.Name = "txtPorc";
            this.txtPorc.Size = new System.Drawing.Size(49, 20);
            this.txtPorc.TabIndex = 31;
            this.txtPorc.TextChanged += new System.EventHandler(this.txtPorc_TextChanged);
            this.txtPorc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorc_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Porcentagem Ganha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(279, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
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
            this.btnAnt.TabIndex = 17;
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
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
            this.panCalculo.TabIndex = 32;
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
            // cdbpos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 315);
            this.Controls.Add(this.panCalculo);
            this.Controls.Add(this.txtPorc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCDI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblTempoa);
            this.Controls.Add(this.txtInv);
            this.Controls.Add(this.lblInvestimento);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.btnLimpar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "cdbpos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDB Pós-fixado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cdbpos_FormClosed);
            this.Load += new System.EventHandler(this.cdbpos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panCalculo.ResumeLayout(false);
            this.panCalculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStonks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblTempoa;
        private System.Windows.Forms.TextBox txtInv;
        private System.Windows.Forms.Label lblInvestimento;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtCDI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPorc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panCalculo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pcbStonks;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblConta;
    }
}