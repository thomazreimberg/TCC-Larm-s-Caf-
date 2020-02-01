using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Alterar.Outro
{
    public partial class frmAlterarCliente : Form
    {
        public frmAlterarCliente()
        {
            InitializeComponent();
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

        Business.clienteBusiness clienteBusiness = new Business.clienteBusiness();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = txtClienteFiltro.Text;
                bool ativo = chkAtivo.Checked;
                bool fidelizado = chkFidelizado.Checked;

                dgvCliente.AutoGenerateColumns = false;
                dgvCliente.DataSource = clienteBusiness.ConsultarCliente(cliente, ativo, fidelizado);
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_cliente cliente = new Database.Entity.tb_cliente();
                cliente.id_cliente = Convert.ToInt32(nudID.Value);
                cliente.nm_cliente = txtNome.Text;
                cliente.ds_telefone = txtTelefone.Text;
                cliente.ds_endereco = txtEndereco.Text;
                cliente.ds_email = txtEmail.Text;
                cliente.bt_fidelizado = chkFidelizado.Checked;
                cliente.bt_ativo = chkAtivo.Checked;

                clienteBusiness.AlterarCliente(cliente, cliente.id_cliente);
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

        private void dgvCliente_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var func = dgvCliente.CurrentRow.DataBoundItem as Database.Entity.tb_cliente;
                nudID.Value = func.id_cliente;
                txtNome.Text = func.nm_cliente;
                txtTelefone.Text = func.ds_telefone;
                txtEndereco.Text = func.ds_endereco;
                txtEmail.Text = func.ds_email;
                chkAtivo.Checked = func.bt_ativo;
                chkFidelizado.Checked = func.bt_fidelizado;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }
    }
}
