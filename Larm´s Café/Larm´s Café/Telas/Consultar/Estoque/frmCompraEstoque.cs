using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Consultar.Estoque
{
    public partial class frmCompraEstoque : Form
    {
        public frmCompraEstoque()
        {
            InitializeComponent();
            CarregarCampos();
        }

        Business.estoqueBusiness estoqueBusiness = new Business.estoqueBusiness();
        Business.materiaPrimaBusiness materiaPrimaBusiness = new Business.materiaPrimaBusiness();

        private void CarregarCampos()
        {
            try
            {
                cboCategoria.ValueMember = nameof(Database.Entity.tb_materia_prima.ds_categoria);
                cboCategoria.DataSource = materiaPrimaBusiness.ListarTodos();

                //Carrega o DGV alterando a cor das linhas
                dgvEstoque.AutoGenerateColumns = false;

                var lista = estoqueBusiness.ConsultarTodos();
                int posicao = 0;
                foreach (var item in lista)
                {
                    if(item.qt_estoque <= 4)
                    {
                        dgvEstoque.Rows[posicao].DefaultCellStyle.BackColor = Color.Red;
                    }

                    dgvEstoque.DataSource = item;

                    posicao++;
                }
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

        private void lblFechar_Click(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEstoque.AutoGenerateColumns = false;
                dgvEstoque.DataSource = estoqueBusiness.ConsultarEstoque(txtProduto.Text, cboCategoria.Text, chkUrgente.Checked, chkAbastecer.Checked);
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

        private void label8_Click(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
