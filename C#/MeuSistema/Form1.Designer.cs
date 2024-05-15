namespace MeuSistema
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.btok = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtname2 = new System.Windows.Forms.TextBox();
            this.btok2 = new System.Windows.Forms.Button();
            this.btcancelar2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salvar = new System.Windows.Forms.CheckBox();
            this.salvar2 = new System.Windows.Forms.CheckBox();
            this.login = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(440, 271);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(75, 23);
            this.btok.TabIndex = 0;
            this.btok.Text = "OK";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(564, 271);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(75, 23);
            this.btcancelar.TabIndex = 1;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(426, 222);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(213, 20);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtname2
            // 
            this.txtname2.Location = new System.Drawing.Point(62, 222);
            this.txtname2.Name = "txtname2";
            this.txtname2.Size = new System.Drawing.Size(213, 20);
            this.txtname2.TabIndex = 3;
            this.txtname2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btok2
            // 
            this.btok2.Location = new System.Drawing.Point(62, 271);
            this.btok2.Name = "btok2";
            this.btok2.Size = new System.Drawing.Size(75, 23);
            this.btok2.TabIndex = 4;
            this.btok2.Text = "OK";
            this.btok2.UseVisualStyleBackColor = true;
            // 
            // btcancelar2
            // 
            this.btcancelar2.Location = new System.Drawing.Point(200, 271);
            this.btcancelar2.Name = "btcancelar2";
            this.btcancelar2.Size = new System.Drawing.Size(75, 23);
            this.btcancelar2.TabIndex = 5;
            this.btcancelar2.Text = "Cancelar";
            this.btcancelar2.UseVisualStyleBackColor = true;
            this.btcancelar2.Click += new System.EventHandler(this.btcancelar2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MeuSistema.Properties.Resources.reuniao_de_orcamento_400x280_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(162, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // salvar
            // 
            this.salvar.AutoSize = true;
            this.salvar.Location = new System.Drawing.Point(219, 248);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(56, 17);
            this.salvar.TabIndex = 7;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            // 
            // salvar2
            // 
            this.salvar2.AutoSize = true;
            this.salvar2.Location = new System.Drawing.Point(583, 248);
            this.salvar2.Name = "salvar2";
            this.salvar2.Size = new System.Drawing.Size(56, 17);
            this.salvar2.TabIndex = 8;
            this.salvar2.Text = "Salvar";
            this.salvar2.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(70, 206);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(33, 13);
            this.login.TabIndex = 9;
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.label1_Click);
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Location = new System.Drawing.Point(437, 206);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(38, 13);
            this.senha.TabIndex = 10;
            this.senha.Text = "Senha";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(684, 349);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.login);
            this.Controls.Add(this.salvar2);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.btcancelar2);
            this.Controls.Add(this.btok2);
            this.Controls.Add(this.txtname2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.Text = "GalerisCelso";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtname2;
        private System.Windows.Forms.Button btok2;
        private System.Windows.Forms.Button btcancelar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox salvar;
        private System.Windows.Forms.CheckBox salvar2;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label senha;
    }
}

