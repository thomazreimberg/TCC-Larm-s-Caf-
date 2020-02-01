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
    public partial class frmMateriaPrima : Form
    {
        public frmMateriaPrima()
        {
            InitializeComponent();
            cboCategoria.ValueMember = nameof(Database.Entity.tb_materia_prima.ds_categoria);
            cboCategoria.DataSource = materiaPrimaBusiness.ListarTodos();
            cboCategoriaFiltro.ValueMember = nameof(Database.Entity.tb_materia_prima.ds_categoria);
            cboCategoriaFiltro.DataSource = materiaPrimaBusiness.ListarTodos();
            dgvMateriaPrima.AutoGenerateColumns = false;
            dgvMateriaPrima.DataSource = materiaPrimaBusiness.ListarTodos();
        }

        Business.materiaPrimaBusiness materiaPrimaBusiness = new Business.materiaPrimaBusiness();
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_materia_prima produto = new Database.Entity.tb_materia_prima();
                produto.id_materia_prima = Convert.ToInt32(nudID.Value);
                produto.nm_produto = txtProduto.Text;
                produto.vl_preco = nudPreco.Value;
                produto.ds_categoria = cboCategoria.Text;

                materiaPrimaBusiness.AlterarMateriaPrima(produto);
                MessageBox.Show("Matéria prima removida com sucesso!");
                dgvMateriaPrima.AutoGenerateColumns = false;
                dgvMateriaPrima.DataSource = materiaPrimaBusiness.ListarTodos();
                lblAlterou.Text = "--";
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string produto = txtProdutoFiltro.Text;
                string categoria = cboCategoriaFiltro.Text;

                dgvMateriaPrima.AutoGenerateColumns = false;
                dgvMateriaPrima.DataSource = materiaPrimaBusiness.ConsultarMateriaPrima(produto, categoria);
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
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dgvMateriaPrima_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Database.Entity.tb_materia_prima produto = new Database.Entity.tb_materia_prima();
                produto.id_materia_prima = Convert.ToInt32(dgvMateriaPrima.CurrentRow.Cells[0].Value);
                produto.nm_produto = dgvMateriaPrima.CurrentRow.Cells[1].Value.ToString();
                produto.vl_preco = Convert.ToDecimal(dgvMateriaPrima.CurrentRow.Cells[2].Value);
                produto.ds_categoria = dgvMateriaPrima.CurrentRow.Cells[3].Value.ToString();

                txtProduto.Text = produto.nm_produto;
                nudPreco.Value = produto.vl_preco;
                cboCategoria.Text = produto.ds_categoria;
                nudID.Value = produto.id_materia_prima;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            lblAlterou.Text = "Alterou";
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAlterou.Text = "Alterou";
        }

        private void nudPreco_ValueChanged(object sender, EventArgs e)
        {
            lblAlterou.Text = "Alterou";
        }

        private void nudID_ValueChanged(object sender, EventArgs e)
        {
            lblAlterou.Text = "Alterou";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblAlterou.Text == "Alterou")
                    throw new ArgumentException("Não é possivel remover um produto em que os campos forão alterados");

                materiaPrimaBusiness.RemoverMateriaPrima(Convert.ToInt32(nudID.Value));
                MessageBox.Show("Matéria prima removida com sucesso!");
                lblAlterou.Text = "--";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
