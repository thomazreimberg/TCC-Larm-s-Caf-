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
    public partial class frmBalancoPatrimonial : Form
    {
        public frmBalancoPatrimonial()
        {
            InitializeComponent();
        }

        Business.balancoPatrimonialBusiness balancoPatrimonialBusiness = new Business.balancoPatrimonialBusiness();

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

        private void cboAnoBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboAnoBuscar.Text == string.Empty)
                    throw new ArgumentException("Selecione um ano para carregar os campos");
                int ano = Convert.ToInt32(cboAnoBuscar.Text);

                dgvAtivos.AutoGenerateColumns = false;
                dgvAtivos.DataSource = balancoPatrimonialBusiness.ConsultarAtivo(ano);
                
                dgvPassivos.AutoGenerateColumns = false;
                dgvPassivos.DataSource = balancoPatrimonialBusiness.ConsultarPassivo(ano);

                decimal somaAtivo = balancoPatrimonialBusiness.ConsultarAtivo(ano).Sum(x => x.vl_valor);
                decimal somaPassivo = balancoPatrimonialBusiness.ConsultarPassivo(ano).Sum(x => x.vl_valor);

                lblTotalAtivo.Text = somaAtivo.ToString();
                lblTotalPassivo.Text = somaPassivo.ToString();

                decimal totalLiquido = somaAtivo - somaPassivo;

                lblTotalLiquido.Text = totalLiquido.ToString();

                Database.Entity.tb_balanco_patrimonial balanco = new Database.Entity.tb_balanco_patrimonial();
                balanco.id_balanco_patrimonial = 1;
                balanco.ds_categoria = "Total";
                balanco.dt_data = DateTime.Now.Date;
                balanco.nm_referencia = "Total";
                balanco.vl_valor = totalLiquido;

                List<Database.Entity.tb_balanco_patrimonial> lista = new List<Database.Entity.tb_balanco_patrimonial>();
                lista.Add(balanco);

                dgvPatrimonioLiquido.AutoGenerateColumns = false;
                dgvPatrimonioLiquido.DataSource = lista;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente");
            }
        }
    }
}
