using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Consultar.Estoque
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string fornecedor = txtFornecedor.Text;

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

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {
            if(txtFornecedor.Text == string.Empty)
            {
                dgvFornecedores.AutoGenerateColumns = false;
                dgvFornecedores.DataSource = fornecedorBusiness.ConsultarTodos();
            }
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void frmFornecedores_Load(object sender, EventArgs e)
        {

        }

        private void lblFechar_Click_1(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
