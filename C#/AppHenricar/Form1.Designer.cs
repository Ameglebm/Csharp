namespace AppHenricar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fundoHenri = new System.Windows.Forms.PictureBox();
            this.btentrar = new System.Windows.Forms.Button();
            this.senhaAcesso = new System.Windows.Forms.TextBox();
            this.loginAcesso = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.Label();
            this.linkEsqueciSenha = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fundoHenri)).BeginInit();
            this.SuspendLayout();
            // 
            // fundoHenri
            // 
            this.fundoHenri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fundoHenri.BackgroundImage")));
            this.fundoHenri.Location = new System.Drawing.Point(29, 12);
            this.fundoHenri.Name = "fundoHenri";
            this.fundoHenri.Size = new System.Drawing.Size(495, 334);
            this.fundoHenri.TabIndex = 1;
            this.fundoHenri.TabStop = false;
            // 
            // btentrar
            // 
            this.btentrar.BackColor = System.Drawing.Color.Lavender;
            this.btentrar.Location = new System.Drawing.Point(228, 465);
            this.btentrar.Name = "btentrar";
            this.btentrar.Size = new System.Drawing.Size(56, 26);
            this.btentrar.TabIndex = 4;
            this.btentrar.Text = "Entrar";
            this.btentrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btentrar.UseVisualStyleBackColor = false;
            this.btentrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // senhaAcesso
            // 
            this.senhaAcesso.Location = new System.Drawing.Point(118, 433);
            this.senhaAcesso.Multiline = true;
            this.senhaAcesso.Name = "senhaAcesso";
            this.senhaAcesso.Size = new System.Drawing.Size(299, 26);
            this.senhaAcesso.TabIndex = 5;
            // 
            // loginAcesso
            // 
            this.loginAcesso.Location = new System.Drawing.Point(118, 384);
            this.loginAcesso.Multiline = true;
            this.loginAcesso.Name = "loginAcesso";
            this.loginAcesso.Size = new System.Drawing.Size(299, 26);
            this.loginAcesso.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(115, 368);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(50, 13);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(115, 417);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(43, 13);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // linkEsqueciSenha
            // 
            this.linkEsqueciSenha.AutoSize = true;
            this.linkEsqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEsqueciSenha.LinkColor = System.Drawing.Color.Black;
            this.linkEsqueciSenha.Location = new System.Drawing.Point(298, 417);
            this.linkEsqueciSenha.Name = "linkEsqueciSenha";
            this.linkEsqueciSenha.Size = new System.Drawing.Size(119, 13);
            this.linkEsqueciSenha.TabIndex = 9;
            this.linkEsqueciSenha.TabStop = true;
            this.linkEsqueciSenha.Text = "Esqueceu a senha?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(536, 522);
            this.Controls.Add(this.linkEsqueciSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.loginAcesso);
            this.Controls.Add(this.senhaAcesso);
            this.Controls.Add(this.btentrar);
            this.Controls.Add(this.fundoHenri);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Henricar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fundoHenri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox fundoHenri;
        private System.Windows.Forms.Button btentrar;
        private System.Windows.Forms.TextBox senhaAcesso;
        private System.Windows.Forms.TextBox loginAcesso;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.LinkLabel linkEsqueciSenha;
    }
}

