using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Remover.Financeiro
{
    public partial class frmRemoverDespesas : Form
    {
        public frmRemoverDespesas()
        {
            InitializeComponent();
        }

        Business.despesaBusiness despesaBusiness = new Business.despesaBusiness();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string referencia = txtReferenciaFiltro.Text;
                DateTime date = dtpDataFiltro.Value.Date;
                dgvDespesas.AutoGenerateColumns = false; ;
                dgvDespesas.DataSource = despesaBusiness.ConsultarDespesa(referencia, date);
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
         
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(nudID.Value);
                despesaBusiness.RemoverDespesa(id);
                MessageBox.Show("Registro removido");
                nudID.Value = 0;
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

        private void dgvDespesas_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                nudID.Value = Convert.ToInt32(dgvDespesas.CurrentRow.Cells[0].Value);
                txtNomeReferencia.Text = dgvDespesas.CurrentRow.Cells[1].Value.ToString();
                txtPrevisto.Text = dgvDespesas.CurrentRow.Cells[2].Value.ToString();
                txtRealizado.Text = dgvDespesas.CurrentRow.Cells[3].Value.ToString();
                dtpData.Value = Convert.ToDateTime(dgvDespesas.CurrentRow.Cells[4].Value);
                MessageBox.Show("Campos carregados, clique em Remover para apagar esse registro");
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
