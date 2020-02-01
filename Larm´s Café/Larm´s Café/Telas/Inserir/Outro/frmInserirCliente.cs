using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Inserir.Outro
{
    public partial class frmInserirCliente : Form
    {
        public frmInserirCliente()
        {
            InitializeComponent();
        }

        Business.clienteBusiness clienteBusiness = new Business.clienteBusiness();

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_cliente cliente = new Database.Entity.tb_cliente();

                cliente.bt_ativo = chkAtivo.Checked;
                cliente.bt_fidelizado = chkFidelizado.Checked;
                cliente.nm_cliente = txtNome.Text;
                cliente.dt_primeira_compra = dtpPrimeiraCompra.Value.Date;
                cliente.ds_endereco = txtEndereco.Text;
                cliente.ds_telefone = txtTelefone.Text;
                cliente.ds_email = txtEmail.Text;

                clienteBusiness.InserirCliente(cliente);
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
