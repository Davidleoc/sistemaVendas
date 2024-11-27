using sistemaVendas.BLL_Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVendas.DAL_Classes
{
     class userDAL_Class
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region selecionar dados do banco
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select * from tbl_usuarios";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                    adapter.Fill(dt);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
            return dt;
        }
        #endregion
        #region cadastrando dados no banco 
        public bool Insert(userBLL_Class u)
        {
            bool isSucesso = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql= "INSERT INTO tbl_usuarios(nome,email,usuario,senha,tipo_usuario,add_data,add_por) VALUES(@nome,@email,@usuario,@senha,@tipo_usuario,@add_data,@add_por)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", u.nome);
                
                cmd.Parameters.AddWithValue("@email", u.email);
               
                cmd.Parameters.AddWithValue("@usuario", u.usuario);
                
                cmd.Parameters.AddWithValue("@senha", u.senha);
                
                cmd.Parameters.AddWithValue("@tipo_usario", u.tipo_usuario);
                
                cmd.Parameters.AddWithValue("@add_data", u.add_data);

                cmd.Parameters.AddWithValue("@add_por", u.add_por);

                conn.Open();
                int rows= cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucesso = true;
                }
                else
                {
                    isSucesso= false;
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
            return isSucesso;
        }
        #endregion
        #region atualizndo dados no banco 
        public bool Update(userBLL_Class u)
        {
            bool isSucesso = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "UPDATE tbl_usuarios SET  nome=@nome,email=@email,usuario=@usuario,senha=@senha,tipo_usuario=@tipo_usuario,add_data=@add_data,add_por=@add_por WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", u.nome);

                cmd.Parameters.AddWithValue("@email", u.email);

                cmd.Parameters.AddWithValue("@usuario", u.usuario);

                cmd.Parameters.AddWithValue("@senha", u.senha);

                cmd.Parameters.AddWithValue("@tipo_usario", u.tipo_usuario);

                cmd.Parameters.AddWithValue("@add_data", u.add_data);

                cmd.Parameters.AddWithValue("@add_por", u.add_por);

                cmd.Parameters.AddWithValue("@id", u.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucesso = true;
                }
                else
                {
                    isSucesso = false;
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
            return isSucesso;

        }
        #endregion
        #region deletando dados no banco 
        public bool Delete(userBLL_Class u)
        {
            bool isSucesso = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "DELETE FROM tbl_usuarios WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@id", u.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucesso = true;
                }
                else
                {
                    isSucesso = false;
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
            return isSucesso;

        }
        #endregion
        #region pesquisar dados do banco
        public DataTable Pesquisar(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "Select * from tbl_usuarios WHERE id LIKE ' %"+keywords+ "%' or nome LIKE ' %\"+keywords+\"%' or email LIKE ' %\"+keywords+\"%' or usuario LIKE ' %\"+keywords+\"%' or nome LIKE ' %\"+keywords+\"%' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
            return dt;
        }
        #endregion
     }

}
