using System.Windows.Forms;

namespace sistemaVendas.UI_formularios
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeU = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtemailusu = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtsenhaUsu = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.Label();
            this.txtusuarionick = new System.Windows.Forms.TextBox();
            this.txtUsu = new System.Windows.Forms.Label();
            this.usuario_tipo = new System.Windows.Forms.Label();
            this.cmdTipoUsu = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.txtPesquisarUsu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 66);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::sistemaVendas.Properties.Resources.icone_fermer_et_x_rouge_1;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1040, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Usuários";
            // 
            // txtNomeU
            // 
            this.txtNomeU.AutoSize = true;
            this.txtNomeU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeU.Location = new System.Drawing.Point(12, 168);
            this.txtNomeU.Name = "txtNomeU";
            this.txtNomeU.Size = new System.Drawing.Size(191, 25);
            this.txtNomeU.TabIndex = 1;
            this.txtNomeU.Text = "Nome do Usuário :";
            // 
            // txtnome
            // 
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnome.Location = new System.Drawing.Point(216, 169);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(291, 26);
            this.txtnome.TabIndex = 2;
            // 
            // txtemailusu
            // 
            this.txtemailusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemailusu.Location = new System.Drawing.Point(216, 223);
            this.txtemailusu.Name = "txtemailusu";
            this.txtemailusu.Size = new System.Drawing.Size(291, 26);
            this.txtemailusu.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(12, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(78, 25);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Email :";
            this.txtEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtsenhaUsu
            // 
            this.txtsenhaUsu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsenhaUsu.Location = new System.Drawing.Point(216, 272);
            this.txtsenhaUsu.Name = "txtsenhaUsu";
            this.txtsenhaUsu.Size = new System.Drawing.Size(291, 26);
            this.txtsenhaUsu.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(12, 271);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(88, 25);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.Text = "Senha :";
            // 
            // txtusuarionick
            // 
            this.txtusuarionick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusuarionick.Location = new System.Drawing.Point(216, 326);
            this.txtusuarionick.Name = "txtusuarionick";
            this.txtusuarionick.Size = new System.Drawing.Size(291, 26);
            this.txtusuarionick.TabIndex = 8;
            this.txtusuarionick.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtUsu
            // 
            this.txtUsu.AutoSize = true;
            this.txtUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.Location = new System.Drawing.Point(12, 325);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(99, 25);
            this.txtUsu.TabIndex = 7;
            this.txtUsu.Text = "Usuário :";
            this.txtUsu.Click += new System.EventHandler(this.label2_Click);
            // 
            // usuario_tipo
            // 
            this.usuario_tipo.AutoSize = true;
            this.usuario_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_tipo.Location = new System.Drawing.Point(12, 385);
            this.usuario_tipo.Name = "usuario_tipo";
            this.usuario_tipo.Size = new System.Drawing.Size(178, 25);
            this.usuario_tipo.TabIndex = 9;
            this.usuario_tipo.Text = "Tipo de Usuário :";
            // 
            // cmdTipoUsu
            // 
            this.cmdTipoUsu.FormattingEnabled = true;
            this.cmdTipoUsu.Items.AddRange(new object[] {
            "Usuário",
            "Administrador"});
            this.cmdTipoUsu.Location = new System.Drawing.Point(226, 386);
            this.cmdTipoUsu.Name = "cmdTipoUsu";
            this.cmdTipoUsu.Size = new System.Drawing.Size(281, 28);
            this.cmdTipoUsu.TabIndex = 11;
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Location = new System.Drawing.Point(216, 123);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(107, 26);
            this.txtid.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Id do Usuário :";
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuarios.Location = new System.Drawing.Point(622, 135);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.RowHeadersWidth = 62;
            this.dvgUsuarios.RowTemplate.Height = 28;
            this.dvgUsuarios.Size = new System.Drawing.Size(420, 307);
            this.dvgUsuarios.TabIndex = 16;
            this.dvgUsuarios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgUsuarios_RowHeaderMouseClick);
            // 
            // txtPesquisarUsu
            // 
            this.txtPesquisarUsu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisarUsu.Location = new System.Drawing.Point(751, 103);
            this.txtPesquisarUsu.Name = "txtPesquisarUsu";
            this.txtPesquisarUsu.Size = new System.Drawing.Size(291, 26);
            this.txtPesquisarUsu.TabIndex = 18;
            this.txtPesquisarUsu.TextChanged += new System.EventHandler(this.txtPesquisarUsu_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pesquisar Usuário :";
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(71, 451);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(141, 49);
            this.btCadastrar.TabIndex = 19;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Location = new System.Drawing.Point(269, 451);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(153, 49);
            this.btAtualizar.TabIndex = 20;
            this.btAtualizar.Text = "Alterar";
            this.btAtualizar.UseVisualStyleBackColor = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(469, 451);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(148, 49);
            this.btExcluir.TabIndex = 21;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 527);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.txtPesquisarUsu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dvgUsuarios);
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.Text = "FORMULARO DE USUARIOS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtNomeU;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtemailusu;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox txtsenhaUsu;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.TextBox txtusuarionick;
        private System.Windows.Forms.Label txtUsu;
        private System.Windows.Forms.Label usuario_tipo;
        private System.Windows.Forms.ComboBox cmdTipoUsu;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.TextBox txtPesquisarUsu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btExcluir;
       
    }
}