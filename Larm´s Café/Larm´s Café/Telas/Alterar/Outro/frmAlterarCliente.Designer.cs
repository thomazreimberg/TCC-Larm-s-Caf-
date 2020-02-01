namespace Larm_s_Café.Telas.Alterar.Outro
{
    partial class frmAlterarCliente
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFidelizado = new System.Windows.Forms.CheckBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_primeira_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_fidelizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClienteFiltro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.chkAtivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkFidelizado);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.dgvCliente);
            this.groupBox1.Controls.Add(this.nudID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtClienteFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 433);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkBox1.Location = new System.Drawing.Point(477, 129);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 110;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkBox2.Location = new System.Drawing.Point(477, 152);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 17);
            this.checkBox2.TabIndex = 109;
            this.checkBox2.Text = "Fidelizado";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlterar.Location = new System.Drawing.Point(182, 184);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 31);
            this.btnAlterar.TabIndex = 108;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(85, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(158, 20);
            this.txtNome.TabIndex = 98;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkAtivo.Location = new System.Drawing.Point(274, 80);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(55, 17);
            this.chkAtivo.TabIndex = 107;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Nome:";
            // 
            // chkFidelizado
            // 
            this.chkFidelizado.AutoSize = true;
            this.chkFidelizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFidelizado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkFidelizado.Location = new System.Drawing.Point(274, 119);
            this.chkFidelizado.Name = "chkFidelizado";
            this.chkFidelizado.Size = new System.Drawing.Size(83, 17);
            this.chkFidelizado.TabIndex = 106;
            this.chkFidelizado.Text = "Fidelizado";
            this.chkFidelizado.UseVisualStyleBackColor = true;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(85, 120);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(158, 20);
            this.txtEndereco.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Endereco:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(38, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(18, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(85, 94);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(158, 20);
            this.txtTelefone.TabIndex = 104;
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
            this.dgvCliente.Location = new System.Drawing.Point(17, 230);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(575, 192);
            this.dgvCliente.TabIndex = 97;
            this.dgvCliente.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCliente_RowHeaderMouseDoubleClick);
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
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(477, 54);
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(100, 20);
            this.nudID.TabIndex = 44;
            this.nudID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(177, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 30);
            this.label8.TabIndex = 41;
            this.label8.Text = "Alterar Cliente";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(429, 193);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 31);
            this.btnConsultar.TabIndex = 41;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(398, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Cliente:";
            // 
            // txtClienteFiltro
            // 
            this.txtClienteFiltro.Location = new System.Drawing.Point(477, 97);
            this.txtClienteFiltro.Name = "txtClienteFiltro";
            this.txtClienteFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtClienteFiltro.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 170);
            this.panel1.TabIndex = 149;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(614, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 145;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(591, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 146;
            this.label7.Text = "-";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(373, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 165);
            this.panel2.TabIndex = 111;
            // 
            // frmAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlterarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClienteFiltro;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_primeira_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn bt_ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bt_fidelizado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFidelizado;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel2;
    }
}