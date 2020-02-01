using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Consultar.Financeiro
{
    public partial class frmConsultarDespesas : Form
    {
        public frmConsultarDespesas()
        {
            try
            {
                InitializeComponent();
                dgvConsultarDespesas.AutoGenerateColumns = false;
                dgvConsultarDespesas.DataSource = despesaBusiness.ListarTodos();

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }


        Business.despesaBusiness despesaBusiness = new Business.despesaBusiness();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvConsultarDespesas.AutoGenerateColumns = false;
                dgvConsultarDespesas.DataSource = despesaBusiness.ConsultarDespesa(txtNomeReferencia.Text, dtpData.Value.Date);
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

        private void label6_Click(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
