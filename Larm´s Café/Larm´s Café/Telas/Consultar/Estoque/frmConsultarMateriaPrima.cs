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
    public partial class frmConsultarMateriaPrima : Form
    {
        public frmConsultarMateriaPrima()
        {
            InitializeComponent();
            CarregarCampos();
        }

        Business.materiaPrimaBusiness materiaPrimaBusiness = new Business.materiaPrimaBusiness();
        
        private void CarregarCampos()
        {
            dgvMateriaPrima.AutoGenerateColumns = false;
            dgvMateriaPrima.DataSource = materiaPrimaBusiness.ListarTodos();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string produto = txtProduto.Text;
                string categoria = cboCategoria.Text;

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

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtProduto.Text == string.Empty)
            {
                dgvMateriaPrima.AutoGenerateColumns = false;
                dgvMateriaPrima.DataSource = materiaPrimaBusiness.ListarTodos();
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
    }
}
