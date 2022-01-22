using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OpcoesNet.Database
{
    class AcoesDB
    {

        MySqlConnection myConn;
        public AcoesDB()
        {
            this.myConn = DB.ConexaoBD();
        }

        public void insertAcao(string ticker, int quantidade, decimal precoMedio)
        {
            MySqlCommand comm = this.myConn.CreateCommand();

            string insertStmt = "INSERT INTO ACOES (ticker, quantidade, preco_medio) VALUES (@ticker, @quantidade, @preco_medio)";

            //comm.CommandText = insertStatement;  // Set the insert statement

            MySqlCommand sqlcommand = new MySqlCommand(insertStmt, this.myConn);
            sqlcommand.Parameters.AddWithValue("@ticker", ticker);
            sqlcommand.Parameters.AddWithValue("@quantidade", quantidade);
            sqlcommand.Parameters.AddWithValue("@preco_medio", precoMedio);


            sqlcommand.ExecuteNonQuery();

            //comm.ExecuteNonQuery();              // Execute the command
            long id = comm.LastInsertedId;       // Get the ID of the inserted item

        }


        





    }

}
