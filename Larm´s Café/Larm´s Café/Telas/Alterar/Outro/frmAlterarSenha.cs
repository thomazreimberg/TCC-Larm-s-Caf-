using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Alterar.Outro
{
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        Business.usuarioBusiness usuarioBusiness = new Business.usuarioBusiness();
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string codigo = txtCodigo.Text;
                string senha = txtSenha.Text;
                string confirmar = txtSenhaConfirmar.Text;

                if (senha != confirmar)
                    throw new ArgumentException("As senhas não correspondem");

                usuarioBusiness.AlterarSenha(usuario, senha, codigo);
                MessageBox.Show("Senha alterada com sucesso!");
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            Hide();
            Consultar.Outro.frmLogin start = new Consultar.Outro.frmLogin();
            start.Show();

        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
