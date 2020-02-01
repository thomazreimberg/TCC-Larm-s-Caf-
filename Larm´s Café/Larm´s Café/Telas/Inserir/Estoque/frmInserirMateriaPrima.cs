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
    public partial class frmInserirMateriaPrima : Form
    {
        public frmInserirMateriaPrima()
        {
            InitializeComponent();
        }

        Business.materiaPrimaBusiness materiaPrimaBusiness = new Business.materiaPrimaBusiness();

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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_materia_prima materiaPrima = new Database.Entity.tb_materia_prima();
                materiaPrima.ds_categoria = cboCategoria.Text;
                materiaPrima.nm_produto = txtMateriaPrima.Text;
                materiaPrima.vl_preco = nudPreco.Value;

                materiaPrimaBusiness.InserirMateriaPrima(materiaPrima);
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
    }
}
