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
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            Database.DB.ConexaoBD();

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            AcoesDB acoesDB = new Database.AcoesDB();
            acoesDB.insertAcao(this.textTicker.Text.ToUpper(), Int32.Parse(this.textQuantidade.Text),  Decimal.Parse(this.textPrecoMedio.Text));
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
    }
}
