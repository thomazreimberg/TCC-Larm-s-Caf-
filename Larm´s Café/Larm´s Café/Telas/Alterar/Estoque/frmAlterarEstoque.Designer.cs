namespace Larm_s_Café.Telas.Alterar.Estoque
{
    partial class frmAlterarEstoque
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEspecificacao = new System.Windows.Forms.TextBox();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkUrgenteAlterar = new System.Windows.Forms.CheckBox();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.chkAbastecerAlterar = new System.Windows.Forms.CheckBox();
            this.chkAbastecer = new System.Windows.Forms.CheckBox();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.id_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_materia_prima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_situacao_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_especificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_abastecer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_urgente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_validade_prevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.nudQuantidade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSituacao);
            this.groupBox1.Controls.Add(this.cboProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEspecificacao);
            this.groupBox1.Controls.Add(this.dtpVencimento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.chkUrgenteAlterar);
            this.groupBox1.Controls.Add(this.nudTotal);
            this.groupBox1.Controls.Add(this.chkAbastecerAlterar);
            this.groupBox1.Controls.Add(this.chkAbastecer);
            this.groupBox1.Controls.Add(this.chkUrgente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dgvEstoque);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 607);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(360, 99);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(142, 20);
            this.nudQuantidade.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(276, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Qtd. produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(302, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 108;
            this.label6.Text = "Produto:";
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(360, 125);
            this.txtSituacao.Multiline = true;
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(142, 30);
            this.txtSituacao.TabIndex = 97;
            // 
            // cboProduto
            // 
            this.cboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(360, 63);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(142, 21);
            this.cboProduto.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(296, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "Situação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(525, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "Vencimento:";
            // 
            // txtEspecificacao
            // 
            this.txtEspecificacao.Location = new System.Drawing.Point(360, 166);
            this.txtEspecificacao.Multiline = true;
            this.txtEspecificacao.Name = "txtEspecificacao";
            this.txtEspecificacao.Size = new System.Drawing.Size(142, 30);
            this.txtEspecificacao.TabIndex = 99;
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(528, 89);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(97, 20);
            this.dtpVencimento.TabIndex = 105;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(268, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "Especificação:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(288, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 104;
            this.label11.Text = "Total:";
            // 
            // chkUrgenteAlterar
            // 
            this.chkUrgenteAlterar.AutoSize = true;
            this.chkUrgenteAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUrgenteAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkUrgenteAlterar.Location = new System.Drawing.Point(541, 138);
            this.chkUrgenteAlterar.Name = "chkUrgenteAlterar";
            this.chkUrgenteAlterar.Size = new System.Drawing.Size(71, 17);
            this.chkUrgenteAlterar.TabIndex = 101;
            this.chkUrgenteAlterar.Text = "Urgente";
            this.chkUrgenteAlterar.UseVisualStyleBackColor = true;
            // 
            // nudTotal
            // 
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Location = new System.Drawing.Point(360, 214);
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.Size = new System.Drawing.Size(142, 20);
            this.nudTotal.TabIndex = 103;
            // 
            // chkAbastecerAlterar
            // 
            this.chkAbastecerAlterar.AutoSize = true;
            this.chkAbastecerAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAbastecerAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkAbastecerAlterar.Location = new System.Drawing.Point(541, 161);
            this.chkAbastecerAlterar.Name = "chkAbastecerAlterar";
            this.chkAbastecerAlterar.Size = new System.Drawing.Size(83, 17);
            this.chkAbastecerAlterar.TabIndex = 102;
            this.chkAbastecerAlterar.Text = "Abastecer";
            this.chkAbastecerAlterar.UseVisualStyleBackColor = true;
            // 
            // chkAbastecer
            // 
            this.chkAbastecer.AutoSize = true;
            this.chkAbastecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAbastecer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkAbastecer.Location = new System.Drawing.Point(154, 138);
            this.chkAbastecer.Name = "chkAbastecer";
            this.chkAbastecer.Size = new System.Drawing.Size(83, 17);
            this.chkAbastecer.TabIndex = 94;
            this.chkAbastecer.Text = "Abastecer";
            this.chkAbastecer.UseVisualStyleBackColor = true;
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUrgente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkUrgente.Location = new System.Drawing.Point(64, 138);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(71, 17);
            this.chkUrgente.TabIndex = 93;
            this.chkUrgente.Text = "Urgente";
            this.chkUrgente.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(241, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 23);
            this.label7.TabIndex = 92;
            this.label7.Text = "Comprar Estoque";
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_estoque,
            this.id_materia_prima,
            this.nm_produto,
            this.vl_preco,
            this.ds_categoria,
            this.qt_estoque,
            this.ds_situacao_produto,
            this.ds_especificacao,
            this.bt_abastecer,
            this.bt_urgente,
            this.dt_validade_prevista,
            this.vl_total});
            this.dgvEstoque.Location = new System.Drawing.Point(6, 320);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.Size = new System.Drawing.Size(631, 188);
            this.dgvEstoque.TabIndex = 0;
            this.dgvEstoque.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEstoque_RowHeaderMouseDoubleClick);
            // 
            // id_estoque
            // 
            this.id_estoque.DataPropertyName = "id_estoque";
            this.id_estoque.HeaderText = "ID";
            this.id_estoque.Name = "id_estoque";
            this.id_estoque.ReadOnly = true;
            // 
            // id_materia_prima
            // 
            this.id_materia_prima.DataPropertyName = "id_materia_prima";
            this.id_materia_prima.HeaderText = "ID Produto";
            this.id_materia_prima.Name = "id_materia_prima";
            this.id_materia_prima.ReadOnly = true;
            // 
            // nm_produto
            // 
            this.nm_produto.DataPropertyName = "nm_produto";
            this.nm_produto.HeaderText = "Produto";
            this.nm_produto.Name = "nm_produto";
            this.nm_produto.ReadOnly = true;
            // 
            // vl_preco
            // 
            this.vl_preco.DataPropertyName = "vl_preco";
            this.vl_preco.HeaderText = "Preço";
            this.vl_preco.Name = "vl_preco";
            this.vl_preco.ReadOnly = true;
            // 
            // ds_categoria
            // 
            this.ds_categoria.DataPropertyName = "ds_categoria";
            this.ds_categoria.HeaderText = "Categoria";
            this.ds_categoria.Name = "ds_categoria";
            this.ds_categoria.ReadOnly = true;
            // 
            // qt_estoque
            // 
            this.qt_estoque.DataPropertyName = "qt_estoque";
            this.qt_estoque.HeaderText = "Quantidade";
            this.qt_estoque.Name = "qt_estoque";
            this.qt_estoque.ReadOnly = true;
            // 
            // ds_situacao_produto
            // 
            this.ds_situacao_produto.DataPropertyName = "ds_situacao_produto";
            this.ds_situacao_produto.HeaderText = "Situação do Produto";
            this.ds_situacao_produto.Name = "ds_situacao_produto";
            this.ds_situacao_produto.ReadOnly = true;
            // 
            // ds_especificacao
            // 
            this.ds_especificacao.DataPropertyName = "ds_especificacao";
            this.ds_especificacao.HeaderText = "Especificação";
            this.ds_especificacao.Name = "ds_especificacao";
            this.ds_especificacao.ReadOnly = true;
            // 
            // bt_abastecer
            // 
            this.bt_abastecer.DataPropertyName = "bt_abastecer";
            this.bt_abastecer.HeaderText = "Abastecer";
            this.bt_abastecer.Name = "bt_abastecer";
            this.bt_abastecer.ReadOnly = true;
            // 
            // bt_urgente
            // 
            this.bt_urgente.DataPropertyName = "bt_urgente";
            this.bt_urgente.HeaderText = "Urgente";
            this.bt_urgente.Name = "bt_urgente";
            this.bt_urgente.ReadOnly = true;
            // 
            // dt_validade_prevista
            // 
            this.dt_validade_prevista.DataPropertyName = "dt_validade_prevista";
            this.dt_validade_prevista.HeaderText = "Validade Prevista";
            this.dt_validade_prevista.Name = "dt_validade_prevista";
            this.dt_validade_prevista.ReadOnly = true;
            // 
            // vl_total
            // 
            this.vl_total.DataPropertyName = "vl_total";
            this.vl_total.HeaderText = "Total";
            this.vl_total.Name = "vl_total";
            this.vl_total.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Produto:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(92, 90);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(158, 21);
            this.cboCategoria.TabIndex = 88;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.Location = new System.Drawing.Point(92, 182);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 30);
            this.btnBuscar.TabIndex = 89;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Categoria:";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(92, 64);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(158, 20);
            this.txtProduto.TabIndex = 85;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-18, -42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 220);
            this.panel1.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(658, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(638, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = "__";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(396, 262);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(138, 30);
            this.btnAlterar.TabIndex = 109;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmAlterarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(667, 552);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlterarEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarEstoque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_materia_prima;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_situacao_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_especificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn bt_abastecer;
        private System.Windows.Forms.DataGridViewTextBoxColumn bt_urgente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_validade_prevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkAbastecer;
        private System.Windows.Forms.CheckBox chkUrgente;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEspecificacao;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkUrgenteAlterar;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.CheckBox chkAbastecerAlterar;
        private System.Windows.Forms.Button btnAlterar;
    }
}