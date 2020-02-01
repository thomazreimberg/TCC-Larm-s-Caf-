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
    public partial class frmFluxoDeCaixa : Form
    {
        public frmFluxoDeCaixa()
        {
            InitializeComponent();
        }
        Business.fluxoDeCaixaBusiness fluxoDeCaixaBusiness = new Business.fluxoDeCaixaBusiness();
        private void frmFluxoDeCaixa_Load(object sender, EventArgs e)
        {
            Business.fluxoDeCaixaBusiness fluxoDeCaixaBusiness = new Business.fluxoDeCaixaBusiness();
            List<Database.Entity.vw_fluxo_de_caixa> lista = fluxoDeCaixaBusiness.ConsultarTodos();
            dgvFluxoCaixa.AutoGenerateColumns = false;
            dgvFluxoCaixa.DataSource = lista;
        }
              
        private void btnButao_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpInicio.Value.Date;
            DateTime final = dtpFinal.Value.Date;

            List<Database.Entity.vw_fluxo_de_caixa> lista = fluxoDeCaixaBusiness.ConsultarViewFluxoDeCaixa(inicio, final);
            dgvFluxoCaixa.AutoGenerateColumns = false;
            dgvFluxoCaixa.DataSource = lista;
            
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
