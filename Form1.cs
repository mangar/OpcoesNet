using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpcoesNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSobre = new OpcoesNet.Forms.SobreForm();
            formSobre.MdiParent = this;
            formSobre.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void açõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new OpcoesNet.Forms.AcoesForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
