namespace Larm_s_Café.Telas.Alterar.Financeiro
{
    partial class frmAlterarDespesas
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
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeDeReferencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblFechar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudRealizado = new System.Windows.Forms.NumericUpDown();
            this.nudPrevisto = new System.Windows.Forms.NumericUpDown();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRealizado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevisto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.AllowUserToAddRows = false;
            this.dgvDespesas.AllowUserToDeleteRows = false;
            this.dgvDespesas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.ds_referencia,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDespesas.Location = new System.Drawing.Point(6, 234);
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.ReadOnly = true;
            this.dgvDespesas.Size = new System.Drawing.Size(501, 153);
            this.dgvDespesas.TabIndex = 37;
            this.dgvDespesas.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDespesas_RowHeaderMouseDoubleClick);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(133, 105);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(100, 20);
            this.dtpData.TabIndex = 36;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlterar.Location = new System.Drawing.Point(71, 185);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(99, 39);
            this.btnAlterar.TabIndex = 33;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(60, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Realizado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(70, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Previsto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(5, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome de referência:";
            // 
            // txtNomeDeReferencia
            // 
            this.txtNomeDeReferencia.Location = new System.Drawing.Point(133, 79);
            this.txtNomeDeReferencia.Name = "txtNomeDeReferencia";
            this.txtNomeDeReferencia.Size = new System.Drawing.Size(100, 20);
            this.txtNomeDeReferencia.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(51, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Data Saída:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(365, 172);
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
            this.label5.Location = new System.Drawing.Point(286, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Referência:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(365, 126);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(100, 20);
            this.txtReferencia.TabIndex = 39;
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(534, 34);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(15, 13);
            this.lblFechar.TabIndex = 95;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click_1);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(511, 25);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(20, 25);
            this.lblMinimizar.TabIndex = 96;
            this.lblMinimizar.Text = "-";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblFechar);
            this.panel1.Controls.Add(this.lblMinimizar);
            this.panel1.Location = new System.Drawing.Point(-18, -25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 191);
            this.panel1.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(177, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 30);
            this.label8.TabIndex = 41;
            this.label8.Text = "Alterar Despesas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudID);
            this.groupBox1.Controls.Add(this.nudPrevisto);
            this.groupBox1.Controls.Add(this.nudRealizado);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgvDespesas);
            this.groupBox1.Controls.Add(this.txtNomeDeReferencia);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtReferencia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 415);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            // 
            // nudRealizado
            // 
            this.nudRealizado.DecimalPlaces = 2;
            this.nudRealizado.Location = new System.Drawing.Point(133, 159);
            this.nudRealizado.Name = "nudRealizado";
            this.nudRealizado.Size = new System.Drawing.Size(100, 20);
            this.nudRealizado.TabIndex = 42;
            // 
            // nudPrevisto
            // 
            this.nudPrevisto.DecimalPlaces = 2;
            this.nudPrevisto.Location = new System.Drawing.Point(133, 131);
            this.nudPrevisto.Name = "nudPrevisto";
            this.nudPrevisto.Size = new System.Drawing.Size(100, 20);
            this.nudPrevisto.TabIndex = 43;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id_fluxo_de_caixa";
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // ds_referencia
            // 
            this.ds_referencia.DataPropertyName = "nm_referencia";
            this.ds_referencia.HeaderText = "Nome de Referência";
            this.ds_referencia.Name = "ds_referencia";
            this.ds_referencia.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ds_previsto";
            this.Column1.HeaderText = "Des. Prevista";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.Column3.DataPropertyName = "dt_entrada";
            this.Column3.HeaderText = "Data de Início";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dt_saida";
            this.Column4.HeaderText = "Data de Término";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(386, 54);
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(100, 20);
            this.nudID.TabIndex = 44;
            this.nudID.Visible = false;
            // 
            // frmAlterarDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlterarDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDespesas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRealizado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevisto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeDeReferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudPrevisto;
        private System.Windows.Forms.NumericUpDown nudRealizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.NumericUpDown nudID;
    }
}