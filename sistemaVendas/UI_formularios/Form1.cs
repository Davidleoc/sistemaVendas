using sistemaVendas.UI_formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVendas
{
    public partial class frmAdminPainel : Form
    {
        public frmAdminPainel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios user = new FrmUsuarios();
            user.Show();
        }

        private void frmAdminPainel_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin(); 
            login.Show();   
            this.Hide();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProdutos produtos = new FrmProdutos();   
            produtos.Show();
        }
    }
}
