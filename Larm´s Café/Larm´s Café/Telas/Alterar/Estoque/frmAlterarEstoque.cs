using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Alterar.Estoque
{
    public partial class frmAlterarEstoque : Form
    {
        public frmAlterarEstoque()
        {
            InitializeComponent();
        }

        Business.estoqueBusiness estoqueBusiness = new Business.estoqueBusiness();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string produto = txtProduto.Text;
                string categoria = cboCategoria.Text;
                bool urgente = chkUrgente.Checked;
                bool abastecer = chkAbastecer.Checked;

                dgvEstoque.AutoGenerateColumns = false;
                dgvEstoque.DataSource = estoqueBusiness.ConsultarEstoque(produto, categoria, urgente, abastecer);
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
                Database.Entity.tb_materia_prima combo = cboProduto.SelectedItem as Database.Entity.tb_materia_prima;
                Database.Entity.tb_estoque estoque = new Database.Entity.tb_estoque();
                estoque.bt_abastecer = chkAbastecer.Checked;
                estoque.bt_urgente = chkUrgente.Checked;
                estoque.ds_especificacao = txtEspecificacao.Text;
                estoque.ds_situacao_produto = txtSituacao.Text;
                estoque.dt_validade_prevista = dtpVencimento.Value.Date;
                estoque.qt_estoque = Convert.ToInt32(nudQuantidade.Value);
                estoque.vl_total = Convert.ToInt32(nudTotal.Value);
                estoque.id_materia_prima = combo.id_materia_prima;

                estoqueBusiness.Alterar(estoque);
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

        private void dgvEstoque_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var func = dgvEstoque.CurrentRow.DataBoundItem as Database.Entity.tb_estoque;

            cboProduto.Text = func.tb_materia_prima.nm_produto;
            
        }
    }
}
