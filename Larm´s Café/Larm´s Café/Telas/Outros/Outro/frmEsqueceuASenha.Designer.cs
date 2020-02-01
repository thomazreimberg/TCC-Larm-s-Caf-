namespace Larm_s_Café.Telas.Outros.Outro
{
    partial class frmEsqueceuASenha
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
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.chkWhatsApp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.Red;
            this.lblMinimizar.Location = new System.Drawing.Point(221, 0);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(29, 20);
            this.lblMinimizar.TabIndex = 10;
            this.lblMinimizar.Text = "__";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.BackColor = System.Drawing.Color.Transparent;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.Red;
            this.lblFechar.Location = new System.Drawing.Point(251, 9);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(21, 20);
            this.lblFechar.TabIndex = 9;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(24, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(106, 107);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(144, 20);
            this.txtUsuario.TabIndex = 11;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEnviar.Location = new System.Drawing.Point(93, 181);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(103, 33);
            this.btnEnviar.TabIndex = 16;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // chkWhatsApp
            // 
            this.chkWhatsApp.AutoSize = true;
            this.chkWhatsApp.BackColor = System.Drawing.Color.Transparent;
            this.chkWhatsApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWhatsApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chkWhatsApp.Location = new System.Drawing.Point(93, 235);
            this.chkWhatsApp.Name = "chkWhatsApp";
            this.chkWhatsApp.Size = new System.Drawing.Size(173, 20);
            this.chkWhatsApp.TabIndex = 17;
            this.chkWhatsApp.Text = "Enviar por WhatsApp";
            this.chkWhatsApp.UseVisualStyleBackColor = false;
            // 
            // frmEsqueceuASenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Larm_s_Café.Properties.Resources.designCafe2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.chkWhatsApp);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblMinimizar);
            this.Controls.Add(this.lblFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEsqueceuASenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEsqueceuASenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox chkWhatsApp;
    }
}