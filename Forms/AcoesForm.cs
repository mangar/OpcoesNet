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
            acoesDB.insertAcao(this.textTicker.Text.ToUpper(), Int32.Parse(this.textQuantidade.Text),  Decimal.Parse(this.textPrecoMedio.Text));

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
            string sqlSelectAll = "SELECT * FROM Acoes";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, con);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;

            this.dataGridView1.Rows[0].Selected = true;

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


        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int firstRowIndex = dataGridView1.SelectedRows.Count - 1;

                string cellId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                this.idAcao =  Int32.Parse(cellId);


                string cellTicker = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                this.ticker = cellTicker;

                string cellQuantidade = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string cellPM = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();


                this.labelTicker.Text = cellTicker;
                this.textTicker.Text = cellTicker;
                this.textQuantidade.Text = cellQuantidade;
                this.textPrecoMedio.Text = cellPM;



                //MessageBox.Show("ID:" + cellId + " Ticker: " + cellTicker);

                this.updateMovimentacoesList( Int32.Parse(cellId) );
            }

        }

        private void updateMovimentacoesList(int idAcao)
        {

            MySqlConnection con = Database.DB.ConexaoBD();

            MySqlDataAdapter myDA = new MySqlDataAdapter();
            string sqlSelectAll = " SELECT t1.id as ID, " + 
                                  "        t1.data_registro as 'Dt.Registro', " + 
                                  "        t2.ticker as 'Ticker', " + 
                                  "        t1.quantidade as 'Qtde', t1.preco as 'Preço', t1.quantidade * t1.preco as 'Total', " + 
                                  "        t1.descricao as 'Descrição'" +
                                  " FROM ACOES_MOVIMENTACOES t1 LEFT OUTER JOIN ACOES t2 ON t1.acoes_id = t2.id" +
                                  " WHERE t2.id = " + idAcao;

            myDA.SelectCommand = new MySqlCommand(sqlSelectAll, con);

            DataTable table = new DataTable();
            myDA.Fill(table);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = table;

            dataGridViewMovimentacoes.DataSource = bindingSource;


            //dataGridViewMovimentacoes.Columns[0].Name = "ID";
            //dataGridViewMovimentacoes.Columns[1].Name = "Dt. Registro";
            //dataGridViewMovimentacoes.Columns[2].Name = "TICKER";
            //dataGridViewMovimentacoes.Columns[3].Name = "Qtde.";
            //dataGridViewMovimentacoes.Columns[4].Name = "Preço";
            //dataGridViewMovimentacoes.Columns[5].Name = "Descrição";



            //DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            //uninstallButtonColumn.Name = "uninstall_column";
            //uninstallButtonColumn.Text = "Uninstall";
            //int columnIndex = 2;
            //if (dataGridViewMovimentacoes.Columns["uninstall_column"] == null)
            //{
            //    dataGridViewMovimentacoes.Columns.Insert(columnIndex, uninstallButtonColumn);
            //}


            Database.DB.closeConnection(con);

        }

        //------------------------------





        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonNovaMovimentacao_Click(object sender, EventArgs e)
        {
            this.textQuantidadeMovimentacoes.ResetText();
            this.textPrecoMovimentacoes.ResetText();
            this.textDataMovimentacao.ResetText();
            this.textDescricaoMovimentacao.ResetText();
            this.textQuantidadeMovimentacoes.Select();
        }

        private void buttonSalvarMovimentacao_Click(object sender, EventArgs e)
        {

            //
            long id = this.dbFactory.getAcoesDB().insertMovimentacao(this.idAcao, 
                                                                     Int32.Parse(this.textQuantidadeMovimentacoes.Text), 
                                                                     Decimal.Parse(this.textPrecoMovimentacoes.Text), 
                                                                     this.textDataMovimentacao.Text, 
                                                                     this.textDescricaoMovimentacao.Text);

            //
            this.updateMovimentacoesList(this.idAcao);

            //
            this.textQuantidadeMovimentacoes.ResetText();
            this.textPrecoMovimentacoes.ResetText();
            this.textDataMovimentacao.ResetText();
            this.textDescricaoMovimentacao.ResetText();
            this.textQuantidadeMovimentacoes.Select();

        }

        private void buttonRemoverMovimentacao_Click(object sender, EventArgs e)
        {

        }



        private void textQuantidadeMovimentacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.FieldFormatHelper.onKeyPress_OnlyNumbers(sender, e);
        }

        private void textPrecoMovimentacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.FieldFormatHelper.onKeyPress_OnlyDecimal(sender, e);
        }


        //----------------

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
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
                    this.dataGridView1.Rows[0].Selected = true;

                }

            }



        }





        //----------------

    }
}
