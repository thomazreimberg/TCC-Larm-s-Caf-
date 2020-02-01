namespace Larm_s_Café.Telas.Consultar.Outro
{
    partial class frmLogin
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
            this.LblMinimizar = new System.Windows.Forms.Label();
            this.LblFechar = new System.Windows.Forms.Label();
            this.LblCadastro = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblEsqueceuASenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMinimizar
            // 
            this.LblMinimizar.AutoSize = true;
            this.LblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinimizar.ForeColor = System.Drawing.Color.Red;
            this.LblMinimizar.Location = new System.Drawing.Point(454, -2);
            this.LblMinimizar.Name = "LblMinimizar";
            this.LblMinimizar.Size = new System.Drawing.Size(20, 25);
            this.LblMinimizar.TabIndex = 19;
            this.LblMinimizar.Text = "-";
            this.LblMinimizar.Click += new System.EventHandler(this.LblMinimizar_Click_1);
            // 
            // LblFechar
            // 
            this.LblFechar.AutoSize = true;
            this.LblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechar.ForeColor = System.Drawing.Color.Red;
            this.LblFechar.Location = new System.Drawing.Point(477, 7);
            this.LblFechar.Name = "LblFechar";
            this.LblFechar.Size = new System.Drawing.Size(15, 13);
            this.LblFechar.TabIndex = 18;
            this.LblFechar.Text = "X";
            this.LblFechar.Click += new System.EventHandler(this.LblFechar_Click_1);
            // 
            // LblCadastro
            // 
            this.LblCadastro.FlatAppearance.BorderSize = 0;
            this.LblCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblCadastro.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblCadastro.Location = new System.Drawing.Point(262, 243);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(212, 31);
            this.LblCadastro.TabIndex = 17;
            this.LblCadastro.Text = "Cadastre-se";
            this.LblCadastro.UseVisualStyleBackColor = true;
            this.LblCadastro.Click += new System.EventHandler(this.LblCadastro_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtUsuario.Location = new System.Drawing.Point(262, 111);
            this.txtUsuario.MaxLength = 45;
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(212, 23);
            this.txtUsuario.TabIndex = 16;
            this.txtUsuario.Text = "Usuario:";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtSenha.Location = new System.Drawing.Point(262, 153);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(212, 23);
            this.txtSenha.TabIndex = 15;
            this.txtSenha.Text = "Senha:";
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // BtnLogar
            // 
            this.BtnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogar.ForeColor = System.Drawing.Color.White;
            this.BtnLogar.Location = new System.Drawing.Point(262, 205);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.Size = new System.Drawing.Size(212, 32);
            this.BtnLogar.TabIndex = 14;
            this.BtnLogar.Text = "Entrar";
            this.BtnLogar.UseVisualStyleBackColor = false;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(341, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Larm_s_Café.Properties.Resources.designCafe2;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LblEsqueceuASenha
            // 
            this.LblEsqueceuASenha.AutoSize = true;
            this.LblEsqueceuASenha.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEsqueceuASenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblEsqueceuASenha.Location = new System.Drawing.Point(296, 303);
            this.LblEsqueceuASenha.Name = "LblEsqueceuASenha";
            this.LblEsqueceuASenha.Size = new System.Drawing.Size(140, 20);
            this.LblEsqueceuASenha.TabIndex = 20;
            this.LblEsqueceuASenha.Text = "Esqueceu a senha?";
            this.LblEsqueceuASenha.Click += new System.EventHandler(this.LblEsqueceuASenha_Click_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 332);
            this.Controls.Add(this.LblEsqueceuASenha);
            this.Controls.Add(this.LblMinimizar);
            this.Controls.Add(this.LblFechar);
            this.Controls.Add(this.LblCadastro);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.BtnLogar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMinimizar;
        private System.Windows.Forms.Label LblFechar;
        private System.Windows.Forms.Button LblCadastro;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button BtnLogar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblEsqueceuASenha;
    }
}