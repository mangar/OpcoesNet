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

        public AcoesDB(MySqlConnection conn)
        {
            this.myConn = conn;
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


        public void deleteAcao(int idAcao)
        {
            MySqlCommand comm = this.myConn.CreateCommand();

            MySqlCommand sqlcommand = new MySqlCommand("DELETE FROM ACOES WHERE id = @id", this.myConn);
            sqlcommand.Parameters.AddWithValue("@id", idAcao);

            sqlcommand.ExecuteNonQuery();
        }



        public void deleteMovimentacoesByIdAcao(int idAcao)
        {
            MySqlCommand comm = this.myConn.CreateCommand();

            MySqlCommand sqlcommand = new MySqlCommand("DELETE FROM ACOES_MOVIMENTACOES WHERE acoes_id = @id", this.myConn);
            sqlcommand.Parameters.AddWithValue("@id", idAcao);

            sqlcommand.ExecuteNonQuery();
        }


        public void selectMovimentacoes(string ticker)
        {
            //SELECT t1.id, t2.ticker, t1.quantidade, t1.preco, t1.descricao
            //FROM ACOES_MOVIMENTACOES t1 LEFT OUTER JOIN ACOES t2 ON t1.acoes_id = t2.id

        }


        /**
         * 
         * 
         */
        public long insertMovimentacao(int idAcao, int quantidade, decimal preco, string dataMovimentacao, string descricao)
        {
            MySqlCommand comm = this.myConn.CreateCommand();

            string insertStmt = "INSERT INTO ACOES_MOVIMENTACOES (acoes_id, quantidade, preco, data_registro, descricao, createdAt, updatedAt) VALUES (@idAcao, @quantidade, @preco, @data, @descricao, now(), now())";

            MySqlCommand sqlcommand = new MySqlCommand(insertStmt, this.myConn);
            sqlcommand.Parameters.AddWithValue("@idAcao", idAcao);
            sqlcommand.Parameters.AddWithValue("@quantidade", quantidade);
            sqlcommand.Parameters.AddWithValue("@preco", preco);
            sqlcommand.Parameters.AddWithValue("@data", dataMovimentacao);
            sqlcommand.Parameters.AddWithValue("@descricao", descricao);

            sqlcommand.ExecuteNonQuery();

            //comm.ExecuteNonQuery();              // Execute the command
            long id = comm.LastInsertedId;       // Get the ID of the inserted item
            return id;
        }




    }

}
