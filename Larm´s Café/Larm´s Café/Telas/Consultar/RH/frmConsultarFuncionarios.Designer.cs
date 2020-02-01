namespace Larm_s_Café.Telas.Consultar.RH
{
    partial class frmConsultarFuncionarios
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.dgvConsultarFuncionarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_demitido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_adimissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_salario_bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFuncionarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.Location = new System.Drawing.Point(248, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 27);
            this.btnBuscar.TabIndex = 161;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 160;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(158, 20);
            this.txtNome.TabIndex = 159;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(31, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 158;
            this.label18.Text = "Cargo:";
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(75, 70);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(158, 21);
            this.cboCargo.TabIndex = 157;
            // 
            // dgvConsultarFuncionarios
            // 
            this.dgvConsultarFuncionarios.AllowUserToAddRows = false;
            this.dgvConsultarFuncionarios.AllowUserToDeleteRows = false;
            this.dgvConsultarFuncionarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvConsultarFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nm_funcionario,
            this.dt_demitido,
            this.nm_empresa,
            this.dt_adimissao,
            this.vl_salario_bruto,
            this.ds_cpf,
            this.ds_endereco,
            this.ds_telefone,
            this.ds_email,
            this.dt_nascimento,
            this.ds_cargo});
            this.dgvConsultarFuncionarios.Location = new System.Drawing.Point(10, 159);
            this.dgvConsultarFuncionarios.Name = "dgvConsultarFuncionarios";
            this.dgvConsultarFuncionarios.ReadOnly = true;
            this.dgvConsultarFuncionarios.Size = new System.Drawing.Size(523, 167);
            this.dgvConsultarFuncionarios.TabIndex = 164;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_funcionario";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nm_funcionario
            // 
            this.nm_funcionario.DataPropertyName = "nm_funcionario";
            this.nm_funcionario.HeaderText = "Nome Funcionario";
            this.nm_funcionario.Name = "nm_funcionario";
            this.nm_funcionario.ReadOnly = true;
            // 
            // dt_demitido
            // 
            this.dt_demitido.DataPropertyName = "dt_demitido";
            this.dt_demitido.HeaderText = "Demissão";
            this.dt_demitido.Name = "dt_demitido";
            this.dt_demitido.ReadOnly = true;
            // 
            // nm_empresa
            // 
            this.nm_empresa.DataPropertyName = "nm_empresa";
            this.nm_empresa.HeaderText = "Empresa";
            this.nm_empresa.Name = "nm_empresa";
            this.nm_empresa.ReadOnly = true;
            // 
            // dt_adimissao
            // 
            this.dt_adimissao.DataPropertyName = "dt_adimissao";
            this.dt_adimissao.HeaderText = "Admissão";
            this.dt_adimissao.Name = "dt_adimissao";
            this.dt_adimissao.ReadOnly = true;
            // 
            // vl_salario_bruto
            // 
            this.vl_salario_bruto.DataPropertyName = "vl_salario_bruto";
            this.vl_salario_bruto.HeaderText = "Salario Bruto";
            this.vl_salario_bruto.Name = "vl_salario_bruto";
            this.vl_salario_bruto.ReadOnly = true;
            // 
            // ds_cpf
            // 
            this.ds_cpf.DataPropertyName = "ds_cpf";
            this.ds_cpf.HeaderText = "CPF";
            this.ds_cpf.Name = "ds_cpf";
            this.ds_cpf.ReadOnly = true;
            // 
            // ds_endereco
            // 
            this.ds_endereco.DataPropertyName = "ds_endereco";
            this.ds_endereco.HeaderText = "Endereço";
            this.ds_endereco.Name = "ds_endereco";
            this.ds_endereco.ReadOnly = true;
            // 
            // ds_telefone
            // 
            this.ds_telefone.DataPropertyName = "ds_telefone";
            this.ds_telefone.HeaderText = "Telefone";
            this.ds_telefone.Name = "ds_telefone";
            this.ds_telefone.ReadOnly = true;
            // 
            // ds_email
            // 
            this.ds_email.DataPropertyName = "ds_email";
            this.ds_email.HeaderText = "E-mail";
            this.ds_email.Name = "ds_email";
            this.ds_email.ReadOnly = true;
            // 
            // dt_nascimento
            // 
            this.dt_nascimento.DataPropertyName = "dt_nascimento";
            this.dt_nascimento.HeaderText = "Nascimento";
            this.dt_nascimento.Name = "dt_nascimento";
            this.dt_nascimento.ReadOnly = true;
            // 
            // ds_cargo
            // 
            this.ds_cargo.DataPropertyName = "ds_cargo";
            this.ds_cargo.HeaderText = "Cargo";
            this.ds_cargo.Name = "ds_cargo";
            this.ds_cargo.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.dgvConsultarFuncionarios);
            this.groupBox1.Controls.Add(this.cboCargo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 374);
            this.groupBox1.TabIndex = 165;
            this.groupBox1.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(158, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(242, 30);
            this.label30.TabIndex = 296;
            this.label30.Text = "Consultar Funcionários";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Location = new System.Drawing.Point(-13, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 136);
            this.panel1.TabIndex = 166;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(575, 16);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(15, 13);
            this.label28.TabIndex = 297;
            this.label28.Text = "X";
            this.label28.Click += new System.EventHandler(this.label28_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(552, 7);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(20, 25);
            this.label29.TabIndex = 298;
            this.label29.Text = "-";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // frmConsultarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 371);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFuncionarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.DataGridView dgvConsultarFuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_demitido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_adimissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_salario_bruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cargo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
    }
}