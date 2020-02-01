namespace Larm_s_Café.Telas.Remover.Financeiro
{
    partial class frmRemoverDespesas
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReferenciaFiltro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.id_fluxo_caixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_previsto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRealizado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrevisto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeReferencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataFiltro = new System.Windows.Forms.DateTimePicker();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(368, 177);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 31);
            this.btnConsultar.TabIndex = 56;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(289, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Referência:";
            // 
            // txtReferenciaFiltro
            // 
            this.txtReferenciaFiltro.Location = new System.Drawing.Point(368, 116);
            this.txtReferenciaFiltro.Name = "txtReferenciaFiltro";
            this.txtReferenciaFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtReferenciaFiltro.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(90, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Data:";
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.AllowUserToAddRows = false;
            this.dgvDespesas.AllowUserToDeleteRows = false;
            this.dgvDespesas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fluxo_caixa,
            this.dsd,
            this.ds_previsto,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDespesas.Location = new System.Drawing.Point(9, 239);
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.ReadOnly = true;
            this.dgvDespesas.Size = new System.Drawing.Size(501, 153);
            this.dgvDespesas.TabIndex = 52;
            this.dgvDespesas.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDespesas_RowHeaderMouseDoubleClick);
            // 
            // id_fluxo_caixa
            // 
            this.id_fluxo_caixa.DataPropertyName = "id_fluxo_caixa";
            this.id_fluxo_caixa.HeaderText = "ID";
            this.id_fluxo_caixa.Name = "id_fluxo_caixa";
            this.id_fluxo_caixa.ReadOnly = true;
            // 
            // dsd
            // 
            this.dsd.DataPropertyName = "nm_referencia";
            this.dsd.HeaderText = "Nome de Referência";
            this.dsd.Name = "dsd";
            this.dsd.ReadOnly = true;
            // 
            // ds_previsto
            // 
            this.ds_previsto.DataPropertyName = "ds_previsto";
            this.ds_previsto.HeaderText = "Previsto";
            this.ds_previsto.Name = "ds_previsto";
            this.ds_previsto.ReadOnly = true;
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
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(136, 110);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(100, 20);
            this.dtpData.TabIndex = 51;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.White;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRemover.Location = new System.Drawing.Point(74, 190);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(99, 39);
            this.btnRemover.TabIndex = 48;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(61, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Realizado:";
            // 
            // txtRealizado
            // 
            this.txtRealizado.Location = new System.Drawing.Point(136, 161);
            this.txtRealizado.Name = "txtRealizado";
            this.txtRealizado.Size = new System.Drawing.Size(100, 20);
            this.txtRealizado.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(73, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Previsto:";
            // 
            // txtPrevisto
            // 
            this.txtPrevisto.Location = new System.Drawing.Point(136, 135);
            this.txtPrevisto.Name = "txtPrevisto";
            this.txtPrevisto.Size = new System.Drawing.Size(100, 20);
            this.txtPrevisto.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nome de referência:";
            // 
            // txtNomeReferencia
            // 
            this.txtNomeReferencia.Location = new System.Drawing.Point(136, 84);
            this.txtNomeReferencia.Name = "txtNomeReferencia";
            this.txtNomeReferencia.Size = new System.Drawing.Size(100, 20);
            this.txtNomeReferencia.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(324, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Data:";
            // 
            // dtpDataFiltro
            // 
            this.dtpDataFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFiltro.Location = new System.Drawing.Point(368, 142);
            this.dtpDataFiltro.Name = "dtpDataFiltro";
            this.dtpDataFiltro.Size = new System.Drawing.Size(100, 20);
            this.dtpDataFiltro.TabIndex = 57;
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(14, 136);
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(27, 20);
            this.nudID.TabIndex = 59;
            this.nudID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudID);
            this.groupBox1.Controls.Add(this.txtNomeReferencia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrevisto);
            this.groupBox1.Controls.Add(this.dtpDataFiltro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtRealizado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtReferenciaFiltro);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.dgvDespesas);
            this.groupBox1.Location = new System.Drawing.Point(22, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 404);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(178, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 23);
            this.label7.TabIndex = 60;
            this.label7.Text = "Remover Despesas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblFechar);
            this.panel1.Controls.Add(this.lblMinimizar);
            this.panel1.Location = new System.Drawing.Point(-23, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 151);
            this.panel1.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(307, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(282, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "__";
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(564, 21);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(15, 13);
            this.lblFechar.TabIndex = 62;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click_1);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(539, 15);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(21, 13);
            this.lblMinimizar.TabIndex = 63;
            this.lblMinimizar.Text = "__";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click_1);
            // 
            // frmRemoverDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRemoverDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDespesas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReferenciaFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRealizado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrevisto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeReferencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fluxo_caixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_previsto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}