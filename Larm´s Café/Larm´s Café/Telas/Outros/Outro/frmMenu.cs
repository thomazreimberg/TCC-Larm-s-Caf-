using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Watson.SpeechToText.v1;
using IBM.Watson.TextToSpeech.v1;
using Stannieman.AudioPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Outros.Outro
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Fluxo de Caixa";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;

                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
               Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Consultar.Financeiro.frmFluxoDeCaixa start = new Consultar.Financeiro.frmFluxoDeCaixa();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void consultarFolhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Consultar Folha de Pagamento";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;

                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
               Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Consultar.RH.frmConsultarFolhaDePagamento start = new Consultar.RH.frmConsultarFolhaDePagamento();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void consultarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Consultar Funcionário";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
               Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Consultar.RH.frmConsultarFuncionarios start = new Consultar.RH.frmConsultarFuncionarios();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void lblFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Consultar Cliente";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
               Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Consultar.Outro.frmConsultarCliente start = new Consultar.Outro.frmConsultarCliente();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void inserirFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Inserir Fornecedor";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
               Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Inserir.Estoque.frmFornecedores start = new Inserir.Estoque.frmFornecedores();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void inserirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Inserir Cliente";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
               Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Inserir.Outro.frmInserirCliente start = new Inserir.Outro.frmInserirCliente();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void inserirDespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Inserir Despesas";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
               Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Inserir.Financeiro.frmInserirDespesas start = new Inserir.Financeiro.frmInserirDespesas();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void inserirFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Inserir Funcionário";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
               Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Inserir.RH.frmInserirFuncionarios start = new Inserir.RH.frmInserirFuncionarios();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void alterarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Alterar Produto";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
               Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Alterar.Estoque.frmProduto start = new Alterar.Estoque.frmProduto();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void alterarMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Alterar Matéria Prima";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "4721")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Alterar.Estoque.frmMateriaPrima start = new Alterar.Estoque.frmMateriaPrima();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void consultarMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Consultar Matéria Prima";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "4721")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Consultar.Estoque.frmConsultarMateriaPrima start = new Consultar.Estoque.frmConsultarMateriaPrima();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void consultarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Consultar Produto";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "4721")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Consultar.Estoque.frmConsultarProduto start = new Consultar.Estoque.frmConsultarProduto();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void consultarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Consultar Cliente";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Consultar.Outro.frmConsultarCliente start = new Consultar.Outro.frmConsultarCliente();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void inserirVendaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Inserir Venda Produto";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "4721" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1790")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Inserir.Outro.frmInserirVendaProduto start = new Inserir.Outro.frmInserirVendaProduto();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void alterarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Alterar Cliente";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Alterar.Outro.frmAlterarCliente start = new Alterar.Outro.frmAlterarCliente();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void inserirClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Inserir Cliente";
                log.dt_entrada = DateTime.Now.Date;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Inserir.Outro.frmInserirCliente start = new Inserir.Outro.frmInserirCliente();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void inserirProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Inserir Produto";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Inserir.Estoque.frmInserirProduto start = new Inserir.Estoque.frmInserirProduto();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void inserirMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Inserir Matéria Prima";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Inserir.Estoque.frmInserirMateriaPrima start = new Inserir.Estoque.frmInserirMateriaPrima();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void alterarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Alterar Fornecedor";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Alterar.Estoque.frmAlterarFornecedor start = new Alterar.Estoque.frmAlterarFornecedor();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void consultarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Consultar Fornecedor";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Consultar.Estoque.frmFornecedores start = new Consultar.Estoque.frmFornecedores();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void consultarDespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Consultar Despesas";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Consultar.Financeiro.frmConsultarDespesas start = new Consultar.Financeiro.frmConsultarDespesas();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void inserirEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Inserir Estoque";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
             Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830" ||
             Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "4721")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Inserir.Estoque.frmCompraEstoque start = new Inserir.Estoque.frmCompraEstoque();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void compraEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Compra Estoque";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830" ||
              Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "4721")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Consultar.Estoque.frmCompraEstoque start = new Consultar.Estoque.frmCompraEstoque();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
                }
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

        private void removerFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Remover Fornecedor";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
                    Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830" ||
                    Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "4721")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Remover.Estoque.frmFornecedores start = new Remover.Estoque.frmFornecedores();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        Business.logBusiness logBusiness = new Business.logBusiness();
        private void alterarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Alterar Funcionário";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
                   Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Alterar.RH.frmAlterarFuncionarios start = new Alterar.RH.frmAlterarFuncionarios();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void inserirFolhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Inserir Folha de Pagamento";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
                   Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Inserir.RH.frmInserirFolhaDePagamento start = new Inserir.RH.frmInserirFolhaDePagamento();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //mciSendString("open new Type waveaudio alias meuaudio", null, 0, IntPtr.Zero);
            //mciSendString("record meuaudio", null, 0, IntPtr.Zero);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
           // mciSendString("save meuaudio nsf_voz_texto.wav", null, 0, IntPtr.Zero);
            //mciSendString("close meuaudio", null, 0, IntPtr.Zero);

            //IamAuthenticator authenticator = new IamAuthenticator(
             //   apikey: "ou8NRQ-wvrcb4DWjLdPJaLVZhEqBN_xO2dvZockjax6N");

//            SpeechToTextService service = new SpeechToTextService(authenticator);
//            service.SetServiceUrl("https://stream.watsonplatform.net/speech-to-text/api");

//            var result = service.Recognize(
//            audio: File.ReadAllBytes("nsf_voz_texto.wav"),
//            contentType: "audio/flac",
//            model: "pt-BR_NarrowbandModel"
//            );
//
//            string texto = result.Result.Results.First().Alternatives.First().Transcript;

//            lblTeste.Text = texto;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //FalarMensagem();
        }

        private async void FalarMensagem()
        {
            //Rd6JgXi2SiivDo02qoGlf2fzh88qf71rNhOVEhuPrzQG

            string texto = "Seja bem-vindo";
            IamAuthenticator authenticator = new IamAuthenticator(
              apikey: "Rd6JgXi2SiivDo02qoGlf2fzh88qf71rNhOVEhuPrzQG");

                    TextToSpeechService service = new TextToSpeechService(authenticator);
                  service.SetServiceUrl("https://stream.watsonplatform.net/text-to-speech/api");

                  var result = service.Synthesize(
                    text: texto,
                  accept: "audio/wav",
                voice: "pt-BR_IsabelaVoice"
              );

            using (FileStream fs = File.Create("nsf_texto_voz.wav"))//Cria um arquivo físico no meu HD
            {
                result.Result.WriteTo(fs);
                fs.Close();
                result.Result.Close();
            }

            AudioPlayer player = new AudioPlayer();
            await player.SetFileAsync("nsf_texto_voz.wav", "nsf_texto_voz.wav"); //Rodam ao mesmo tempo (as duas linhas)
            await player.PlayAsync();
        }

        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        private static extern long mciSendString(string comando, StringBuilder sb, int lenght, IntPtr cb);

        private void alterarDespessaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Alterar Depesas";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
                   Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Alterar.Financeiro.frmAlterarDespesas start = new Alterar.Financeiro.frmAlterarDespesas();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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

        private void balançoPatrimonialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_log log = new Database.Entity.tb_log();
                log.ds_tela = "Balanço Patrimonial";
                log.dt_entrada = DateTime.Now;
                log.id_usuario = Modelos.Usuario.UsuarioModelo.id_usuario;
                if (Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "8762" ||
                   Modelos.Usuario.UsuarioModelo.tb_funcionario.tb_cargo.ds_codigo_cargo == "1830")
                {
                    logBusiness.Inserir(log);
                    Hide();
                    Consultar.Financeiro.frmBalancoPatrimonial start = new Consultar.Financeiro.frmBalancoPatrimonial();
                    start.Show();
                }
                else
                {
                    throw new ArgumentException("Você não possui permissão para entrar nessa tela");
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
    }
}
