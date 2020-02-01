using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Alterar.Financeiro
{
    public partial class frmAlterarDespesas : Form
    {
        public frmAlterarDespesas()
        {
            InitializeComponent();
            Carregar();
        }

        private void Carregar()
        {
            try
            {
                dgvDespesas.AutoGenerateColumns = false;
                dgvDespesas.DataSource = despesaBusiness.ListarTodos(); 
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

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        Business.despesaBusiness despesaBusiness = new Business.despesaBusiness();
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string referenica = txtReferencia.Text;

                dgvDespesas.AutoGenerateColumns = false;
                dgvDespesas.DataSource = despesaBusiness.ConsultarPorReferencia(referenica);
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
                var func = dgvDespesas.CurrentRow.DataBoundItem as Database.Entity.tb_despesa;

                txtNomeDeReferencia.Text = func.nm_referencia;
                nudPrevisto.Value = func.ds_previsto;
                nudRealizado.Value = func.ds_realizado;
                dtpData.Value = func.dt_saida;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_despesa despesa = new Database.Entity.tb_despesa();
                despesa.id_fluxo_caixa = Convert.ToInt32(nudID.Value);
                despesa.nm_referencia = txtNomeDeReferencia.Text;
                despesa.ds_previsto = nudPrevisto.Value;
                despesa.ds_realizado = nudRealizado.Value;
                despesa.dt_saida = dtpData.Value;

                despesaBusiness.AlterarDespesa(despesa);
                MessageBox.Show("Despesa alterada");
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
    }
}
