namespace Larm_s_Café.Telas.Alterar.Estoque
{
    partial class frmMateriaPrima
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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblFechar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.ds_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_materia_prima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMateriaPrima = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtProdutoFiltro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCategoriaFiltro = new System.Windows.Forms.ComboBox();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblAlterou = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(82, 76);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(158, 20);
            this.txtProduto.TabIndex = 39;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(11, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(82, 119);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(158, 21);
            this.cboCategoria.TabIndex = 42;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(475, 10);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(15, 13);
            this.lblFechar.TabIndex = 43;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(455, 5);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(21, 13);
            this.lblMinimizar.TabIndex = 44;
            this.lblMinimizar.Text = "__";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // ds_categoria
            // 
            this.ds_categoria.DataPropertyName = "ds_categoria";
            this.ds_categoria.HeaderText = "Categoria";
            this.ds_categoria.Name = "ds_categoria";
            this.ds_categoria.ReadOnly = true;
            // 
            // vl_preco
            // 
            this.vl_preco.DataPropertyName = "vl_preco";
            this.vl_preco.HeaderText = "Preço";
            this.vl_preco.Name = "vl_preco";
            this.vl_preco.ReadOnly = true;
            // 
            // nm_produto
            // 
            this.nm_produto.DataPropertyName = "nm_produto";
            this.nm_produto.HeaderText = "Produto";
            this.nm_produto.Name = "nm_produto";
            this.nm_produto.ReadOnly = true;
            // 
            // id_materia_prima
            // 
            this.id_materia_prima.DataPropertyName = "id_materia_prima";
            this.id_materia_prima.HeaderText = "ID";
            this.id_materia_prima.Name = "id_materia_prima";
            this.id_materia_prima.ReadOnly = true;
            // 
            // dgvMateriaPrima
            // 
            this.dgvMateriaPrima.AllowUserToAddRows = false;
            this.dgvMateriaPrima.AllowUserToDeleteRows = false;
            this.dgvMateriaPrima.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriaPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_materia_prima,
            this.nm_produto,
            this.vl_preco,
            this.ds_categoria});
            this.dgvMateriaPrima.Location = new System.Drawing.Point(24, 267);
            this.dgvMateriaPrima.Name = "dgvMateriaPrima";
            this.dgvMateriaPrima.ReadOnly = true;
            this.dgvMateriaPrima.Size = new System.Drawing.Size(426, 144);
            this.dgvMateriaPrima.TabIndex = 45;
            this.dgvMateriaPrima.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMateriaPrima_RowHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(32, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Preço:";
            // 
            // nudPreco
            // 
            this.nudPreco.DecimalPlaces = 2;
            this.nudPreco.Location = new System.Drawing.Point(82, 156);
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(158, 20);
            this.nudPreco.TabIndex = 49;
            this.nudPreco.ValueChanged += new System.EventHandler(this.nudPreco_ValueChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlterar.Location = new System.Drawing.Point(38, 216);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(104, 36);
            this.btnAlterar.TabIndex = 50;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtProdutoFiltro
            // 
            this.txtProdutoFiltro.Location = new System.Drawing.Point(340, 112);
            this.txtProdutoFiltro.Name = "txtProdutoFiltro";
            this.txtProdutoFiltro.Size = new System.Drawing.Size(96, 20);
            this.txtProdutoFiltro.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(279, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Produto:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(340, 193);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(96, 36);
            this.btnFiltrar.TabIndex = 53;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(271, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Categoria:";
            // 
            // cboCategoriaFiltro
            // 
            this.cboCategoriaFiltro.FormattingEnabled = true;
            this.cboCategoriaFiltro.Location = new System.Drawing.Point(340, 150);
            this.cboCategoriaFiltro.Name = "cboCategoriaFiltro";
            this.cboCategoriaFiltro.Size = new System.Drawing.Size(96, 21);
            this.cboCategoriaFiltro.TabIndex = 55;
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(262, 77);
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(120, 20);
            this.nudID.TabIndex = 56;
            this.nudID.Visible = false;
            this.nudID.ValueChanged += new System.EventHandler(this.nudID_ValueChanged);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.White;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRemover.Location = new System.Drawing.Point(148, 216);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(104, 36);
            this.btnRemover.TabIndex = 57;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblAlterou
            // 
            this.lblAlterou.AutoSize = true;
            this.lblAlterou.Location = new System.Drawing.Point(389, 251);
            this.lblAlterou.Name = "lblAlterou";
            this.lblAlterou.Size = new System.Drawing.Size(15, 13);
            this.lblAlterou.TabIndex = 58;
            this.lblAlterou.Text = "--";
            this.lblAlterou.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblAlterou);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Controls.Add(this.nudID);
            this.groupBox1.Controls.Add(this.cboCategoriaFiltro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvMateriaPrima);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudPreco);
            this.groupBox1.Controls.Add(this.txtProdutoFiltro);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 473);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblFechar);
            this.panel1.Controls.Add(this.lblMinimizar);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 165);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(120, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Alterar Matéria Prima";
            // 
            // frmMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMateriaPrima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMateriaPrima";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_materia_prima;
        private System.Windows.Forms.DataGridView dgvMateriaPrima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtProdutoFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCategoriaFiltro;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblAlterou;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}