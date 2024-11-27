using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemaVendas.BLL_Classes;
using System.Windows.Forms;

namespace sistemaVendas.DAL_Classes
{
    internal class LoginDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(myconnstring);

        public bool loginChecar(LoginBLL l)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "Select * from tbl_usuarios where nome=@nome and senha=@senha and usuario_tipo=@usuario_tipo";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", l.nome);
                cmd.Parameters.AddWithValue("@senha", l.senha);
                cmd.Parameters.AddWithValue("@usuario_tipo", l.usuario_tipo);


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
            return isSucess;
        }
    }
        
        
            

}
