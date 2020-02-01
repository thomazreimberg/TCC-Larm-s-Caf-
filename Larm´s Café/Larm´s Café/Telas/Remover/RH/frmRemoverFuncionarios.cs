using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Remover.RH
{
    public partial class frmRemoverFuncionarios : Form
    {
        public frmRemoverFuncionarios()
        {
            InitializeComponent();
            dgvFuncionarios.AutoGenerateColumns = false;
            dgvFuncionarios.DataSource = funcionarioBusiness.ConsultarTodos();
            cboCargo.ValueMember = nameof(Database.Entity.tb_cargo.ds_cargo);
            cboCargo.DataSource = funcionarioBusiness.ConsultarTodos();
        }

        Business.funcionarioBusiness funcionarioBusiness = new Business.funcionarioBusiness();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_funcionario funcionario = cboCargo.SelectedItem as Database.Entity.tb_funcionario;
            dgvFuncionarios.AutoGenerateColumns = false;
            dgvFuncionarios.DataSource = funcionarioBusiness.ConsultarFuncionario(funcionario.nm_funcionario, funcionario.id_cargo);
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(nudIdFuncionario.Value);
                funcionarioBusiness.RemoverFuncionario(id);
                MessageBox.Show("Funcionário Removido  com sucesso!");
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

        private void DgvFuncionarios_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                nudIdFuncionario.Value = Convert.ToInt32(dgvFuncionarios.CurrentRow.Cells[0].Value);
                MessageBox.Show("Funcionário escolhido, clique em remover para apagar esse registro");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente");
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
