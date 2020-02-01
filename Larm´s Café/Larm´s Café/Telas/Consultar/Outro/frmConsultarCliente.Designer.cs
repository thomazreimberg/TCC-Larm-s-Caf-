namespace Larm_s_Café.Telas.Consultar.Outro
{
    partial class frmConsultarCliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_primeira_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_fidelizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.chkFidelizado = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.nm_cliente,
            this.ds_telefone,
            this.ds_endereco,
            this.ds_email,
            this.dt_primeira_compra,
            this.bt_ativo,
            this.bt_fidelizado});
            this.dgvCliente.Location = new System.Drawing.Point(6, 210);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(484, 192);
            this.dgvCliente.TabIndex = 79;
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.HeaderText = "ID";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            // 
            // nm_cliente
            // 
            this.nm_cliente.DataPropertyName = "nm_cliente";
            this.nm_cliente.HeaderText = "Nome";
            this.nm_cliente.Name = "nm_cliente";
            this.nm_cliente.ReadOnly = true;
            // 
            // ds_telefone
            // 
            this.ds_telefone.DataPropertyName = "ds_telefone";
            this.ds_telefone.HeaderText = "Telefone";
            this.ds_telefone.Name = "ds_telefone";
            this.ds_telefone.ReadOnly = true;
            // 
            // ds_endereco
            // 
            this.ds_endereco.DataPropertyName = "ds_endereco";
            this.ds_endereco.HeaderText = "Endereço";
            this.ds_endereco.Name = "ds_endereco";
            this.ds_endereco.ReadOnly = true;
            // 
            // ds_email
            // 
            this.ds_email.DataPropertyName = "ds_email";
            this.ds_email.HeaderText = "E-mail";
            this.ds_email.Name = "ds_email";
            this.ds_email.ReadOnly = true;
            // 
            // dt_primeira_compra
            // 
            this.dt_primeira_compra.DataPropertyName = "dt_primeira_compra";
            this.dt_primeira_compra.HeaderText = "Primeira Compra";
            this.dt_primeira_compra.Name = "dt_primeira_compra";
            this.dt_primeira_compra.ReadOnly = true;
            // 
            // bt_ativo
            // 
            this.bt_ativo.DataPropertyName = "bt_ativo";
            this.bt_ativo.HeaderText = "Cliente Ativo";
            this.bt_ativo.Name = "bt_ativo";
            this.bt_ativo.ReadOnly = true;
            // 
            // bt_fidelizado
            // 
            this.bt_fidelizado.DataPropertyName = "bt_fidelizado";
            this.bt_fidelizado.HeaderText = "Cliente Fidelizado";
            this.bt_fidelizado.Name = "bt_fidelizado";
            this.bt_fidelizado.ReadOnly = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFiltrar.Location = new System.Drawing.Point(236, 118);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(93, 30);
            this.btnFiltrar.TabIndex = 78;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(42, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(83, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(136, 20);
            this.txtNome.TabIndex = 74;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkAtivo.Location = new System.Drawing.Point(83, 130);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(55, 17);
            this.chkAtivo.TabIndex = 82;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // chkFidelizado
            // 
            this.chkFidelizado.AutoSize = true;
            this.chkFidelizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFidelizado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkFidelizado.Location = new System.Drawing.Point(83, 153);
            this.chkFidelizado.Name = "chkFidelizado";
            this.chkFidelizado.Size = new System.Drawing.Size(83, 17);
            this.chkFidelizado.TabIndex = 83;
            this.chkFidelizado.Text = "Fidelizado";
            this.chkFidelizado.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(67, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 25);
            this.label15.TabIndex = 144;
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(507, 0);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(20, 25);
            this.lblMinimizar.TabIndex = 146;
            this.lblMinimizar.Text = "-";
            this.lblMinimizar.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(530, 9);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(15, 13);
            this.lblFechar.TabIndex = 145;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.label13_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(173, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 147;
            this.label1.Text = "Consultar Clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblFechar);
            this.panel1.Controls.Add(this.lblMinimizar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 185);
            this.panel1.TabIndex = 148;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvCliente);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.chkAtivo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.chkFidelizado);
            this.groupBox1.Location = new System.Drawing.Point(28, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 672);
            this.groupBox1.TabIndex = 149;
            this.groupBox1.TabStop = false;
            // 
            // frmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_primeira_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn bt_ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bt_fidelizado;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.CheckBox chkFidelizado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}