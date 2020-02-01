namespace Larm_s_Café.Telas.Remover.Estoque
{
    partial class frmFornecedores
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.id_fornecedores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_empresa_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_marca_fornecida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.White;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRemover.Location = new System.Drawing.Point(261, 107);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(114, 41);
            this.btnRemover.TabIndex = 32;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
            this.dgvFornecedores.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fornecedores,
            this.nm_empresa_fornecedor,
            this.ds_marca_fornecida,
            this.ds_telefone,
            this.ds_cnpj});
            this.dgvFornecedores.Location = new System.Drawing.Point(23, 171);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.Size = new System.Drawing.Size(426, 134);
            this.dgvFornecedores.TabIndex = 31;
            this.dgvFornecedores.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFornecedores_RowHeaderMouseDoubleClick);
            // 
            // id_fornecedores
            // 
            this.id_fornecedores.DataPropertyName = "id_fornecedores";
            this.id_fornecedores.HeaderText = "ID";
            this.id_fornecedores.Name = "id_fornecedores";
            this.id_fornecedores.ReadOnly = true;
            // 
            // nm_empresa_fornecedor
            // 
            this.nm_empresa_fornecedor.DataPropertyName = "nm_empresa_fornecedor";
            this.nm_empresa_fornecedor.HeaderText = "Fornecedor";
            this.nm_empresa_fornecedor.Name = "nm_empresa_fornecedor";
            this.nm_empresa_fornecedor.ReadOnly = true;
            // 
            // ds_marca_fornecida
            // 
            this.ds_marca_fornecida.DataPropertyName = "ds_marca_fornecida";
            this.ds_marca_fornecida.HeaderText = "Marca";
            this.ds_marca_fornecida.Name = "ds_marca_fornecida";
            this.ds_marca_fornecida.ReadOnly = true;
            // 
            // ds_telefone
            // 
            this.ds_telefone.DataPropertyName = "ds_telefone";
            this.ds_telefone.HeaderText = "Telefone";
            this.ds_telefone.Name = "ds_telefone";
            this.ds_telefone.ReadOnly = true;
            // 
            // ds_cnpj
            // 
            this.ds_cnpj.DataPropertyName = "ds_cnpj";
            this.ds_cnpj.HeaderText = "CNPJ";
            this.ds_cnpj.Name = "ds_cnpj";
            this.ds_cnpj.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fornecedor:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(87, 118);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(144, 20);
            this.txtFornecedor.TabIndex = 29;
            this.txtFornecedor.TextChanged += new System.EventHandler(this.txtFornecedor_TextChanged);
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(82, 85);
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(53, 20);
            this.nudID.TabIndex = 35;
            this.nudID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudID);
            this.groupBox1.Controls.Add(this.txtFornecedor);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvFornecedores);
            this.groupBox1.Location = new System.Drawing.Point(21, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 363);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(174, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Fornecedores";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblFechar);
            this.panel1.Controls.Add(this.lblMinimizar);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-47, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 112);
            this.panel1.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(242, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Compra Estoque";
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(527, 9);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(15, 13);
            this.lblFechar.TabIndex = 38;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click_1);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(502, 3);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(21, 13);
            this.lblMinimizar.TabIndex = 39;
            this.lblMinimizar.Text = "__";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click_1);
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fornecedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_empresa_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_marca_fornecida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cnpj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}