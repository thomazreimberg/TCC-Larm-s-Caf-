namespace Larm_s_Café.Telas.Inserir.Financeiro
{
    partial class frmInserirDespesas
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeReferencia = new System.Windows.Forms.TextBox();
            this.dgvInserirDespesas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPrevisto = new System.Windows.Forms.NumericUpDown();
            this.nudRealizado = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblFechar = new System.Windows.Forms.Label();
            this.LblMinimizar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInserirDespesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevisto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRealizado)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(69, 63);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(100, 20);
            this.dtpData.TabIndex = 25;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.White;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnInserir.Location = new System.Drawing.Point(362, 102);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 31);
            this.btnInserir.TabIndex = 22;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(251, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Descrição realizada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(8, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descrição prevista:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome de referência:";
            // 
            // txtNomeReferencia
            // 
            this.txtNomeReferencia.Location = new System.Drawing.Point(129, 108);
            this.txtNomeReferencia.Name = "txtNomeReferencia";
            this.txtNomeReferencia.Size = new System.Drawing.Size(100, 20);
            this.txtNomeReferencia.TabIndex = 16;
            // 
            // dgvInserirDespesas
            // 
            this.dgvInserirDespesas.AllowUserToAddRows = false;
            this.dgvInserirDespesas.AllowUserToDeleteRows = false;
            this.dgvInserirDespesas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvInserirDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInserirDespesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dsd,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvInserirDespesas.Location = new System.Drawing.Point(6, 195);
            this.dgvInserirDespesas.Name = "dgvInserirDespesas";
            this.dgvInserirDespesas.ReadOnly = true;
            this.dgvInserirDespesas.Size = new System.Drawing.Size(501, 153);
            this.dgvInserirDespesas.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ds_previsto";
            this.Column1.HeaderText = "Des. Prevista";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dsd
            // 
            this.dsd.DataPropertyName = "nm_referencia";
            this.dsd.HeaderText = "Nome de Referência";
            this.dsd.Name = "dsd";
            this.dsd.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ds_realizado";
            this.Column2.HeaderText = "Des. Realizada";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dt_data_de_entrada_saida";
            this.Column3.HeaderText = "Data de Início";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Data de Término";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(30, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Data:";
            // 
            // nudPrevisto
            // 
            this.nudPrevisto.DecimalPlaces = 2;
            this.nudPrevisto.Location = new System.Drawing.Point(127, 159);
            this.nudPrevisto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrevisto.Name = "nudPrevisto";
            this.nudPrevisto.Size = new System.Drawing.Size(102, 20);
            this.nudPrevisto.TabIndex = 28;
            // 
            // nudRealizado
            // 
            this.nudRealizado.DecimalPlaces = 2;
            this.nudRealizado.Location = new System.Drawing.Point(380, 159);
            this.nudRealizado.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRealizado.Name = "nudRealizado";
            this.nudRealizado.Size = new System.Drawing.Size(102, 20);
            this.nudRealizado.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(189, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "á";
            // 
            // dtpSaida
            // 
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaida.Location = new System.Drawing.Point(223, 63);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(100, 20);
            this.dtpSaida.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.LblFechar);
            this.panel1.Controls.Add(this.LblMinimizar);
            this.panel1.Location = new System.Drawing.Point(-9, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 169);
            this.panel1.TabIndex = 76;
            // 
            // LblFechar
            // 
            this.LblFechar.AutoSize = true;
            this.LblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechar.ForeColor = System.Drawing.Color.White;
            this.LblFechar.Location = new System.Drawing.Point(536, 12);
            this.LblFechar.Name = "LblFechar";
            this.LblFechar.Size = new System.Drawing.Size(15, 13);
            this.LblFechar.TabIndex = 91;
            this.LblFechar.Text = "X";
            this.LblFechar.Click += new System.EventHandler(this.LblFechar_Click_1);
            // 
            // LblMinimizar
            // 
            this.LblMinimizar.AutoSize = true;
            this.LblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinimizar.ForeColor = System.Drawing.Color.White;
            this.LblMinimizar.Location = new System.Drawing.Point(513, 3);
            this.LblMinimizar.Name = "LblMinimizar";
            this.LblMinimizar.Size = new System.Drawing.Size(20, 25);
            this.LblMinimizar.TabIndex = 92;
            this.LblMinimizar.Text = "-";
            this.LblMinimizar.Click += new System.EventHandler(this.LblMinimizar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgvInserirDespesas);
            this.groupBox1.Controls.Add(this.txtNomeReferencia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpSaida);
            this.groupBox1.Controls.Add(this.btnInserir);
            this.groupBox1.Controls.Add(this.nudRealizado);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.nudPrevisto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(21, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 518);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(175, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 25);
            this.label8.TabIndex = 96;
            this.label8.Text = "Inserir Despesas";
            // 
            // frmInserirDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInserirDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDespesas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInserirDespesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevisto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRealizado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeReferencia;
        private System.Windows.Forms.DataGridView dgvInserirDespesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPrevisto;
        private System.Windows.Forms.NumericUpDown nudRealizado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblFechar;
        private System.Windows.Forms.Label LblMinimizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
    }
}