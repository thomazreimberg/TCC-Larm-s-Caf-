using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Consultar.Outro
{
    public partial class frmConsultarCliente : Form
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
            dgvCliente.AutoGenerateColumns = false;
            dgvCliente.DataSource = clienteBusiness.ListarTodos(); 
        }

        Business.clienteBusiness clienteBusiness = new Business.clienteBusiness();

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                bool ativo = chkAtivo.Checked;
                bool fidelizado = chkFidelizado.Checked;

                dgvCliente.AutoGenerateColumns = false;
                dgvCliente.DataSource = clienteBusiness.ConsultarCliente(nome, ativo, fidelizado);
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


        private void label13_Click(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
