namespace Larm_s_Café.Telas.Consultar.Financeiro
{
    partial class frmBalancoPatrimonial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAtivos = new System.Windows.Forms.DataGridView();
            this.nm_referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPassivos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPatrimonioLiquido = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtivo = new System.Windows.Forms.Button();
            this.btnPassivo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalLiquido = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalPassivo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalAtivo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAnoBuscar = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrimonioLiquido)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAtivos
            // 
            this.dgvAtivos.AllowUserToAddRows = false;
            this.dgvAtivos.AllowUserToDeleteRows = false;
            this.dgvAtivos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAtivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nm_referencia,
            this.vl_valor,
            this.dt_data});
            this.dgvAtivos.Location = new System.Drawing.Point(108, 237);
            this.dgvAtivos.Name = "dgvAtivos";
            this.dgvAtivos.ReadOnly = true;
            this.dgvAtivos.Size = new System.Drawing.Size(427, 150);
            this.dgvAtivos.TabIndex = 0;
            // 
            // nm_referencia
            // 
            this.nm_referencia.DataPropertyName = "nm_referencia";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow;
            this.nm_referencia.DefaultCellStyle = dataGridViewCellStyle4;
            this.nm_referencia.HeaderText = "Ativo";
            this.nm_referencia.Name = "nm_referencia";
            this.nm_referencia.ReadOnly = true;
            // 
            // vl_valor
            // 
            this.vl_valor.DataPropertyName = "vl_valor";
            this.vl_valor.HeaderText = "Valor";
            this.vl_valor.Name = "vl_valor";
            this.vl_valor.ReadOnly = true;
            // 
            // dt_data
            // 
            this.dt_data.DataPropertyName = "dt_data";
            this.dt_data.HeaderText = "Ano";
            this.dt_data.Name = "dt_data";
            this.dt_data.ReadOnly = true;
            // 
            // dgvPassivos
            // 
            this.dgvPassivos.AllowUserToAddRows = false;
            this.dgvPassivos.AllowUserToDeleteRows = false;
            this.dgvPassivos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPassivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column4,
            this.dataGridViewTextBoxColumn4});
            this.dgvPassivos.Location = new System.Drawing.Point(108, 448);
            this.dgvPassivos.Name = "dgvPassivos";
            this.dgvPassivos.ReadOnly = true;
            this.dgvPassivos.Size = new System.Drawing.Size(427, 150);
            this.dgvPassivos.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nm_referencia";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Yellow;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "Passivo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "vl_valor";
            this.Column4.HeaderText = "Valor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dt_data";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ano";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dgvPatrimonioLiquido
            // 
            this.dgvPatrimonioLiquido.AllowUserToAddRows = false;
            this.dgvPatrimonioLiquido.AllowUserToDeleteRows = false;
            this.dgvPatrimonioLiquido.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatrimonioLiquido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatrimonioLiquido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.Column1});
            this.dgvPatrimonioLiquido.Location = new System.Drawing.Point(108, 663);
            this.dgvPatrimonioLiquido.Name = "dgvPatrimonioLiquido";
            this.dgvPatrimonioLiquido.ReadOnly = true;
            this.dgvPatrimonioLiquido.Size = new System.Drawing.Size(427, 98);
            this.dgvPatrimonioLiquido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(106, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 102;
            this.label2.Text = "Passivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(104, 639);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 103;
            this.label3.Text = "Patrimonio Líquido";
            // 
            // btnAtivo
            // 
            this.btnAtivo.BackColor = System.Drawing.Color.White;
            this.btnAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAtivo.Location = new System.Drawing.Point(438, 393);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Size = new System.Drawing.Size(97, 25);
            this.btnAtivo.TabIndex = 104;
            this.btnAtivo.Text = "Novo Ativo";
            this.btnAtivo.UseVisualStyleBackColor = false;
            // 
            // btnPassivo
            // 
            this.btnPassivo.BackColor = System.Drawing.Color.White;
            this.btnPassivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPassivo.Location = new System.Drawing.Point(438, 604);
            this.btnPassivo.Name = "btnPassivo";
            this.btnPassivo.Size = new System.Drawing.Size(97, 25);
            this.btnPassivo.TabIndex = 105;
            this.btnPassivo.Text = "Novo Passivo";
            this.btnPassivo.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblTotalLiquido);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblTotalPassivo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblTotalAtivo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboAnoBuscar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(25, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 799);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            // 
            // lblTotalLiquido
            // 
            this.lblTotalLiquido.AutoSize = true;
            this.lblTotalLiquido.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLiquido.ForeColor = System.Drawing.Color.Black;
            this.lblTotalLiquido.Location = new System.Drawing.Point(183, 739);
            this.lblTotalLiquido.Name = "lblTotalLiquido";
            this.lblTotalLiquido.Size = new System.Drawing.Size(18, 17);
            this.lblTotalLiquido.TabIndex = 110;
            this.lblTotalLiquido.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(134, 739);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 109;
            this.label11.Text = "Total:";
            // 
            // lblTotalPassivo
            // 
            this.lblTotalPassivo.AutoSize = true;
            this.lblTotalPassivo.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPassivo.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPassivo.Location = new System.Drawing.Point(183, 570);
            this.lblTotalPassivo.Name = "lblTotalPassivo";
            this.lblTotalPassivo.Size = new System.Drawing.Size(18, 17);
            this.lblTotalPassivo.TabIndex = 108;
            this.lblTotalPassivo.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(134, 570);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 107;
            this.label9.Text = "Total:";
            // 
            // lblTotalAtivo
            // 
            this.lblTotalAtivo.AutoSize = true;
            this.lblTotalAtivo.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAtivo.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAtivo.Location = new System.Drawing.Point(183, 363);
            this.lblTotalAtivo.Name = "lblTotalAtivo";
            this.lblTotalAtivo.Size = new System.Drawing.Size(18, 17);
            this.lblTotalAtivo.TabIndex = 106;
            this.lblTotalAtivo.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(134, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 105;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(207, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 104;
            this.label4.Text = "Ano:";
            // 
            // cboAnoBuscar
            // 
            this.cboAnoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnoBuscar.FormattingEnabled = true;
            this.cboAnoBuscar.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cboAnoBuscar.Location = new System.Drawing.Point(254, 119);
            this.cboAnoBuscar.Name = "cboAnoBuscar";
            this.cboAnoBuscar.Size = new System.Drawing.Size(121, 21);
            this.cboAnoBuscar.TabIndex = 103;
            this.cboAnoBuscar.SelectedIndexChanged += new System.EventHandler(this.cboAnoBuscar_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Larm_s_Café.Properties.Resources.logo_LarmsCafe2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(81, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 101;
            this.label1.Text = "Ativos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(196, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 30);
            this.label8.TabIndex = 100;
            this.label8.Text = "Balanço Patrimonial";
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(595, 0);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(20, 25);
            this.lblMinimizar.TabIndex = 107;
            this.lblMinimizar.Text = "-";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(618, 9);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(15, 13);
            this.lblFechar.TabIndex = 106;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nm_referencia";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Yellow;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn5.HeaderText = "Patrimonio Líquido";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "vl_valor";
            this.Column1.HeaderText = "Valor";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // frmBalancoPatrimonial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(645, 845);
            this.Controls.Add(this.lblMinimizar);
            this.Controls.Add(this.btnPassivo);
            this.Controls.Add(this.btnAtivo);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPatrimonioLiquido);
            this.Controls.Add(this.dgvPassivos);
            this.Controls.Add(this.dgvAtivos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBalancoPatrimonial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBalancoPatrimonial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrimonioLiquido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAtivos;
        private System.Windows.Forms.DataGridView dgvPassivos;
        private System.Windows.Forms.DataGridView dgvPatrimonioLiquido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAtivo;
        private System.Windows.Forms.Button btnPassivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboAnoBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalAtivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalLiquido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalPassivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}