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
    public partial class frmCompraEstoque : Form
    {
        public frmCompraEstoque()
        {
            InitializeComponent();
            CarregarCampos();
        }

        Business.materiaPrimaBusiness materiaPrimaBusiness = new Business.materiaPrimaBusiness();
        Business.estoqueBusiness estoqueBusiness = new Business.estoqueBusiness();

        private void CarregarCampos()
        {
            try
            {
                cboProduto.ValueMember = nameof(Database.Entity.tb_materia_prima.nm_produto);
                cboProduto.DataSource = materiaPrimaBusiness.ListarTodos();
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

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnInserir_Click(object sender, EventArgs e)
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

                estoqueBusiness.InserirEstoque(estoque);
                MessageBox.Show("Registro inserido com sucesso");
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

        private void lblNovoProduto_Click(object sender, EventArgs e)
        {
            Hide();
            frmInserirMateriaPrima start = new frmInserirMateriaPrima();
            start.Show();
        }
    }
}
