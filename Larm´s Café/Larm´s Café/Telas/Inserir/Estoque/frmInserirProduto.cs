using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Inserir.Estoque
{
    public partial class frmInserirProduto : Form
    {
        public frmInserirProduto()
        {
            InitializeComponent();
        }

        Business.produtoBusiness produtoBusiness = new Business.produtoBusiness();

        private void lblFechar_Click(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_produto produto = new Database.Entity.tb_produto();

                produto.nm_produto = txtProduto.Text;
                produto.vl_preco = nudPreco.Value;
                produto.ds_categoria = txtCategoria.Text;
                produto.ds_observacao = txtObservacao.Text;

                produtoBusiness.InserirProduto(produto);
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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_produto produto = new Database.Entity.tb_produto();

                produto.nm_produto = txtProduto.Text;
                produto.vl_preco = nudPreco.Value;
                produto.ds_categoria = txtCategoria.Text;
                produto.ds_observacao = txtObservacao.Text;

                produtoBusiness.InserirProduto(produto);
                MessageBox.Show("Produto Inserido");
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
