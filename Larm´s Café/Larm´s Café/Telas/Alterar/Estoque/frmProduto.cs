using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Alterar.Estoque
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
            CarregarCampos();
        }

        Business.produtoBusiness produtoBusiness = new Business.produtoBusiness();

        public void CarregarCampos()
        {
            dgvProduto.AutoGenerateColumns = false;
            dgvProduto.DataSource = produtoBusiness.ListarTodos();
            cboCategoria.ValueMember = nameof(Database.Entity.tb_produto.ds_categoria);
            cboCategoria.DataSource = produtoBusiness.ListarTodos();
            cboCategoriaFiltro.ValueMember = nameof(Database.Entity.tb_produto.ds_categoria);
            cboCategoriaFiltro.DataSource = produtoBusiness.ListarTodos();
        }


        private void LimparCampos()
        {
            txtObservacao.Text = string.Empty;
            nudID.Value = 0;
            txtProduto.Text = string.Empty;
            nudPreco.Value = 0.00m;
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string produto = txtProdutoFiltro.Text;
                string categoria = cboCategoriaFiltro.Text;

                dgvProduto.AutoGenerateColumns = false;
                dgvProduto.DataSource = produtoBusiness.ConsultarProduto(produto, categoria);
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

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_produto produto = new Database.Entity.tb_produto();
                produto.id_produtos = Convert.ToInt32(nudID.Value);
                produto.nm_produto = txtProduto.Text;
                produto.vl_preco = nudPreco.Value;
                produto.ds_categoria = cboCategoria.Text;
                produto.ds_observacao = txtObservacao.Text;

                produtoBusiness.AlterarProduto(produto);
                dgvProduto.AutoGenerateColumns = false;
                dgvProduto.DataSource = produtoBusiness.ListarTodos();
                MessageBox.Show("Produto alterado");
                LimparCampos();
                //lblAlterou.Text = "--";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Oorreu um erro");
            }
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            try
            {
                //if (lblAlterou.Text == "Alterou")
         //           throw new ArgumentException("Não é possivel remover um produto em que os campos forão alterados");

                produtoBusiness.RemoverProduto(Convert.ToInt32(nudID.Value));
                MessageBox.Show("Produto removido");
                dgvProduto.AutoGenerateColumns = false;
                dgvProduto.DataSource = produtoBusiness.ListarTodos();
                LimparCampos();
               // lblAlterou.Text = "--";
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

        private void txtProduto_TextChanged_1(object sender, EventArgs e)
        {
           // lblAlterou.Text = "Alterou";

        }

        private void cboCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //lblAlterou.Text = "Alterou";

        }

        private void txtObservacao_TextChanged_1(object sender, EventArgs e)
        {
            //lblAlterou.Text = "Alterou";

        }

        private void nudPreco_ValueChanged_1(object sender, EventArgs e)
        {
            //lblAlterou.Text = "Alterou";

        }

        private void dgvProduto_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Database.Entity.tb_produto produto = new Database.Entity.tb_produto();
                produto.id_produtos = Convert.ToInt32(dgvProduto.CurrentRow.Cells[0].Value);
                produto.nm_produto = dgvProduto.CurrentRow.Cells[1].Value.ToString();
                produto.vl_preco = Convert.ToDecimal(dgvProduto.CurrentRow.Cells[2].Value);
                produto.ds_observacao = dgvProduto.CurrentRow.Cells[3].Value.ToString();
                produto.ds_categoria = dgvProduto.CurrentRow.Cells[4].Value.ToString();

                txtProduto.Text = produto.nm_produto;
                txtObservacao.Text = produto.ds_observacao;
                nudPreco.Value = produto.vl_preco;
                cboCategoria.Text = produto.ds_categoria;
                nudID.Value = produto.id_produtos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }
    }
}
