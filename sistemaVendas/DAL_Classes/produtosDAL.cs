using sistemaVendas.BLL_Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVendas.DAL_Classes
{
    internal class produtosDAL
    {

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(myconnstring);

        public DataTable Select()
        {

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                String sql = "Select * from tbl_produtos ";
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


        public bool Insert(produtosBLL p)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "Select * from tbl_produtos (nomeP,descricao,preco,add_data,add_por) VALUES (@nomeP,@descricao,@preco,@add_data,@add_por)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nomeP", p.nomeP);
                cmd.Parameters.AddWithValue("@descricao, p.descricao);
                cmd.Parameters.AddWithValue("@preco", p.preco);
                cmd.Parameters.AddWithValue("@add_data", p.add_data);
                cmd.Parameters.AddWithValue("@add_por", p.add_por);


                conn.Open();
                int rows = cmd.ExecuteNonQuery();


                if (rows > 0)
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
        public bool Updae(produtosBLL p)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "UPDATE tbl_produtos SET nomeP=@nomeP,descricao=@descricap,preco=@preco,add_data=@add_data,add_por=@add_por WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nomeP", p.nomeP);
                cmd.Parameters.AddWithValue("@descricao, p.descricao);
                cmd.Parameters.AddWithValue("@preco", p.preco);
                cmd.Parameters.AddWithValue("@add_data", p.add_data);
                cmd.Parameters.AddWithValue("@add_por", p.add_por);
                cmd.Parameters.AddWithValue("@id", p.id);


                conn.Open();
                int rows = cmd.ExecuteNonQuery();


                if (rows > 0)
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
        public bool Delete(produtosBLL p)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "DELETE FROM tbl_produtos WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", p.id);


                conn.Open();
                int rows = cmd.ExecuteNonQuery();


                if (rows > 0)
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
