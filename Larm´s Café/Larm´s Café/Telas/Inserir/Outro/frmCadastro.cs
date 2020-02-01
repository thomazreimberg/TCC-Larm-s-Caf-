using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Inserir.Outro
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
            CarregarCampos();
        }

        private void LblMinimizar_Click(object sender, EventArgs e)
        {
            // Minimiza a Tela de Cadastro
            WindowState = FormWindowState.Minimized;
        }

        private void LblFechar_Click(object sender, EventArgs e)
        {
            Close();// Fecha a Tela de Cadastro
            Consultar.Outro.frmLogin start = new Consultar.Outro.frmLogin();
            start.Show();// Abre a Tela de Login
        }

        

        public void CarregarCampos()
        {
            Business.funcionarioBusiness funcionarioBusiness = new Business.funcionarioBusiness();

            List<Database.Entity.tb_funcionario> lista = funcionarioBusiness.ConsultarTodos();

            cboFuncionário.ValueMember = nameof (Database.Entity.tb_funcionario.nm_funcionario);
            cboFuncionário.DataSource = lista;
        }

        public void LimparCampos()
        {
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
            cboFuncionário.Text = "Funcionário:";
        }

        private void BtnCadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Business.usuarioBusiness usuarioBusiness = new Business.usuarioBusiness();
                Database.Entity.tb_usuario tb_usuario = new Database.Entity.tb_usuario();

                Database.Entity.tb_funcionario func = cboFuncionário.SelectedItem as Database.Entity.tb_funcionario;


                // Coleta de Dados
                tb_usuario.nm_usuario = txtUsuario.Text;
                tb_usuario.nm_senha = txtSenha.Text;
                tb_usuario.id_funcionario = func.id_funcionario;

                bool funUsu = usuarioBusiness.VerificarFuncionario(func.id_funcionario);
                if (funUsu == false)
                {
                    throw new ArgumentException("Funcionário não encontrado");
                    LimparCampos();
                }
                usuarioBusiness.Cadastro(tb_usuario);
                MessageBox.Show("Usuario Cadastrado", "", MessageBoxButtons.OK);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void LblFechar_Click_1(object sender, EventArgs e)
        {
            Hide();
            Consultar.Outro.frmLogin start = new Consultar.Outro.frmLogin();
            start.Show();
        }

        private void LblMinimizar_Click_1(object sender, EventArgs e)
        {
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
