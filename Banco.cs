using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
    
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Relacionamento_com_o_Cliente
{
    public class Banco
    {
        private static SqlConnection con;
        private static SqlCommand cmd;
        private static String provedor = "datasource=localhost;port=3306;username=root;password=Edri09ano";


        public static SqlConnection Conexao(Boolean x) {
            if (x) {
                             
                con = new SqlConnection(provedor) ;
                con.Open();
                return con;
                provedor = "localhost;port=3306;username=root;password=";
            }
            else if (con != null && !x && con.State != ConnectionState.Closed ) con.Close(); 
            return null;
        }
       
        #region Listar Cliente Inativo

        public static DataTable clientesInativo(int codigo) {
            //con = new SqlConnection(provedor);
            
            con = Conexao(true);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Paciente where Codigo="+codigo, con);
            
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
        
            
        }
        #endregion  
        #region buscarlastcli
        public static DataTable buscarlastcli()
        {
            //con = new SqlConnection(provedor);
            //con.Open();
            con = Conexao(true);
            SqlDataAdapter da = new SqlDataAdapter("select  top 1 codigo from Paciente order by codigo desc",con);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            con.Close();
            return dt;
        }

        #endregion
        
        #region Cadastra Paciente
        public static bool cadPaciente(Paciente c)
        {
            try
            {
                
                string query = "INSERT INTO Paciente (codigo,nome,profissao) values (@p1,@p2,@p3)";
                con = Conexao(true);
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@p1", SqlDbType.Int).Value = c.Codigo;
                cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = c.Nome;
                cmd.Parameters.Add("@p3", SqlDbType.VarChar).Value = c.Profissao;
                /*cmd.Parameters.Add("@p4", SqlDbType.Date).Value = c.DataNascimento;
                cmd.Parameters.Add("@p5", SqlDbType.VarChar).Value = c.Telefone;
                cmd.Parameters.Add("@p6", SqlDbType.Decimal).Value = c.LimiteCredito;
                cmd.Parameters.Add("@p7", SqlDbType.Bit).Value = c.Status; */

                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SystemException e)

            { 
                DialogResult res = MessageBox.Show(e.Message.ToString());
                
                return false; 
            }
            
        }
        #endregion

        #region Buscar Codigo cliente
        public static Paciente BuscaCodigo(int codcli)
        {
            con = Conexao(true);
            cmd = new SqlCommand("SELECT * FROM Paciente WHERE Codigo=@p1 AND Ativo=@p2",con);
            cmd.Parameters.Add("@p1", SqlDbType.Int).Value = codcli;
            cmd.Parameters.Add("@p2", SqlDbType.Bit).Value = true;
            
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                Paciente c = new Paciente();
                c.Codigo = Convert.ToInt32(dr[0]);
                c.Nome = dr[1].ToString();
                c.Profissao = dr[2].ToString();
               /* c.DataNascimento = Convert.ToDateTime(dr[3]);
                c.Telefone = dr[4].ToString();
                c.LimiteCredito = Convert.ToDecimal(dr[5]);
                c.Status = Convert.ToBoolean(dr[6]);*/
                con.Close();
                return c;

            }
            else
            {
                con.Close();
                return null;
            }
            
        }
        #endregion
        #region atualizarcliente
  
        public static bool atualizaCliente(Paciente c)
        {
            try
            {

                string query = "UPDATE Paciente SET Nome=@p2,profissao=@p3, WHERE Codigo = @p1";
                con = Conexao(true);
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@p1", SqlDbType.Int).Value = c.Codigo;
                cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = c.Nome;
                cmd.Parameters.Add("@p3", SqlDbType.VarChar).Value = c.Profissao;
               /* cmd.Parameters.Add("@p4", SqlDbType.Date).Value = c.DataNascimento;
                cmd.Parameters.Add("@p5", SqlDbType.VarChar).Value = c.Telefone;
                cmd.Parameters.Add("@p6", SqlDbType.Decimal).Value = c.LimiteCredito;
                cmd.Parameters.Add("@p7", SqlDbType.Bit).Value = c.Status;*/

                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SystemException e)
            {
                DialogResult res = MessageBox.Show(e.Message.ToString());

                return false;
            }

        }

       
        #endregion

        #region atualizarStatus

        public static bool atualizaStatus(int codigo,Boolean ativar)
        {
            try
            {

                string query = "UPDATE Cliente SET ativo=@p2 WHERE CodCli = @p1";
                con = Conexao(true);
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@p1", SqlDbType.Int).Value = codigo;
                cmd.Parameters.Add("@p2", SqlDbType.Bit).Value = ativar;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (SystemException e)
            {
                DialogResult res = MessageBox.Show(e.Message.ToString());

                return false;
            }

        }


        #endregion


        #region Listar Cliente: codigo e nome

        public static DataTable ListaClientes(int codigo,string nome, Boolean cod)
        {
           
            con = Conexao(true);
            DataTable dt = new DataTable();
            if (cod)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cliente where CodCli=" + codigo, con);
                da.Fill(dt);
            }
            else if (!cod)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cliente where Nome LIKE '" + nome+"%'", con);
                da.Fill(dt);
            }
            con.Close();
            return dt;


        }
        #endregion  

#region buscarAniversariante do mes
        public static DataTable buscarAniversariante()
        {
   
            con = Conexao(true);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cliente WHERE DATEPART(MONTH,DataNasc)=DATEPART(MONTH,GETDATE()) ORDER BY DataNasc", con);
            DataTable dt = new DataTable();

            da.Fill(dt);
            con.Close();
            return dt;
        }
#endregion
        #region buscar todos clientes 
        public static DataTable buscarTodosClientes(bool cod)
        {

            con = Conexao(true);
            
            DataTable dt = new DataTable();
            if (cod)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cliente ORDER BY CodCli", con);
                
                da.Fill(dt);
            }
            else if (!cod)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cliente ORDER BY Nome", con);
                da.Fill(dt);
            }
          
            con.Close();
            return dt;
        }
        #endregion
    }
}
