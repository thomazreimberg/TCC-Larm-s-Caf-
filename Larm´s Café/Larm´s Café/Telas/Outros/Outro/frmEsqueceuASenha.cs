using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Outros.Outro
{
    public partial class frmEsqueceuASenha : Form
    {
        public frmEsqueceuASenha()
        {
            InitializeComponent();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            Hide();
            Consultar.Outro.frmLogin start = new Consultar.Outro.frmLogin();
            start.Show();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtFuncionario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Enabled = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;

                Business.usuarioBusiness usuarioBusiness = new Business.usuarioBusiness();
                usuarioBusiness.ConsultarUsuario(usuario,chkWhatsApp.Checked);
                MessageBox.Show("Código enviado");
                Hide();
                Alterar.Outro.frmAlterarSenha start = new Alterar.Outro.frmAlterarSenha();
                start.Show();
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
    }
}
