namespace Larm_s_Café.Telas.Consultar.Estoque
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.id_fornecedores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_empresa_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_marca_fornecida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblFechar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fornecedor:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(88, 88);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(144, 20);
            this.txtFornecedor.TabIndex = 25;
            this.txtFornecedor.TextChanged += new System.EventHandler(this.txtFornecedor_TextChanged);
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
            this.ds_cnpj,
            this.ds_telefone});
            this.dgvFornecedores.Location = new System.Drawing.Point(24, 141);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.Size = new System.Drawing.Size(426, 134);
            this.dgvFornecedores.TabIndex = 27;
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
            // ds_cnpj
            // 
            this.ds_cnpj.DataPropertyName = "ds_cnpj";
            this.ds_cnpj.HeaderText = "CNPJ";
            this.ds_cnpj.Name = "ds_cnpj";
            this.ds_cnpj.ReadOnly = true;
            // 
            // ds_telefone
            // 
            this.ds_telefone.DataPropertyName = "ds_telefone";
            this.ds_telefone.HeaderText = "Telefone";
            this.ds_telefone.Name = "ds_telefone";
            this.ds_telefone.ReadOnly = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsultar.Location = new System.Drawing.Point(262, 77);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(114, 41);
            this.btnConsultar.TabIndex = 28;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(500, 128);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(15, 13);
            this.lblFechar.TabIndex = 91;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click_1);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(480, 123);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(21, 13);
            this.lblMinimizar.TabIndex = 92;
            this.lblMinimizar.Text = "__";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(119, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 23);
            this.label4.TabIndex = 93;
            this.label4.Text = "Consultar Fornecedores";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblFechar);
            this.panel1.Controls.Add(this.lblMinimizar);
            this.panel1.Location = new System.Drawing.Point(-27, -119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 237);
            this.panel1.TabIndex = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvFornecedores);
            this.groupBox1.Controls.Add(this.txtFornecedor);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 322);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 315);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFornecedores";
            this.Load += new System.EventHandler(this.frmFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fornecedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_empresa_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_marca_fornecida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_telefone;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}