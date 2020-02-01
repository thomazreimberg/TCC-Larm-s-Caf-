using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Consultar.RH
{
    public partial class frmConsultarFuncionarios : Form
    {
        public frmConsultarFuncionarios()
        {
            InitializeComponent();
            Carregarcargos();
            dgvConsultarFuncionarios.AutoGenerateColumns = false;
            dgvConsultarFuncionarios.DataSource = funcionarioBusiness.ConsultarTodos();
        }

        Business.cargoBusiness cargoBusiness = new Business.cargoBusiness();
        Business.funcionarioBusiness funcionarioBusiness = new Business.funcionarioBusiness();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_cargo func = cboCargo.SelectedItem as Database.Entity.tb_cargo;
            string nome = txtNome.Text.Trim();

            List<Database.Entity.tb_funcionario> lista = cargoBusiness.ConsultarCargoEFuncionario(nome, func.ds_cargo); 
            dgvConsultarFuncionarios.AutoGenerateColumns = false;

            dgvConsultarFuncionarios.DataSource = lista;
        }

        private void Carregarcargos()
        {
            List<Database.Entity.tb_cargo> lista = cargoBusiness.ConsultarTodos();

            cboCargo.ValueMember = nameof(Database.Entity.tb_cargo.ds_cargo);
            cboCargo.DataSource = lista;
        }

        private void label28_Click(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
