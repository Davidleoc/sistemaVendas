namespace sistemaVendas.UI_formularios
{
    partial class FrmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdTipoUsu = new System.Windows.Forms.ComboBox();
            this.usuario_tipo = new System.Windows.Forms.Label();
            this.txtusuarionick = new System.Windows.Forms.TextBox();
            this.txtUsu = new System.Windows.Forms.Label();
            this.txtsenhaUsu = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.Label();
            this.txtemailusu = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtNomeU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(-128, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::sistemaVendas.Properties.Resources.icone_fermer_et_x_rouge_1;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1031, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Location = new System.Drawing.Point(216, 97);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(107, 26);
            this.txtid.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Id do Usuário :";
            // 
            // cmdTipoUsu
            // 
            this.cmdTipoUsu.FormattingEnabled = true;
            this.cmdTipoUsu.Items.AddRange(new object[] {
            "Usuário",
            "Administrador"});
            this.cmdTipoUsu.Location = new System.Drawing.Point(226, 360);
            this.cmdTipoUsu.Name = "cmdTipoUsu";
            this.cmdTipoUsu.Size = new System.Drawing.Size(281, 28);
            this.cmdTipoUsu.TabIndex = 25;
            // 
            // usuario_tipo
            // 
            this.usuario_tipo.AutoSize = true;
            this.usuario_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_tipo.Location = new System.Drawing.Point(12, 359);
            this.usuario_tipo.Name = "usuario_tipo";
            this.usuario_tipo.Size = new System.Drawing.Size(178, 25);
            this.usuario_tipo.TabIndex = 24;
            this.usuario_tipo.Text = "Tipo de Usuário :";
            // 
            // txtusuarionick
            // 
            this.txtusuarionick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusuarionick.Location = new System.Drawing.Point(216, 300);
            this.txtusuarionick.Name = "txtusuarionick";
            this.txtusuarionick.Size = new System.Drawing.Size(291, 26);
            this.txtusuarionick.TabIndex = 23;
            // 
            // txtUsu
            // 
            this.txtUsu.AutoSize = true;
            this.txtUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.Location = new System.Drawing.Point(12, 299);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(99, 25);
            this.txtUsu.TabIndex = 22;
            this.txtUsu.Text = "Usuário :";
            // 
            // txtsenhaUsu
            // 
            this.txtsenhaUsu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsenhaUsu.Location = new System.Drawing.Point(216, 246);
            this.txtsenhaUsu.Name = "txtsenhaUsu";
            this.txtsenhaUsu.Size = new System.Drawing.Size(291, 26);
            this.txtsenhaUsu.TabIndex = 21;
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(12, 245);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(88, 25);
            this.txtSenha.TabIndex = 20;
            this.txtSenha.Text = "Senha :";
            // 
            // txtemailusu
            // 
            this.txtemailusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemailusu.Location = new System.Drawing.Point(216, 197);
            this.txtemailusu.Name = "txtemailusu";
            this.txtemailusu.Size = new System.Drawing.Size(291, 26);
            this.txtemailusu.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(12, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(78, 25);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Text = "Email :";
            // 
            // txtnome
            // 
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnome.Location = new System.Drawing.Point(216, 143);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(291, 26);
            this.txtnome.TabIndex = 17;
            // 
            // txtNomeU
            // 
            this.txtNomeU.AutoSize = true;
            this.txtNomeU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeU.Location = new System.Drawing.Point(12, 142);
            this.txtNomeU.Name = "txtNomeU";
            this.txtNomeU.Size = new System.Drawing.Size(191, 25);
            this.txtNomeU.TabIndex = 16;
            this.txtNomeU.Text = "Nome do Usuário :";
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdTipoUsu);
            this.Controls.Add(this.usuario_tipo);
            this.Controls.Add(this.txtusuarionick);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.txtsenhaUsu);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtemailusu);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtNomeU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmdTipoUsu;
        private System.Windows.Forms.Label usuario_tipo;
        private System.Windows.Forms.TextBox txtusuarionick;
        private System.Windows.Forms.Label txtUsu;
        private System.Windows.Forms.TextBox txtsenhaUsu;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.TextBox txtemailusu;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label txtNomeU;
    }
}