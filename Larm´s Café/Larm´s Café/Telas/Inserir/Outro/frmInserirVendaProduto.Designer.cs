namespace Larm_s_Café.Telas.Inserir.Outro
{
    partial class frmInserirVendaProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblFechar = new System.Windows.Forms.Label();
            this.LblMinimizar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.nudTroco = new System.Windows.Forms.NumericUpDown();
            this.dgvListaDeProdutos = new System.Windows.Forms.DataGridView();
            this.id_produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qt_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudValorPago = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.nudTotalProduto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalProduto = new System.Windows.Forms.Label();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.dtpDataDeVenda = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpHorarioDeVenda = new System.Windows.Forms.DateTimePicker();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboModoDePagamento = new System.Windows.Forms.ComboBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nudParcelas = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTroco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.LblFechar);
            this.panel1.Controls.Add(this.LblMinimizar);
            this.panel1.Location = new System.Drawing.Point(-11, -13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 366);
            this.panel1.TabIndex = 150;
            // 
            // LblFechar
            // 
            this.LblFechar.AutoSize = true;
            this.LblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechar.ForeColor = System.Drawing.Color.White;
            this.LblFechar.Location = new System.Drawing.Point(874, 22);
            this.LblFechar.Name = "LblFechar";
            this.LblFechar.Size = new System.Drawing.Size(15, 13);
            this.LblFechar.TabIndex = 25;
            this.LblFechar.Text = "X";
            this.LblFechar.Click += new System.EventHandler(this.LblFechar_Click_1);
            // 
            // LblMinimizar
            // 
            this.LblMinimizar.AutoSize = true;
            this.LblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinimizar.ForeColor = System.Drawing.Color.White;
            this.LblMinimizar.Location = new System.Drawing.Point(851, 13);
            this.LblMinimizar.Name = "LblMinimizar";
            this.LblMinimizar.Size = new System.Drawing.Size(20, 25);
            this.LblMinimizar.TabIndex = 26;
            this.LblMinimizar.Text = "-";
            this.LblMinimizar.Click += new System.EventHandler(this.LblMinimizar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cboProduto);
            this.groupBox1.Controls.Add(this.nudTroco);
            this.groupBox1.Controls.Add(this.dgvListaDeProdutos);
            this.groupBox1.Controls.Add(this.nudTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudValorPago);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Controls.Add(this.nudTotalProduto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTotalProduto);
            this.groupBox1.Controls.Add(this.nudPreco);
            this.groupBox1.Controls.Add(this.nudQuantidade);
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.dtpDataDeVenda);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpHorarioDeVenda);
            this.groupBox1.Controls.Add(this.cboFuncionario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboModoDePagamento);
            this.groupBox1.Controls.Add(this.lblTroco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.nudParcelas);
            this.groupBox1.Location = new System.Drawing.Point(21, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 952);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(253, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(368, 40);
            this.label15.TabIndex = 149;
            this.label15.Text = "Inserir Venda do Produto";
            // 
            // cboProduto
            // 
            this.cboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(124, 81);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(158, 21);
            this.cboProduto.TabIndex = 69;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.cboProduto_SelectedIndexChanged);
            // 
            // nudTroco
            // 
            this.nudTroco.DecimalPlaces = 2;
            this.nudTroco.Enabled = false;
            this.nudTroco.Location = new System.Drawing.Point(612, 603);
            this.nudTroco.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudTroco.Name = "nudTroco";
            this.nudTroco.Size = new System.Drawing.Size(158, 20);
            this.nudTroco.TabIndex = 91;
            // 
            // dgvListaDeProdutos
            // 
            this.dgvListaDeProdutos.AllowUserToAddRows = false;
            this.dgvListaDeProdutos.AllowUserToDeleteRows = false;
            this.dgvListaDeProdutos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListaDeProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produtos,
            this.nm_produto,
            this.vl_preco,
            this.ds_categoria,
            this.ds_observacao,
            this.qt_produto,
            this.vl_total});
            this.dgvListaDeProdutos.Location = new System.Drawing.Point(6, 376);
            this.dgvListaDeProdutos.Name = "dgvListaDeProdutos";
            this.dgvListaDeProdutos.ReadOnly = true;
            this.dgvListaDeProdutos.Size = new System.Drawing.Size(449, 453);
            this.dgvListaDeProdutos.TabIndex = 0;
            // 
            // id_produtos
            // 
            this.id_produtos.DataPropertyName = "id_produtos";
            this.id_produtos.HeaderText = "ID";
            this.id_produtos.Name = "id_produtos";
            this.id_produtos.ReadOnly = true;
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
            // ds_observacao
            // 
            this.ds_observacao.DataPropertyName = "ds_observacao";
            this.ds_observacao.HeaderText = "Observação";
            this.ds_observacao.Name = "ds_observacao";
            this.ds_observacao.ReadOnly = true;
            // 
            // qt_produto
            // 
            this.qt_produto.DataPropertyName = "qt_produto";
            this.qt_produto.HeaderText = "Quantidade";
            this.qt_produto.Name = "qt_produto";
            this.qt_produto.ReadOnly = true;
            // 
            // vl_total
            // 
            this.vl_total.DataPropertyName = "vl_total";
            this.vl_total.HeaderText = "Total";
            this.vl_total.Name = "vl_total";
            this.vl_total.ReadOnly = true;
            // 
            // nudTotal
            // 
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Enabled = false;
            this.nudTotal.Location = new System.Drawing.Point(612, 555);
            this.nudTotal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.Size = new System.Drawing.Size(158, 20);
            this.nudTotal.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(61, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Produto:";
            // 
            // nudValorPago
            // 
            this.nudValorPago.DecimalPlaces = 2;
            this.nudValorPago.Location = new System.Drawing.Point(612, 505);
            this.nudValorPago.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudValorPago.Name = "nudValorPago";
            this.nudValorPago.Size = new System.Drawing.Size(158, 20);
            this.nudValorPago.TabIndex = 89;
            this.nudValorPago.ValueChanged += new System.EventHandler(this.nudValorPago_ValueChanged);
            this.nudValorPago.Leave += new System.EventHandler(this.nudValorPago_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(51, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Categoria:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(534, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Valor pago:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.Enabled = false;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(124, 121);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(158, 21);
            this.cboCategoria.TabIndex = 64;
            // 
            // nudTotalProduto
            // 
            this.nudTotalProduto.DecimalPlaces = 2;
            this.nudTotalProduto.Enabled = false;
            this.nudTotalProduto.Location = new System.Drawing.Point(393, 297);
            this.nudTotalProduto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTotalProduto.Name = "nudTotalProduto";
            this.nudTotalProduto.Size = new System.Drawing.Size(101, 20);
            this.nudTotalProduto.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(72, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Preço:";
            // 
            // lblTotalProduto
            // 
            this.lblTotalProduto.AutoSize = true;
            this.lblTotalProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalProduto.Location = new System.Drawing.Point(309, 299);
            this.lblTotalProduto.Name = "lblTotalProduto";
            this.lblTotalProduto.Size = new System.Drawing.Size(87, 13);
            this.lblTotalProduto.TabIndex = 86;
            this.lblTotalProduto.Text = "Total produto:";
            // 
            // nudPreco
            // 
            this.nudPreco.DecimalPlaces = 2;
            this.nudPreco.Enabled = false;
            this.nudPreco.Location = new System.Drawing.Point(124, 158);
            this.nudPreco.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(158, 20);
            this.nudPreco.TabIndex = 66;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(124, 227);
            this.nudQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(158, 20);
            this.nudQuantidade.TabIndex = 85;
            this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Location = new System.Drawing.Point(124, 196);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(158, 20);
            this.txtObservacao.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(40, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(37, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Observacao:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.White;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFinalizar.Location = new System.Drawing.Point(604, 227);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(180, 53);
            this.btnFinalizar.TabIndex = 83;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionar.Location = new System.Drawing.Point(138, 283);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(124, 45);
            this.btnAdicionar.TabIndex = 70;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(612, 708);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(158, 21);
            this.cboCliente.TabIndex = 82;
            // 
            // dtpDataDeVenda
            // 
            this.dtpDataDeVenda.Enabled = false;
            this.dtpDataDeVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeVenda.Location = new System.Drawing.Point(7, 350);
            this.dtpDataDeVenda.Name = "dtpDataDeVenda";
            this.dtpDataDeVenda.Size = new System.Drawing.Size(79, 20);
            this.dtpDataDeVenda.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(556, 711);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Cliente:";
            // 
            // dtpHorarioDeVenda
            // 
            this.dtpHorarioDeVenda.Enabled = false;
            this.dtpHorarioDeVenda.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioDeVenda.Location = new System.Drawing.Point(92, 350);
            this.dtpHorarioDeVenda.Name = "dtpHorarioDeVenda";
            this.dtpHorarioDeVenda.Size = new System.Drawing.Size(79, 20);
            this.dtpHorarioDeVenda.TabIndex = 72;
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(612, 653);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(158, 21);
            this.cboFuncionario.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(479, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Modo de Pagamento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(541, 656);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Vendedor:";
            // 
            // cboModoDePagamento
            // 
            this.cboModoDePagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModoDePagamento.FormattingEnabled = true;
            this.cboModoDePagamento.Items.AddRange(new object[] {
            "Cartão",
            "Dinheiro"});
            this.cboModoDePagamento.Location = new System.Drawing.Point(612, 399);
            this.cboModoDePagamento.Name = "cboModoDePagamento";
            this.cboModoDePagamento.Size = new System.Drawing.Size(158, 21);
            this.cboModoDePagamento.TabIndex = 74;
            this.cboModoDePagamento.SelectedIndexChanged += new System.EventHandler(this.cboModoDePagamento_SelectedIndexChanged);
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTroco.Location = new System.Drawing.Point(562, 605);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(44, 13);
            this.lblTroco.TabIndex = 78;
            this.lblTroco.Text = "Troco:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(546, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Parcelas:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(566, 557);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 77;
            this.lblTotal.Text = "Total:";
            // 
            // nudParcelas
            // 
            this.nudParcelas.Location = new System.Drawing.Point(612, 451);
            this.nudParcelas.Name = "nudParcelas";
            this.nudParcelas.Size = new System.Drawing.Size(158, 20);
            this.nudParcelas.TabIndex = 76;
            // 
            // frmInserirVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 876);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInserirVendaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInserirVendaProduto";
            this.Load += new System.EventHandler(this.frmInserirVendaProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTroco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblFechar;
        private System.Windows.Forms.Label LblMinimizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn qt_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produtos;
        private System.Windows.Forms.DataGridView dgvListaDeProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DateTimePicker dtpDataDeVenda;
        private System.Windows.Forms.DateTimePicker dtpHorarioDeVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboModoDePagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudParcelas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label lblTotalProduto;
        private System.Windows.Forms.NumericUpDown nudTotalProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudValorPago;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.NumericUpDown nudTroco;
        private System.Windows.Forms.Label label15;
    }
}