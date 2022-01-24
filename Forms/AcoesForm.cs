using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OpcoesNet.Database;

namespace OpcoesNet.Forms
{
    public partial class AcoesForm : Form
    {

        private int idAcao = 0;
        private string ticker = "";
        private int idMovimentacao = 0;
        private DBFactory dbFactory = null;


        public AcoesForm()
        {
            InitializeComponent();
            this.textTicker.Select();
            this.dbFactory = DBFactory.create();

            this.reloadAcoesGrid();
        }



        private void buttonNovo_Click(object sender, EventArgs e)
        {
            this.textTicker.ResetText();
            this.textQuantidade.ResetText();
            this.textPrecoMedio.ResetText();

            this.textTicker.Select();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            AcoesDB acoesDB = new Database.AcoesDB();

            if (this.idAcao == null | this.idAcao == 0)
            {
                acoesDB.insertAcao(this.textTicker.Text.ToUpper(), Int32.Parse(this.textQuantidade.Text), Decimal.Parse(this.textPrecoMedio.Text));
            } else
            {
                acoesDB.updateAcao(this.idAcao,  this.textTicker.Text.ToUpper(), Int32.Parse(this.textQuantidade.Text), Decimal.Parse(this.textPrecoMedio.Text));
            }
          
            this.reloadAcoesGrid();

            this.textTicker.ResetText();
            this.textQuantidade.ResetText();
            this.textPrecoMedio.ResetText();

            this.textTicker.Select();

        }


        /**
         * 
         * 
         */
        private void reloadAcoesGrid()
        {
            MySqlConnection con = Database.DB.ConexaoBD();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = " SELECT ID, Ticker, " +
                                  "         quantidade as 'Qtde', " +
                                  "         preco_medio as 'Médio', " + 
                                  "         quantidade * preco_medio as 'Total'" +
                                  " FROM Acoes ORDER BY Ticker";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, con);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            this.dataGridViewAcoes.DataSource = bSource;
            this.dataGridViewAcoes.Rows[0].Selected = true;


            dataGridViewAcoes.Columns["ID"].Width = 50;
            dataGridViewAcoes.Columns["Ticker"].Width = 70;
            dataGridViewAcoes.Columns["Qtde"].Width = 70;
            dataGridViewAcoes.Columns["Médio"].Width = 70;
            dataGridViewAcoes.Columns["Total"].Width = 100;


            Database.DB.closeConnection(con);
        }


        private void textQuantidade_KeyPress(object sender, KeyPressEventArgs e) { Helpers.FieldFormatHelper.onKeyPress_OnlyNumbers(sender, e); }

        private void textPrecoMedio_KeyPress(object sender, KeyPressEventArgs e) { Helpers.FieldFormatHelper.onKeyPress_OnlyDecimal(sender, e); }

        private void AcoesForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'opcoesnetDataSet1.acoes'. Você pode movê-la ou removê-la conforme necessário.
            this.acoesTableAdapter.Fill(this.opcoesnetDataSet1.acoes);

        }



        //------------------------------


        private void dataGridViewAcoes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAcoes.SelectedRows.Count > 0)
            {
                int firstRowIndex = dataGridViewAcoes.SelectedRows.Count - 1;


                var row = dataGridViewAcoes.SelectedRows[0];

                string cellId = row.Cells[0].Value.ToString();
                this.idAcao =  Int32.Parse(cellId);


                string cellTicker = dataGridViewAcoes.SelectedRows[0].Cells[1].Value.ToString();
                this.ticker = cellTicker;

                string cellQuantidade = dataGridViewAcoes.SelectedRows[0].Cells[2].Value.ToString();
                string cellPM = dataGridViewAcoes.SelectedRows[0].Cells[3].Value.ToString();


                this.textTicker.Text = cellTicker;
                this.textQuantidade.Text = cellQuantidade;
                this.textPrecoMedio.Text = cellPM;

                //
                clearMovimentacaoFields(false);
                this.updateMovimentacoesList( Int32.Parse(cellId) );
            }

        }

        private void updateMovimentacoesList(int idAcao)
        {

            MySqlConnection con = Database.DB.ConexaoBD();

            MySqlDataAdapter myDA = new MySqlDataAdapter();
            string sqlSelectAll = " SELECT t1.id as ID, " + 
                                  "        t1.data_registro as 'Dt.Registro', " + 
//                                  "        t2.ticker as 'Ticker', " + 
                                  "        t1.quantidade as 'Qtde', " + 
                                  "        t1.preco as 'Preço', " +
                                  //"       t1.quantidade * t1.preco as 'Total', " + 
                                  "        t1.descricao as 'Descrição'" +
                                  " FROM ACOES_MOVIMENTACOES t1 LEFT OUTER JOIN ACOES t2 ON t1.acoes_id = t2.id" +
                                  " WHERE t2.id = " + idAcao;

            myDA.SelectCommand = new MySqlCommand(sqlSelectAll, con);

            DataTable table = new DataTable();
            myDA.Fill(table);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = table;

            dataGridViewMovimentacoes.DataSource = bindingSource;


            //DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            //uninstallButtonColumn.Name = "uninstall_column";
            //uninstallButtonColumn.Text = "Uninstall";
            //int columnIndex = 2;
            //if (dataGridViewMovimentacoes.Columns["uninstall_column"] == null)
            //{
            //    dataGridViewMovimentacoes.Columns.Insert(columnIndex, uninstallButtonColumn);
            //}


            dataGridViewMovimentacoes.Columns["ID"].Width = 50;

            dataGridViewMovimentacoes.Columns["Qtde"].Width = 70;
            dataGridViewMovimentacoes.Columns["Preço"].Width = 70;
            dataGridViewMovimentacoes.Columns["Descrição"].Width = 420;


            
            Database.DB.closeConnection(con);

        }

        //------------------------------





        //--------------------
        private void buttonNovaMovimentacao_Click(object sender, EventArgs e)
        {
            clearMovimentacaoFields();
        }

        private void clearMovimentacaoFields(bool selecionarQuantidade = true)
        {
            this.labelTicker.Text = this.ticker;
            this.textQuantidadeMovimentacoes.ResetText();
            this.textPrecoMovimentacoes.ResetText();
            this.dateTimeMovimentacao.ResetText();
            this.textDescricaoMovimentacao.ResetText();

            if (selecionarQuantidade) 
                this.textQuantidadeMovimentacoes.Select();

        }

        //------------

        private void buttonSalvarMovimentacao_Click(object sender, EventArgs e)
        {

            //
            long id = this.dbFactory.getAcoesDB().insertMovimentacao(this.idAcao, 
                                                                     Int32.Parse(this.textQuantidadeMovimentacoes.Text), 
                                                                     Decimal.Parse(this.textPrecoMovimentacoes.Text),
                                                                     Helpers.MySQLHelper.convertDateFromBR(this.dateTimeMovimentacao.Text),
                                                                     this.textDescricaoMovimentacao.Text);

            //
            this.updateMovimentacoesList(this.idAcao);

            //
            this.textQuantidadeMovimentacoes.ResetText();
            this.textPrecoMovimentacoes.ResetText();
            this.dateTimeMovimentacao.ResetText();
            this.textDescricaoMovimentacao.ResetText();
            this.textQuantidadeMovimentacoes.Select();


            //
            this.dbFactory.getAcoesDB().atualizarQuantidade(this.idAcao);
            this.reloadAcoesGrid();

        }




        private void textQuantidadeMovimentacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.FieldFormatHelper.onKeyPress_OnlyNumbers(sender, e);
        }

        private void textPrecoMovimentacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.FieldFormatHelper.onKeyPress_OnlyDecimal(sender, e);
        }


        // ----------------
        private void dataGridViewMovimentacoes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewMovimentacoes.SelectedRows.Count > 0)
            {
                int firstRowIndex = dataGridViewMovimentacoes.SelectedRows.Count - 1;

                string cellId = dataGridViewMovimentacoes.SelectedRows[0].Cells[0].Value.ToString();
                this.idMovimentacao = Int32.Parse(cellId);

                string dataRegistro = dataGridViewMovimentacoes.SelectedRows[0].Cells[1].Value.ToString();
                string quantidade = dataGridViewMovimentacoes.SelectedRows[0].Cells[2].Value.ToString();
                string preco = dataGridViewMovimentacoes.SelectedRows[0].Cells[3].Value.ToString();
                string descricao = dataGridViewMovimentacoes.SelectedRows[0].Cells[4].Value.ToString();


                this.dateTimeMovimentacao.Text = dataRegistro;
                this.textQuantidadeMovimentacoes.Text = quantidade;
                this.textPrecoMovimentacoes.Text = preco;
                this.textDescricaoMovimentacao.Text = descricao;

            }


        }

        private void dataGridViewMovimentacoes_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar.ToString().ToUpper() == "D") && (this.dataGridViewMovimentacoes.Rows.Count > 0))
            {

                var confirmResult = MessageBox.Show(this.ticker + " / " + this.textQuantidadeMovimentacoes.Text + " / " + this.textPrecoMovimentacoes.Text + 
                                                    "\n\nMovimentação selecionada será removida. \nVocê Realmente deseja continuar?", 
                                                    "Confirmar Exclusão", 
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // remover registro de movimentação
                    this.dbFactory.getAcoesDB().deleteMovimentacoesById(this.idMovimentacao);



                    // atualizar lista de ativos e de movimentação
                    this.updateMovimentacoesList(this.idAcao);
                    this.reloadAcoesGrid();

                    this.clearMovimentacaoFields();

                    //
                    this.dbFactory.getAcoesDB().atualizarQuantidade(this.idAcao);
                    this.reloadAcoesGrid();
                }

            }

        }

        private void dataGridViewAcoes_KeyPress_1(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar.ToString().ToUpper() == "D")
            {

                var confirmResult = MessageBox.Show(this.ticker + "\n\nPosição e movimentações em " + this.ticker + " será removido. \nVocê Realmente deseja excluir sua posição?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {

                    // remover registro
                    this.dbFactory.getAcoesDB().deleteMovimentacoesByIdAcao(this.idAcao);
                    this.dbFactory.getAcoesDB().deleteAcao(this.idAcao);

                    // atualizar lista de ativos
                    this.reloadAcoesGrid();
                    this.dataGridViewAcoes.Rows[0].Selected = true;

                }

            }

        }

        


        //----------------

    }
}
