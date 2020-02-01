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
    public partial class frmConsultarProduto : Form
    {
        public frmConsultarProduto()
        {
            try
            {
                InitializeComponent();
                dgvProduto.AutoGenerateColumns = false;
                dgvProduto.DataSource = produtoBusiness.ListarTodos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string produto = txtProduto.Text;
                string categoria = cboCategoria.Text;

                dgvProduto.AutoGenerateColumns = false;
                dgvProduto.DataSource = produtoBusiness.ConsultarProduto(produto, categoria);
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

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtProduto.Text == string.Empty)
                {
                    dgvProduto.AutoGenerateColumns = false;
                    dgvProduto.DataSource = produtoBusiness.ListarTodos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
            
        }
    }
}
