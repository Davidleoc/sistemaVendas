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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        userBLL_Class u = new userBLL_Class();
        userDAL_Class dal = new userDAL_Class();


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            u.nome = txtnome.Text;
            u.email = txtemailusu.Text;
            u.usuario = txtusuarionick.Text;
            u.senha = txtsenhaUsu.Text;
            u.add_data = DateTime.Now;
            u.add_por = 1;

            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO");
                Limpar();
            }
            else
            {
                MessageBox.Show("NAO FOI POSSIVEL REALIZAR ESTE CADASTRO");
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dvgUsuarios.DataSource = dt;
        }
        private void Limpar()
        {
            txtEmail.Text = "";
            txtnome.Text="";
            txtemailusu.Text = "";
            txtusuarionick.Text = "";
            txtsenhaUsu.Text= "";
           
        }

        private void dvgUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex= e.RowIndex;
            txtid.Text = dvgUsuarios.Rows[rowIndex].Cells[0].Value.ToString();
            txtnome.Text = dvgUsuarios.Rows[rowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dvgUsuarios.Rows[rowIndex].Cells[2].Value.ToString();
            txtUsu.Text = dvgUsuarios.Rows[rowIndex].Cells[3].Value.ToString();
            txtSenha.Text = dvgUsuarios.Rows[rowIndex].Cells[4].Value.ToString();
            cmdTipoUsu.Text = dvgUsuarios.Rows[rowIndex].Cells[5].Value.ToString();
           
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            u.id=Convert.ToInt32(txtid.Text);

            u.nome = txtnome.Text;
            u.email = txtUsu.Text;
            u.usuario = txtUsu.Text;
            u.senha= txtSenha.Text;
            u.tipo_usuario = cmdTipoUsu.Text;
            u.add_data = DateTime.Now;
            u.add_por = 1;
            
            bool sucesso = dal.Update(u);
            
            if(sucesso==true)
            {
                MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO !");
            }
            else
            {
                MessageBox.Show("nÃO FOI POSSÍVEL ATUALIZAR ESSE CADASTRO ");

            }DataTable dt = dal.Select();
            dvgUsuarios.DataSource= dt;

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtid.Text);


            bool sucesso = dal.Delete(u);

            if (sucesso == true)
            {
                MessageBox.Show("CADASTRO DELETADO COM SUCESSO !");
            }
            else
            {
                MessageBox.Show("nÃO FOI POSSÍVEL DELETAR ESSE CADASTRO ");

            }
            DataTable dt = dal.Select();
            dvgUsuarios.DataSource = dt;
        }

        private void txtPesquisarUsu_TextChanged(object sender, EventArgs e)
        { 

            string keyword = txtPesquisarUsu.Text;

            if (keyword != null)
            {
               DataTable dt=dal.Pesquisar(keyword);
                dvgUsuarios.DataSource=dt;
            }
            else
            {
                DataTable dt = dal.Pesquisar(keyword);
                dvgUsuarios.DataSource = dt;

            }
                           
        }

        private void FrmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
