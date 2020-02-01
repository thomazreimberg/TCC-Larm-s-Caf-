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
    public partial class frmInserirVendaProduto : Form
    {
        public frmInserirVendaProduto()
        {
            InitializeComponent();
            CarregarCampos();
        }

        Business.produtoBusiness produtoBusiness = new Business.produtoBusiness();
        Business.funcionarioBusiness funcionarioBusiness = new Business.funcionarioBusiness();
        Business.clienteBusiness clienteBusiness = new Business.clienteBusiness();
        Business.vendaBusiness vendaBusiness = new Business.vendaBusiness();
        Business.vendaProdutoBusiness vendaProdutoBusiness = new Business.vendaProdutoBusiness();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_produto produto = cboProduto.SelectedItem as Database.Entity.tb_produto;

                Database.Entity.tb_venda_produto vendaProduto = new Database.Entity.tb_venda_produto();
                vendaProduto.id_produtos = produto.id_produtos;
                vendaProduto.tb_produto = produto;

                vendaProduto.qt_produto = Convert.ToInt32(nudQuantidade.Value);
                nudTotal.Value += nudPreco.Value * Convert.ToInt32(nudQuantidade.Value);
                vendaProduto.vl_total = nudTotalProduto.Value;

                var produtos = dgvListaDeProdutos.DataSource as List<Database.Entity.tb_venda_produto>;
                if (produtos == null)
                    produtos = new List<Database.Entity.tb_venda_produto>();
                produtos.Add(vendaProduto);


                dgvListaDeProdutos.AutoGenerateColumns = false;
                dgvListaDeProdutos.DataSource = null;
                dgvListaDeProdutos.DataSource = produtos;

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

        private void CarregarCampos()
        {
            try
            {
                cboProduto.ValueMember = nameof(Database.Entity.tb_produto.nm_produto);
                cboProduto.DataSource = produtoBusiness.ListarTodos();

                cboFuncionario.ValueMember = nameof(Database.Entity.tb_funcionario.nm_funcionario);
                cboFuncionario.DataSource = funcionarioBusiness.ConsultarTodos();

                cboCliente.ValueMember = nameof(Database.Entity.tb_cliente.nm_cliente);
                cboCliente.DataSource = clienteBusiness.ListarTodos();

                cboCategoria.ValueMember = nameof(Database.Entity.tb_produto.ds_categoria);
                cboCategoria.DataSource = produtoBusiness.ListarTodos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_funcionario funcionario = cboFuncionario.SelectedItem as Database.Entity.tb_funcionario;
                Database.Entity.tb_venda venda = new Database.Entity.tb_venda();
                venda.qt_parcelas = Convert.ToInt32(nudParcelas.Value);
                venda.vl_total_venda = nudTotal.Value;
                venda.dt_venda = dtpDataDeVenda.Value;
                venda.ds_modo_pagamento = cboModoDePagamento.Text;
                venda.id_funcionario = funcionario.id_funcionario;

                vendaBusiness.InserirVenda(venda);

                var produtos = dgvListaDeProdutos.DataSource as List<Database.Entity.tb_venda_produto>;
                foreach (var item in produtos)
                {

                    item.id_venda = venda.id_venda;
                    item.tb_produto = null;

                    vendaProdutoBusiness.InserirVendaProduto(item);
                }

                MessageBox.Show("Venda efetuada com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListaDeProdutos.DataSource = null;

                cboModoDePagamento.Text = string.Empty;
                nudParcelas.Value = 0;
                nudQuantidade.Value = 1;
                nudTotal.Value = 0.00m;
                nudTotalProduto.Value = 0.00m;
                nudTroco.Value = 0.00m;
                nudValorPago.Value = 0.00m;
                
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

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.Entity.tb_produto produto = cboProduto.SelectedItem as Database.Entity.tb_produto;

            nudPreco.Value = produto.vl_preco;
            txtObservacao.Text = produto.ds_observacao;
            nudTotalProduto.Value = produto.vl_preco;
            nudQuantidade.Value = 1;
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            decimal preco = nudPreco.Value;
            int quantidade = Convert.ToInt32(nudQuantidade.Value);
            nudTotalProduto.Value = preco * quantidade;
        }

        private void LblFechar_Click_1(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void LblMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void nudValorPago_ValueChanged(object sender, EventArgs e)
        {
            decimal valorTroco = nudValorPago.Value - nudTotal.Value;
            if (valorTroco <= 0.00m)
            {
                nudTroco.Value = 0.00m;
            }
            else
            {
                nudTroco.Value = valorTroco;
            }
        }

        private void nudValorPago_Leave(object sender, EventArgs e)
        {
            decimal valorTroco = nudValorPago.Value - nudTotal.Value;
            if (valorTroco <= 0.00m)
            {
                nudTroco.Value = 0.00m;
            }
            else
            {
                nudTroco.Value = valorTroco;
            }
        }

        private void cboModoDePagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModoDePagamento.Text == "Cartão")
                nudParcelas.Enabled = true;
            else
                nudParcelas.Enabled = false;
        }

        private void frmInserirVendaProduto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
