namespace Larm_s_Café.Telas.Consultar.Financeiro
{
    partial class frmFluxoDeCaixa
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
            this.dgvFluxoCaixa = new System.Windows.Forms.DataGridView();
            this.dt_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_operacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnButao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoCaixa)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFluxoCaixa
            // 
            this.dgvFluxoCaixa.AllowUserToAddRows = false;
            this.dgvFluxoCaixa.AllowUserToDeleteRows = false;
            this.dgvFluxoCaixa.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFluxoCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFluxoCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dt_pagamento,
            this.vl_operacao,
            this.Operação});
            this.dgvFluxoCaixa.Location = new System.Drawing.Point(6, 130);
            this.dgvFluxoCaixa.Name = "dgvFluxoCaixa";
            this.dgvFluxoCaixa.ReadOnly = true;
            this.dgvFluxoCaixa.Size = new System.Drawing.Size(504, 170);
            this.dgvFluxoCaixa.TabIndex = 0;
            // 
            // dt_pagamento
            // 
            this.dt_pagamento.DataPropertyName = "dt_pagamento";
            this.dt_pagamento.HeaderText = "Data de Pagamento";
            this.dt_pagamento.Name = "dt_pagamento";
            this.dt_pagamento.ReadOnly = true;
            // 
            // vl_operacao
            // 
            this.vl_operacao.DataPropertyName = "vl_operacao";
            this.vl_operacao.HeaderText = "Valor Gasto";
            this.vl_operacao.Name = "vl_operacao";
            this.vl_operacao.ReadOnly = true;
            // 
            // Operação
            // 
            this.Operação.DataPropertyName = "tp_operacao";
            this.Operação.HeaderText = "Operação";
            this.Operação.Name = "Operação";
            this.Operação.ReadOnly = true;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(133, 77);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(95, 20);
            this.dtpInicio.TabIndex = 16;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(280, 77);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpFinal.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(247, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "á";
            // 
            // btnButao
            // 
            this.btnButao.BackColor = System.Drawing.Color.White;
            this.btnButao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnButao.Location = new System.Drawing.Point(416, 75);
            this.btnButao.Name = "btnButao";
            this.btnButao.Size = new System.Drawing.Size(75, 29);
            this.btnButao.TabIndex = 19;
            this.btnButao.Text = "Procurar";
            this.btnButao.UseVisualStyleBackColor = false;
            this.btnButao.Click += new System.EventHandler(this.btnButao_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-24, -56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 213);
            this.panel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(538, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 102;
            this.label7.Text = "-";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(561, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 101;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(191, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 30);
            this.label8.TabIndex = 100;
            this.label8.Text = "Fluxo De Caixa";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgvFluxoCaixa);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.btnButao);
            this.groupBox1.Controls.Add(this.dtpFinal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 423);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // frmFluxoDeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFluxoDeCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFluxoDeCaixa";
            this.Load += new System.EventHandler(this.frmFluxoDeCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoCaixa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFluxoCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_operacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operação;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnButao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}