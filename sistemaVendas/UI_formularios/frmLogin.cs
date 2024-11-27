using sistemaVendas.BLL_Classes;
using sistemaVendas.DAL_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaVendas.UI_formularios;

namespace sistemaVendas.UI_formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        LoginBLL l =new LoginBLL();
        LoginDAL dal = new LoginDAL();
        public static string logado_sistema ;
        private void txtusuarionick_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsenhaUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            l.nome = txtusuarionick.Text.Trim();
            l.senha = txtSenha.Text.Trim();
            l.usuario_tipo = cmdTipoUsu.Text.Trim();

            bool sucess = dal.loginChecar(l);
            if (sucess==true) 
            {
                MessageBox.Show("LOGIN COM SUCESSO !");
                switch(l.usuario_tipo)
                {
                    case "Administrador":
                        {
                            frmAdminPainel admin=new frmAdminPainel();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "Usuario":
                        {
                            FrmUsuarios user = new FrmUsuarios();
                            user.Show();
                            this.Hide();

                        } 
                        break;
                    case "default":
                        {
                            MessageBox.Show("LOGIN OU SENHA INCORRETA ");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSÍVEL ENTRAR ");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datatime= DateTime.Now;
            this.label2.Text = datatime.ToString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
