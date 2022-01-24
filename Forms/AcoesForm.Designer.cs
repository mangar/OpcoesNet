namespace OpcoesNet.Forms
{
    partial class AcoesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.acoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opcoesnetDataSet1 = new OpcoesNet.opcoesnetDataSet1();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textPrecoMedio = new System.Windows.Forms.TextBox();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.textTicker = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textDescricaoMovimentacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTicker = new System.Windows.Forms.Label();
            this.textPrecoMovimentacoes = new System.Windows.Forms.TextBox();
            this.textQuantidadeMovimentacoes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonNovaMovimentacao = new System.Windows.Forms.Button();
            this.buttonSalvarMovimentacao = new System.Windows.Forms.Button();
            this.dataGridViewMovimentacoes = new System.Windows.Forms.DataGridView();
            this.opcoesnetDataSet = new OpcoesNet.opcoesnetDataSet();
            this.opcoesnetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.acoesTableAdapter = new OpcoesNet.opcoesnetDataSet1TableAdapters.acoesTableAdapter();
            this.dateTimeMovimentacao = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewAcoes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcoesnetDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimentacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcoesnetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcoesnetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcoes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAcoes);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(517, 854);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ativos";
            // 
            // acoesBindingSource
            // 
            this.acoesBindingSource.DataMember = "acoes";
            this.acoesBindingSource.DataSource = this.opcoesnetDataSet1;
            // 
            // opcoesnetDataSet1
            // 
            this.opcoesnetDataSet1.DataSetName = "opcoesnetDataSet1";
            this.opcoesnetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.textPrecoMedio);
            this.groupBox3.Controls.Add(this.textQuantidade);
            this.groupBox3.Controls.Add(this.textTicker);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(7, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 123);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonNovo);
            this.groupBox4.Controls.Add(this.buttonSalvar);
            this.groupBox4.Location = new System.Drawing.Point(9, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 57);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Image = global::OpcoesNet.Properties.Resources.new2;
            this.buttonNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovo.Location = new System.Drawing.Point(19, 17);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(220, 30);
            this.buttonNovo.TabIndex = 61;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Image = global::OpcoesNet.Properties.Resources.save;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(245, 17);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(220, 30);
            this.buttonSalvar.TabIndex = 62;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textPrecoMedio
            // 
            this.textPrecoMedio.Location = new System.Drawing.Point(394, 26);
            this.textPrecoMedio.Name = "textPrecoMedio";
            this.textPrecoMedio.Size = new System.Drawing.Size(100, 22);
            this.textPrecoMedio.TabIndex = 40;
            this.textPrecoMedio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecoMedio_KeyPress);
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(216, 26);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(72, 22);
            this.textQuantidade.TabIndex = 30;
            this.textQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textQuantidade_KeyPress);
            // 
            // textTicker
            // 
            this.textTicker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textTicker.Location = new System.Drawing.Point(58, 26);
            this.textTicker.Name = "textTicker";
            this.textTicker.Size = new System.Drawing.Size(100, 22);
            this.textTicker.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Qtde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "R$ Médio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticker:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.dataGridViewMovimentacoes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(541, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(813, 854);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimentações";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(7, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(794, 122);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dateTimeMovimentacao);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.textDescricaoMovimentacao);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.labelTicker);
            this.groupBox7.Controls.Add(this.textPrecoMovimentacoes);
            this.groupBox7.Controls.Add(this.textQuantidadeMovimentacoes);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(6, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(618, 100);
            this.groupBox7.TabIndex = 69;
            this.groupBox7.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 83;
            this.label8.Text = "Data:";
            // 
            // textDescricaoMovimentacao
            // 
            this.textDescricaoMovimentacao.Location = new System.Drawing.Point(100, 50);
            this.textDescricaoMovimentacao.Multiline = true;
            this.textDescricaoMovimentacao.Name = "textDescricaoMovimentacao";
            this.textDescricaoMovimentacao.Size = new System.Drawing.Size(512, 39);
            this.textDescricaoMovimentacao.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 81;
            this.label7.Text = "Descrição: ";
            // 
            // labelTicker
            // 
            this.labelTicker.AutoSize = true;
            this.labelTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicker.Location = new System.Drawing.Point(70, 24);
            this.labelTicker.Name = "labelTicker";
            this.labelTicker.Size = new System.Drawing.Size(58, 16);
            this.labelTicker.TabIndex = 73;
            this.labelTicker.Text = "MGLU3";
            // 
            // textPrecoMovimentacoes
            // 
            this.textPrecoMovimentacoes.Location = new System.Drawing.Point(334, 21);
            this.textPrecoMovimentacoes.Name = "textPrecoMovimentacoes";
            this.textPrecoMovimentacoes.Size = new System.Drawing.Size(83, 22);
            this.textPrecoMovimentacoes.TabIndex = 80;
            this.textPrecoMovimentacoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecoMovimentacoes_KeyPress);
            // 
            // textQuantidadeMovimentacoes
            // 
            this.textQuantidadeMovimentacoes.Location = new System.Drawing.Point(178, 21);
            this.textQuantidadeMovimentacoes.Name = "textQuantidadeMovimentacoes";
            this.textQuantidadeMovimentacoes.Size = new System.Drawing.Size(57, 22);
            this.textQuantidadeMovimentacoes.TabIndex = 70;
            this.textQuantidadeMovimentacoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textQuantidadeMovimentacoes_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "Qtde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Preço :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Ticker:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonNovaMovimentacao);
            this.groupBox6.Controls.Add(this.buttonSalvarMovimentacao);
            this.groupBox6.Location = new System.Drawing.Point(630, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(152, 100);
            this.groupBox6.TabIndex = 68;
            this.groupBox6.TabStop = false;
            // 
            // buttonNovaMovimentacao
            // 
            this.buttonNovaMovimentacao.Image = global::OpcoesNet.Properties.Resources.new2;
            this.buttonNovaMovimentacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovaMovimentacao.Location = new System.Drawing.Point(16, 18);
            this.buttonNovaMovimentacao.Name = "buttonNovaMovimentacao";
            this.buttonNovaMovimentacao.Size = new System.Drawing.Size(130, 30);
            this.buttonNovaMovimentacao.TabIndex = 90;
            this.buttonNovaMovimentacao.Text = "Novo";
            this.buttonNovaMovimentacao.UseVisualStyleBackColor = true;
            this.buttonNovaMovimentacao.Click += new System.EventHandler(this.buttonNovaMovimentacao_Click);
            // 
            // buttonSalvarMovimentacao
            // 
            this.buttonSalvarMovimentacao.Image = global::OpcoesNet.Properties.Resources.save;
            this.buttonSalvarMovimentacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvarMovimentacao.Location = new System.Drawing.Point(16, 59);
            this.buttonSalvarMovimentacao.Name = "buttonSalvarMovimentacao";
            this.buttonSalvarMovimentacao.Size = new System.Drawing.Size(130, 30);
            this.buttonSalvarMovimentacao.TabIndex = 98;
            this.buttonSalvarMovimentacao.Text = "Salvar";
            this.buttonSalvarMovimentacao.UseVisualStyleBackColor = true;
            this.buttonSalvarMovimentacao.Click += new System.EventHandler(this.buttonSalvarMovimentacao_Click);
            // 
            // dataGridViewMovimentacoes
            // 
            this.dataGridViewMovimentacoes.AllowUserToAddRows = false;
            this.dataGridViewMovimentacoes.AllowUserToDeleteRows = false;
            this.dataGridViewMovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovimentacoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewMovimentacoes.Location = new System.Drawing.Point(7, 151);
            this.dataGridViewMovimentacoes.MultiSelect = false;
            this.dataGridViewMovimentacoes.Name = "dataGridViewMovimentacoes";
            this.dataGridViewMovimentacoes.ReadOnly = true;
            this.dataGridViewMovimentacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovimentacoes.Size = new System.Drawing.Size(794, 696);
            this.dataGridViewMovimentacoes.TabIndex = 0;
            this.dataGridViewMovimentacoes.TabStop = false;
            this.dataGridViewMovimentacoes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovimentacoes_RowEnter);
            this.dataGridViewMovimentacoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewMovimentacoes_KeyPress);
            // 
            // opcoesnetDataSet
            // 
            this.opcoesnetDataSet.DataSetName = "opcoesnetDataSet";
            this.opcoesnetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opcoesnetDataSetBindingSource
            // 
            this.opcoesnetDataSetBindingSource.DataSource = this.opcoesnetDataSet;
            this.opcoesnetDataSetBindingSource.Position = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.opcoesnetDataSetBindingSource;
            this.bindingSource1.Position = 0;
            // 
            // acoesTableAdapter
            // 
            this.acoesTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimeMovimentacao
            // 
            this.dateTimeMovimentacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeMovimentacao.Location = new System.Drawing.Point(493, 21);
            this.dateTimeMovimentacao.Name = "dateTimeMovimentacao";
            this.dateTimeMovimentacao.Size = new System.Drawing.Size(119, 22);
            this.dateTimeMovimentacao.TabIndex = 90;
            // 
            // dataGridViewAcoes
            // 
            this.dataGridViewAcoes.AllowUserToAddRows = false;
            this.dataGridViewAcoes.AllowUserToDeleteRows = false;
            this.dataGridViewAcoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAcoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewAcoes.Location = new System.Drawing.Point(7, 151);
            this.dataGridViewAcoes.MultiSelect = false;
            this.dataGridViewAcoes.Name = "dataGridViewAcoes";
            this.dataGridViewAcoes.ReadOnly = true;
            this.dataGridViewAcoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAcoes.Size = new System.Drawing.Size(503, 696);
            this.dataGridViewAcoes.TabIndex = 0;
            this.dataGridViewAcoes.TabStop = false;
            this.dataGridViewAcoes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAcoes_RowEnter);
            this.dataGridViewAcoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewAcoes_KeyPress_1);
            // 
            // AcoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 872);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcoesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ações";
            this.Load += new System.EventHandler(this.AcoesForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcoesnetDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimentacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcoesnetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcoesnetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource opcoesnetDataSetBindingSource;
        private opcoesnetDataSet opcoesnetDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPrecoMedio;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.TextBox textTicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private opcoesnetDataSet1 opcoesnetDataSet1;
        private System.Windows.Forms.BindingSource acoesBindingSource;
        private opcoesnetDataSet1TableAdapters.acoesTableAdapter acoesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridViewMovimentacoes;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textPrecoMovimentacoes;
        private System.Windows.Forms.TextBox textQuantidadeMovimentacoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonNovaMovimentacao;
        private System.Windows.Forms.Button buttonSalvarMovimentacao;
        private System.Windows.Forms.Label labelTicker;
        private System.Windows.Forms.TextBox textDescricaoMovimentacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeMovimentacao;
        private System.Windows.Forms.DataGridView dataGridViewAcoes;
    }
}