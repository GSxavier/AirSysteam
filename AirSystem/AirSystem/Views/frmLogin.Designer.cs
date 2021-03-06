﻿namespace AirSystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblIdioma = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pcbBackground = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbxIdioma = new System.Windows.Forms.ComboBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbxSenha = new AirSystem.MarkedWaterTextBox();
            this.tbxUsuario = new AirSystem.MarkedWaterTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(265, 271);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(49, 17);
            this.lblIdioma.TabIndex = 6;
            this.lblIdioma.Text = "Idioma";
            this.lblIdioma.Click += new System.EventHandler(this.lblIdioma_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(258, 388);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(93, 23);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(410, 388);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(97, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pcbBackground
            // 
            this.pcbBackground.Image = ((System.Drawing.Image)(resources.GetObject("pcbBackground.Image")));
            this.pcbBackground.Location = new System.Drawing.Point(1, -27);
            this.pcbBackground.Name = "pcbBackground";
            this.pcbBackground.Size = new System.Drawing.Size(797, 447);
            this.pcbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBackground.TabIndex = 0;
            this.pcbBackground.TabStop = false;
            this.pcbBackground.Click += new System.EventHandler(this.pcbBackground_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLogo.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(302, 64);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(167, 36);
            this.lblLogo.TabIndex = 11;
            this.lblLogo.Text = "AirSystem ";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTempo.Location = new System.Drawing.Point(12, 9);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(41, 19);
            this.lblTempo.TabIndex = 12;
            this.lblTempo.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbxIdioma
            // 
            this.cbxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdioma.FormattingEnabled = true;
            this.cbxIdioma.Items.AddRange(new object[] {
            "Português",
            "Inglês"});
            this.cbxIdioma.Location = new System.Drawing.Point(258, 291);
            this.cbxIdioma.Name = "cbxIdioma";
            this.cbxIdioma.Size = new System.Drawing.Size(239, 21);
            this.cbxIdioma.TabIndex = 9;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(265, 196);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 17);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsuario.Location = new System.Drawing.Point(265, 121);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(96, 18);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Nome Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // tbxSenha
            // 
            this.tbxSenha.ForeColor = System.Drawing.Color.Gray;
            this.tbxSenha.Location = new System.Drawing.Point(268, 216);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(239, 20);
            this.tbxSenha.TabIndex = 14;
            this.tbxSenha.Text = "Digite sua senha";
            this.tbxSenha.WaterMarkText = "Digite sua senha";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.ForeColor = System.Drawing.Color.Gray;
            this.tbxUsuario.Location = new System.Drawing.Point(268, 142);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(239, 20);
            this.tbxUsuario.TabIndex = 13;
            this.tbxUsuario.Text = "Digite seu usuario";
            this.tbxUsuario.WaterMarkText = "Digite seu usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.cbxIdioma);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pcbBackground);
            this.Name = "Form1";
            this.Text = "Login - AirSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbBackground;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Timer timer1;
        private MarkedWaterTextBox tbxUsuario;
        private MarkedWaterTextBox tbxSenha;
        private System.Windows.Forms.ComboBox cbxIdioma;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
    }
}

