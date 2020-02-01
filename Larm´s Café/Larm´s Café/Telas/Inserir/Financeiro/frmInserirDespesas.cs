using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Inserir.Financeiro
{
    public partial class frmInserirDespesas : Form
    {
        public frmInserirDespesas()
        {
            InitializeComponent();
            dgvInserirDespesas.AutoGenerateColumns = false;
            dgvInserirDespesas.DataSource = despesaBusiness.ListarTodos();
        }

        Business.despesaBusiness despesaBusiness = new Business.despesaBusiness();
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_despesa despesa = new Database.Entity.tb_despesa();

                despesa.ds_previsto = nudPrevisto.Value;
                despesa.ds_realizado = nudRealizado.Value;
                despesa.dt_entrada = dtpData.Value.Date;
                despesa.nm_referencia = txtNomeReferencia.Text;
                despesa.dt_saida = dtpSaida.Value.Date;

                despesaBusiness.Inserir(despesa);

                dgvInserirDespesas.AutoGenerateColumns = false;
                dgvInserirDespesas.DataSource = despesaBusiness.ListarTodos();
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

        private void LblFechar_Click_1(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void LblMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
    }
}
