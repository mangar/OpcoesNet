using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace OpcoesNet.Database
{
    class DB
    {

        public static string MySqlClientString = "server=localhost;user id=root;password=password;database=opcoesnet";

        public static MySqlConnection ConexaoBD()
        {
            MySqlConnection conn = new MySqlConnection(MySqlClientString);
            try
            {
                if (conn.State.Equals(ConnectionState.Closed))
                {
                    conn.Open();

                    MessageBox.Show("Conectado no banco de dados");

                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados : " + erro.Message, "Erro de Conexão",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            //finally
            //{
            //    conn.Dispose();
            //    MessageBox.Show("DESConectado no banco de dados");
            //}

            return conn;
        }


        public static void closeConnection(MySqlConnection conn)
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
        }




    }

}
