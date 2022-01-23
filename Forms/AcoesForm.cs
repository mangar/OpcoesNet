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
        public AcoesForm()
        {
            InitializeComponent();
            this.textTicker.Select();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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


            Database.DB.closeConnection(con);
        }


        private void textQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textPrecoMedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void AcoesForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'opcoesnetDataSet1.acoes'. Você pode movê-la ou removê-la conforme necessário.
            this.acoesTableAdapter.Fill(this.opcoesnetDataSet1.acoes);

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int firstRowIndex = dataGridView1.SelectedRows.Count - 1;

                string cellId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string cellTicker = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                MessageBox.Show("ID:" + cellId + " Ticker: " + cellTicker);

                //                string cellTicker = dataGridView1.SelectedRows[firstRowIndex].Cells[0].Value.ToString();
                //MessageBox.Show("Last selected row at cell[0] value: " + cell + " First Selected row at cell[0] value: " + cell2);
            }

        }
    }
}
