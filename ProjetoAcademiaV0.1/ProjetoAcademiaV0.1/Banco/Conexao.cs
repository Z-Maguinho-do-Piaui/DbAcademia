using Npgsql;
using ProjetoAcademiaV0._1.Entidades;
using System.Windows.Forms;

namespace ProjetoAcademiaV0._1
{
    public class Conexao
    {

        private static string cs = "Host=localhost;Username=postgres;Password=1910710;Database=dbprojeto";
        private static NpgsqlConnection con = new NpgsqlConnection(cs);

        //Abrir conexão 
        public static NpgsqlConnection AbreConexao()
        {
            try
            {
                if (con.State.ToString() == "Closed")
                {
                    con.Open();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return con;

        }

        //CRUD - CREATE - READ - UPDATE - DELETE
        public static void InserirCliente(Cliente cliente)
        {
            try
            {
                var sql = "INSERT INTO tbcliente (nome, senha) VALUES(@nome, @senha)";

                NpgsqlConnection con = Conexao.AbreConexao();

                NpgsqlCommand cmdPostgres = new NpgsqlCommand(sql, con);
                cmdPostgres.Parameters.AddWithValue("nome", cliente.Nome);
                cmdPostgres.Parameters.AddWithValue("senha", cliente.Senha);
                cmdPostgres.Prepare();
                cmdPostgres.ExecuteNonQuery();
                con.Close();

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static Cliente ListarCliente()
        {
            return new Cliente();
        }
        public static void AtualizarCliente()
        {

        }
        public static void DeletarCliente ()
        {

        }
    
    }
}


