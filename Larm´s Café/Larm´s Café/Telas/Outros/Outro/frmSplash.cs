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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Enabled = false;
            Hide();
            Telas.Consultar.Outro.frmLogin start = new Consultar.Outro.frmLogin();
            start.Show();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            try
            {
                Business.usuarioBusiness usuarioBusiness = new Business.usuarioBusiness();
                string a = "aaa";
                string b = "aaaa";
                bool ok = usuarioBusiness.EfetuarLogin(a, b);
            }
            catch(ArgumentException ex)
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
            
        }
    }
}
