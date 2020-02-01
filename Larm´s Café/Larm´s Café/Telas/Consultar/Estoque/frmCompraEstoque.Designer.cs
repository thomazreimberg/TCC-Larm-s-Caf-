namespace Larm_s_Café.Telas.Consultar.Estoque
{
    partial class frmCompraEstoque
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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.chkAbastecer = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvEstoque.Location = new System.Drawing.Point(6, 206);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.Size = new System.Drawing.Size(510, 180);
            this.dgvEstoque.TabIndex = 0;
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
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(129, 81);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(158, 20);
            this.txtProduto.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(68, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(60, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(129, 107);
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
            this.btnBuscar.Location = new System.Drawing.Point(217, 157);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 30);
            this.btnBuscar.TabIndex = 89;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUrgente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkUrgente.Location = new System.Drawing.Point(353, 83);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(71, 17);
            this.chkUrgente.TabIndex = 90;
            this.chkUrgente.Text = "Urgente";
            this.chkUrgente.UseVisualStyleBackColor = true;
            // 
            // chkAbastecer
            // 
            this.chkAbastecer.AutoSize = true;
            this.chkAbastecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAbastecer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkAbastecer.Location = new System.Drawing.Point(353, 105);
            this.chkAbastecer.Name = "chkAbastecer";
            this.chkAbastecer.Size = new System.Drawing.Size(83, 17);
            this.chkAbastecer.TabIndex = 91;
            this.chkAbastecer.Text = "Abastecer";
            this.chkAbastecer.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(179, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 23);
            this.label7.TabIndex = 92;
            this.label7.Text = "Comprar Estoque";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(555, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(535, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = "__";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-28, -39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 220);
            this.panel1.TabIndex = 95;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dgvEstoque);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.chkAbastecer);
            this.groupBox1.Controls.Add(this.chkUrgente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 607);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            // 
            // frmCompraEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompraEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompraEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkUrgente;
        private System.Windows.Forms.CheckBox chkAbastecer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}