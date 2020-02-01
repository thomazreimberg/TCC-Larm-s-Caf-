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
    public partial class frmAlterarFornecedor : Form
    {
        public frmAlterarFornecedor()
        {
            InitializeComponent();
            dgvFornecedores.AutoGenerateColumns = false;
            dgvFornecedores.DataSource = fornecedorBusiness.ConsultarTodos();
        }

        Business.fornecedorBusiness fornecedorBusiness = new Business.fornecedorBusiness();

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_fornecedores fornecedores = new Database.Entity.tb_fornecedores();
                fornecedores.id_fornecedores = Convert.ToInt32(nudID.Value);
                fornecedores.nm_empresa_fornecedor = txtFornecedor.Text;
                fornecedores.ds_cnpj = txtCnpj.Text;
                fornecedores.ds_marca_fornecida = txtMarca.Text;
                fornecedores.ds_telefone = txtTelefone.Text;

                fornecedorBusiness.AlterarFornecedores(fornecedores);
                MessageBox.Show("Fornecedor alterado");
                dgvFornecedores.AutoGenerateColumns = false;
                dgvFornecedores.DataSource = fornecedorBusiness.ConsultarTodos();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu uum erro");
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string fornecedor = txtFornecedorFiltro.Text;

                dgvFornecedores.AutoGenerateColumns = false;
                dgvFornecedores.DataSource = fornecedorBusiness.ConsultarFornecedores(fornecedor);
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(nudID.Value);
                fornecedorBusiness.RemoverFornecedor(id);
                MessageBox.Show("Fornecedor removido");
                dgvFornecedores.AutoGenerateColumns = false;
                dgvFornecedores.DataSource = fornecedorBusiness.ConsultarTodos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void dgvFornecedores_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                nudID.Value = Convert.ToInt32(dgvFornecedores.CurrentRow.Cells[0].Value);
                txtFornecedor.Text = dgvFornecedores.CurrentRow.Cells[1].Value.ToString();
                txtMarca.Text = dgvFornecedores.CurrentRow.Cells[2].Value.ToString();
                txtCnpj.Text = dgvFornecedores.CurrentRow.Cells[3].Value.ToString();
                txtTelefone.Text = dgvFornecedores.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void lblFechar_Click_1(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void lblMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
