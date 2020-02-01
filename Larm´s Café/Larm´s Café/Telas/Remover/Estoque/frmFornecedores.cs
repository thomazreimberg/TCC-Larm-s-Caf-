using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Remover.Estoque
{
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
            dgvFornecedores.AutoGenerateColumns = false;
            dgvFornecedores.DataSource = fornecedorBusiness.ConsultarTodos();
        }

        Business.fornecedorBusiness fornecedorBusiness = new Business.fornecedorBusiness();

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(nudID.Value);
                fornecedorBusiness.RemoverFornecedor(id);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Esse fornecedor está registrado no seu histórico de vendas, por isso não é possível remover esse registro");
            }
        }

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string fornecedor = txtFornecedor.Text;


                if (string.IsNullOrWhiteSpace(fornecedor))
                {
                    dgvFornecedores.AutoGenerateColumns = false;
                    dgvFornecedores.DataSource = fornecedorBusiness.ConsultarTodos();
                }
                else
                {
                    dgvFornecedores.AutoGenerateColumns = false;
                    dgvFornecedores.DataSource = fornecedorBusiness.ConsultarFornecedores(fornecedor);
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

        private void dgvFornecedores_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nudID.Value = Convert.ToInt32(dgvFornecedores.CurrentRow.Cells[0].Value);
            MessageBox.Show("Fornecedor selecionado, clique em remover para deletar esse registro.");
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
