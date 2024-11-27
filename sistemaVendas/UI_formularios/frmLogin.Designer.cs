namespace sistemaVendas.UI_formularios
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cmdTipoUsu = new System.Windows.Forms.ComboBox();
            this.usuario_tipo = new System.Windows.Forms.Label();
            this.txtusuarionick = new System.Windows.Forms.TextBox();
            this.txtUsu = new System.Windows.Forms.Label();
            this.txtsenhaUsu = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdTipoUsu
            // 
            this.cmdTipoUsu.FormattingEnabled = true;
            this.cmdTipoUsu.Items.AddRange(new object[] {
            "Usuário",
            "Administrador"});
            this.cmdTipoUsu.Location = new System.Drawing.Point(213, 298);
            this.cmdTipoUsu.Name = "cmdTipoUsu";
            this.cmdTipoUsu.Size = new System.Drawing.Size(291, 28);
            this.cmdTipoUsu.TabIndex = 21;
            // 
            // usuario_tipo
            // 
            this.usuario_tipo.AutoSize = true;
            this.usuario_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_tipo.Location = new System.Drawing.Point(9, 297);
            this.usuario_tipo.Name = "usuario_tipo";
            this.usuario_tipo.Size = new System.Drawing.Size(178, 25);
            this.usuario_tipo.TabIndex = 20;
            this.usuario_tipo.Text = "Tipo de Usuário :";
            // 
            // txtusuarionick
            // 
            this.txtusuarionick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusuarionick.Location = new System.Drawing.Point(213, 157);
            this.txtusuarionick.Name = "txtusuarionick";
            this.txtusuarionick.Size = new System.Drawing.Size(291, 26);
            this.txtusuarionick.TabIndex = 19;
            this.txtusuarionick.TextChanged += new System.EventHandler(this.txtusuarionick_TextChanged);
            // 
            // txtUsu
            // 
            this.txtUsu.AutoSize = true;
            this.txtUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.Location = new System.Drawing.Point(9, 155);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(99, 25);
            this.txtUsu.TabIndex = 18;
            this.txtUsu.Text = "Usuário :";
            // 
            // txtsenhaUsu
            // 
            this.txtsenhaUsu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsenhaUsu.Location = new System.Drawing.Point(213, 221);
            this.txtsenhaUsu.Name = "txtsenhaUsu";
            this.txtsenhaUsu.PasswordChar = '*';
            this.txtsenhaUsu.Size = new System.Drawing.Size(291, 26);
            this.txtsenhaUsu.TabIndex = 17;
            this.txtsenhaUsu.TextChanged += new System.EventHandler(this.txtsenhaUsu_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(9, 222);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(88, 25);
            this.txtSenha.TabIndex = 16;
            this.txtSenha.Text = "Senha :";
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Goldenrod;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(213, 358);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(249, 56);
            this.btLogin.TabIndex = 22;
            this.btLogin.Text = "Fazer Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "FAÇA LOGIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 65);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::sistemaVendas.Properties.Resources.icone_fermer_et_x_rouge_1;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(553, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.cmdTipoUsu);
            this.Controls.Add(this.usuario_tipo);
            this.Controls.Add(this.txtusuarionick);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.txtsenhaUsu);
            this.Controls.Add(this.txtSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdTipoUsu;
        private System.Windows.Forms.Label usuario_tipo;
        private System.Windows.Forms.TextBox txtusuarionick;
        private System.Windows.Forms.Label txtUsu;
        private System.Windows.Forms.TextBox txtsenhaUsu;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}