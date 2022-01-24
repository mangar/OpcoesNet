using MySql.Data.MySqlClient;
using System;
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



        public void updateAcao(int idAtivo, string ticker, int quantidade, decimal precoMedio)
        {
            MySqlCommand comm = this.myConn.CreateCommand();

            string insertStmt = "UPDATE ACOES SET " +
                                "  ticker = @ticker, " +
                                "  quantidade = @quantidade, " +
                                "  preco_medio = @preco_medio " +
                                " WHERE id = @idAtivo";

            //comm.CommandText = insertStatement;  // Set the insert statement

            MySqlCommand sqlcommand = new MySqlCommand(insertStmt, this.myConn);
            sqlcommand.Parameters.AddWithValue("@ticker", ticker);
            sqlcommand.Parameters.AddWithValue("@quantidade", quantidade);
            sqlcommand.Parameters.AddWithValue("@preco_medio", precoMedio);
            sqlcommand.Parameters.AddWithValue("@idAtivo", idAtivo);


            sqlcommand.ExecuteNonQuery();

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


        public void deleteMovimentacoesById(int id)
        {
            MySqlCommand comm = this.myConn.CreateCommand();

            MySqlCommand sqlcommand = new MySqlCommand("DELETE FROM ACOES_MOVIMENTACOES WHERE id = @id", this.myConn);
            sqlcommand.Parameters.AddWithValue("@id", id);

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

            string insertStmt = " INSERT INTO ACOES_MOVIMENTACOES (acoes_id, quantidade, preco, data_registro, descricao, createdAt, updatedAt) " + 
                                " VALUES (@idAcao, @quantidade, @preco, @data, @descricao, now(), now())";

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


        /**
         * Calculo de PM:
         * 1) Soma todos os valores de movimentações até o momento
         * 2) Divide *1 pela quantidade total de lotes.
         */
        public void atualizarQuantidade(int idAtivo)
        {

            //Calculo do PM
            MySqlCommand comm = this.myConn.CreateCommand();
            string stmtPrecoEQtde = " SELECT acoes_id, quantidade, preco, quantidade * preco as total " +
                                    " FROM ACOES_MOVIMENTACOES " +
                                    " WHERE acoes_id = " + idAtivo;

            MySqlCommand sqlcommand = new MySqlCommand(stmtPrecoEQtde, this.myConn);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = sqlcommand;

            DataSet dSet = new DataSet();
            DataTable dTable = new DataTable();

            dataAdapter.Fill(dSet);
            dTable = dSet.Tables[0];


            int qtdeTotal = 0;
            decimal precoTotal = 0;
            foreach (DataRow row in dTable.Rows)
            {
                qtdeTotal += Int32.Parse(row["quantidade"].ToString());
                precoTotal += Decimal.Parse(row["total"].ToString());
            }


            decimal precoMedio = precoTotal / qtdeTotal;


            // Atualiza o ativo com a quantidade e o PM


            string updateStmt = " UPDATE ACOES SET " +
                                " quantidade = @quantidade, " +
                                " preco_medio = @preco_medio " +
                                " WHERE id = @id";

            //comm.CommandText = insertStatement;  // Set the insert statement

            MySqlCommand sqlCmdUpdate = new MySqlCommand(updateStmt, this.myConn);
            sqlCmdUpdate.Parameters.AddWithValue("@quantidade", qtdeTotal);
            sqlCmdUpdate.Parameters.AddWithValue("@preco_medio", precoMedio);
            sqlCmdUpdate.Parameters.AddWithValue("@id", idAtivo);

            sqlCmdUpdate.ExecuteNonQuery();

        }






    }

}
