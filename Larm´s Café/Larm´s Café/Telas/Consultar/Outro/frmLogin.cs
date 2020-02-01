using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Consultar.Outro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LblFechar_Click(object sender, EventArgs e)
        {
            // Encerra a aplicação
            Application.Exit();
        }

        private void LblMinimizar_Click(object sender, EventArgs e)
        {
            // Minimiza a Tela de Login
            WindowState = FormWindowState.Minimized;
        }

        private void LblEsqueceuASenha_Click(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmEsqueceuASenha start = new Outros.Outro.frmEsqueceuASenha();
            start.Show();// Vai para a Tela de Esqueceu a senha
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Coleta de Dados
                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                // Instanciamento da Business
                Business.usuarioBusiness usuarioBusiness = new Business.usuarioBusiness();
                // Invocando a Função EfetuarLogin da Business
                bool resposta = usuarioBusiness.EfetuarLogin(usuario, senha);
                // Condição para tomar a decisão de ir para o Menu ou não
                if (resposta == false)
                {
                    LimparCampos();// Limpa os campos caso não tenha um usuário válido
                }
                else
                {
                    Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
                    start.Show();//Vai para o Menu
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }     

        public void LimparCampos()
        {
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void LblEsqueceuASenha_Click_1(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmEsqueceuASenha start = new Outros.Outro.frmEsqueceuASenha();
            start.Show();// Vai para a Tela de Esqueceu a senha
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            ClicarNoBotao();
        }

        private void LblCadastro_Click(object sender, EventArgs e)
        {
            Hide();
            Telas.Inserir.Outro.frmCadastro start = new Inserir.Outro.frmCadastro();
            start.Show();
        }

        private void LblFechar_Click_1(object sender, EventArgs e)
        {
            // Encerra a aplicação
            Application.Exit();
        }

        private void LblMinimizar_Click_1(object sender, EventArgs e)
        {
            // Minimiza a Tela de Login
            WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Text = string.Empty;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = string.Empty;
            txtSenha.UseSystemPasswordChar = false;
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                ClicarNoBotao();
            }
        }

        private void ClicarNoBotao()
        {
            try
            {
                // Coleta de Dados
                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                // Instanciamento da Business
                Business.usuarioBusiness usuarioBusiness = new Business.usuarioBusiness();
                // Invocando a Função EfetuarLogin da Business
                bool resposta = usuarioBusiness.EfetuarLogin(usuario, senha);
                // Condição para tomar a decisão de ir para o Menu ou não
                if (resposta == false)
                {
                    LimparCampos();// Limpa os campos caso não tenha um usuário válido
                }
                else
                {
                    Database.Entity.tb_usuario modelo = usuarioBusiness.ModeloUsuarioAtivo(usuario);
                    Modelos.Usuario.UsuarioModelo = modelo;

                    Hide();
                    Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
                    start.Show();//Vai para o Menu
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == string.Empty)
            {
                txtUsuario.Text = "Usuário:";
            }
        }
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if(txtSenha.Text == string.Empty)
            {
                txtSenha.UseSystemPasswordChar = true;
                txtSenha.Text = "Senha:";
            }
        }
    }
}
