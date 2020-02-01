namespace Larm_s_Café.Telas.Consultar.Estoque
{
    partial class frmConsultarProduto
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.id_produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFiltrar.Location = new System.Drawing.Point(297, 73);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(104, 36);
            this.btnFiltrar.TabIndex = 92;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produtos,
            this.nm_produto,
            this.vl_preco,
            this.ds_categoria,
            this.ds_observacao});
            this.dgvProduto.Location = new System.Drawing.Point(6, 178);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.Size = new System.Drawing.Size(436, 171);
            this.dgvProduto.TabIndex = 91;
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
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(447, 6);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(21, 13);
            this.lblMinimizar.TabIndex = 90;
            this.lblMinimizar.Text = "__";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(467, 11);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(15, 13);
            this.lblFechar.TabIndex = 89;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(108, 110);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(158, 21);
            this.cboCategoria.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(37, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Produto:";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(108, 70);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(158, 20);
            this.txtProduto.TabIndex = 85;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvProduto);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 600);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblFechar);
            this.panel1.Controls.Add(this.lblMinimizar);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 144);
            this.panel1.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(137, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 91;
            this.label1.Text = "Consultar Produto";
            // 
            // frmConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_observacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}