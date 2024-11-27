using sistemaVendas.BLL_Classes;
using sistemaVendas.DAL_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVendas.UI_formularios
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }
        produtosBLL p = new produtosBLL();
        produtosDAL pdal = new produtosDAL();
        userDAL_Class userDAL = new userDAL_Class();

        private void txtsenhaUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuarionick_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            p.nomeP = txtnomeP.Text;
            p.descricao = cmddescricao.Text;
            p.preco = double.Parse(txtprecos.Text);
            p.add_data = txtnomeP.Text;

            string logado_sistema = frmLogin.logado_sistema;
            userBLL_Class usr= userDAL.GETIDfronomeusuario(logado_sistema);
            p.add_por = usr.id;

            bool success = pdal.Insert(p);
            if (success==true)
            {
                MessageBox.Show("PRODUTO CADASTRADO COM SUCESSO !");
                Limpar();
                DataTable dt = pdal.Select();
                dvgprodutos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSÍVEL CADASTRAR O PRODUTO. ");

            }
            
        }
        public void Limpar()
        {
            txtid.Text = "";
            txtnomeP.Text = "";
            txtdescricao.Text = "";
            txtid.Text = "";
            txtPesquisarP.Text = "";
        }

    }
}
