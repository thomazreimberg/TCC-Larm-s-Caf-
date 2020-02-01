using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Inserir.Estoque
{
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }
        Business.fornecedorBusiness fornecedorBusiness = new Business.fornecedorBusiness();
        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_fornecedores fornecedores = new Database.Entity.tb_fornecedores();
                fornecedores.nm_empresa_fornecedor = txtFornecedor.Text;
                fornecedores.ds_marca_fornecida = txtMarca.Text;
                fornecedores.ds_telefone = txtTelefone.Text;
                fornecedores.ds_cnpj = txtCnpj.Text;

                fornecedorBusiness.InserirFornecedor(fornecedores);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
