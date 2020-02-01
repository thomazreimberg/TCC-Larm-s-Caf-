using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Alterar.RH
{
    public partial class frmAlterarFuncionarios : Form
    {
        public frmAlterarFuncionarios()
        {
            InitializeComponent();
            CarregarCampos();
        }

        Business.funcionarioBusiness funcionarioBusiness = new Business.funcionarioBusiness();
        Business.cargoBusiness cargoBusiness = new Business.cargoBusiness();
        Business.planoSaudeBusiness planoSaudeBusiness = new Business.planoSaudeBusiness();
        Business.planoOdontologicoBusiness planoOdontologicoBusiness = new Business.planoOdontologicoBusiness();
        Business.seguroDeVidaBusiness seguroDeVidaBusiness = new Business.seguroDeVidaBusiness();
        Database.Entity.tb_funcionario funcionario = new Database.Entity.tb_funcionario();
        Business.vaBusiness vaBusiness = new Business.vaBusiness();
        Business.vtBusiness vtBusiness = new Business.vtBusiness();
        Business.vrBusiness vrBusiness = new Business.vrBusiness();

        private void nudSalarioBruto_ValueChanged(object sender, EventArgs e)
        {
            if (nudSalarioBruto.Value >= 907.78m && nudSalarioBruto.Value <= 1364.43m)
                nudSalarioFamilia.Increment = 32.80m;

            else if (nudSalarioBruto.Value < 907.78m)
                nudSalarioFamilia.Increment = 46.54m;

            else
                nudSalarioFamilia.Enabled = false;

            nudPericulosidade.Value = nudSalarioBruto.Value * 0.30m;
        }

        private void CarregarCampos()
        {
            try
            {
                cboCargo.ValueMember = nameof(Database.Entity.tb_cargo.ds_cargo);
                cboCargo.DataSource = cargoBusiness.ConsultarTodos();
                cboPlanoDeSaude.ValueMember = nameof(Database.Entity.tb_plano_de_saude.ds_plano_funcionario);
                cboPlanoDeSaude.DataSource = planoSaudeBusiness.ListarTodos();
                cboPlanoOdontologico.ValueMember = nameof(Database.Entity.tb_plano_odontologico.ds_plano_funcionario);
                cboPlanoOdontologico.DataSource = planoOdontologicoBusiness.ListarTodos();
                cboSeguroDeVida.ValueMember = nameof(Database.Entity.tb_seguro_vida.ds_plano_funcionario);
                cboSeguroDeVida.DataSource = seguroDeVidaBusiness.ListarTodos();
                dgvConsultarFuncionarios.AutoGenerateColumns = false;
                dgvConsultarFuncionarios.DataSource = funcionarioBusiness.ConsultarTodos();
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique sua conexão com a internet pois não foi possivel comunicar com o banco online");
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

        private void txtNomeFiltro_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNomeFiltro.Text))
            {
                dgvConsultarFuncionarios.AutoGenerateColumns = false;
                dgvConsultarFuncionarios.DataSource = funcionarioBusiness.ConsultarTodos();
            }
            else
            {
                dgvConsultarFuncionarios.AutoGenerateColumns = false;
                dgvConsultarFuncionarios.DataSource = funcionarioBusiness.ConsultarFuncionarioAlterar(txtNomeFiltro.Text);
            }

        }

        private void btnAlterarInformacoes_Click(object sender, EventArgs e)
        {
            try
            {
                // Converte os itens do ComboBox para modelo:
                Database.Entity.tb_cargo cargo = cboCargo.SelectedItem as Database.Entity.tb_cargo;
                Database.Entity.tb_plano_de_saude planoSaude = cboPlanoDeSaude.SelectedItem as Database.Entity.tb_plano_de_saude;
                Database.Entity.tb_plano_odontologico planoOdontologico = cboPlanoOdontologico.SelectedItem as Database.Entity.tb_plano_odontologico;
                Database.Entity.tb_seguro_vida seguroVida = cboSeguroDeVida.SelectedItem as Database.Entity.tb_seguro_vida;

                // Funções para alterar os benefícios:
                AlterarVT();
                AlterarVA();
                AlterarVR();

                // Funções para Consultar Benefícios alterados:
                Database.Entity.tb_vale_alimentacao va = vaBusiness.ValeAlimentacao(nudVA.Value, txtCodigoVA.Text);
                Database.Entity.tb_vale_refeicao vr = vrBusiness.ConsultarVR(txtCodigoRF.Text, nudVR.Value);
                Database.Entity.tb_vale_transporte vt = vtBusiness.ConsultarVT(txtCodigoVT.Text, nudVT.Value);

                funcionario.id_funcionario = Convert.ToInt32(nudID.Value);
                funcionario.nm_funcionario = txtNome.Text;
                funcionario.vl_salario_bruto = nudSalarioBruto.Value;
                funcionario.vl_periculosidade = nudSalarioBruto.Value * 0.30m;
                funcionario.ds_cpf = txtCPF.Text.Replace(".", "").Replace("-", "");
                funcionario.ds_email = txtEmail.Text;
                funcionario.ds_endereco = txtEndereco.Text;
                funcionario.ds_telefone = txtTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "");
                funcionario.dt_demitido = dtpDemissao.Value.Date;
                funcionario.id_cargo = cargo.id_cargo;
                funcionario.id_plano_de_saude = planoSaude.id_plano_de_saude;
                funcionario.id_plano_odontologico = planoOdontologico.id_plano_odontologico;
                funcionario.id_seguro_vida = seguroVida.id_seguro_vida;
                funcionario.id_vale_alimentacao = va.id_vale_alimentacao;
                funcionario.id_vale_refeicao = vr.id_vale_refeicao;
                funcionario.id_vale_transporte = vt.id_vale_transporte;
                funcionario.vl_salario_familia = nudSalarioFamilia.Value;

                funcionarioBusiness.AlterarFuncionrio(funcionario);
                dgvConsultarFuncionarios.AutoGenerateColumns = false;
                dgvConsultarFuncionarios.DataSource = funcionarioBusiness.ConsultarTodos();
                MessageBox.Show("Funcionário alterado");
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

        private void AlterarVT()
        {
            Database.Entity.tb_vale_transporte vale = new Database.Entity.tb_vale_transporte();

            vale.ds_codigo_bilhete_unico = txtCodigoVT.Text;
            vale.vl_vt = nudVT.Value;
            vtBusiness.Alterar(vale);
        }

        private void AlterarVA()
        {
            Database.Entity.tb_vale_alimentacao vale = new Database.Entity.tb_vale_alimentacao();

            vale.ds_codigo_va = txtCodigoVA.Text;
            vale.vl_vale_alimentacao = nudVA.Value;
            vaBusiness.AlterarVA(vale);
        }

        private void AlterarVR()
        {
            Database.Entity.tb_vale_refeicao vale = new Database.Entity.tb_vale_refeicao();

            vale.ds_codigo_vr = txtCodigoRF.Text;
            vale.vl_vale_refeicao = nudVR.Value;
            vrBusiness.Alterar(vale);
        }

        private void dgvConsultarFuncionarios_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var func = dgvConsultarFuncionarios.CurrentRow.DataBoundItem as Database.Entity.tb_funcionario;

                nudID.Value = func.id_funcionario;
                txtNome.Text = func.nm_funcionario;
                dtpDemissao.Value = func.dt_demitido;
                nudSalarioBruto.Value = func.vl_salario_bruto;
                txtCPF.Text = func.ds_cpf;
                txtEndereco.Text = func.ds_endereco;
                txtTelefone.Text = func.ds_telefone;
                txtEmail.Text = func.ds_email;
                cboCargo.Text = func.tb_cargo.ds_cargo;
                nudInss.Value = func.vl_inss;
                nudPericulosidade.Value = func.vl_periculosidade;
                nudVR.Value = func.tb_vale_refeicao.vl_vale_refeicao;
                txtCodigoRF.Text = func.tb_vale_refeicao.ds_codigo_vr;
                nudVT.Value = func.tb_vale_transporte.vl_vt;
                txtCodigoVT.Text = func.tb_vale_transporte.ds_codigo_bilhete_unico;
                nudVA.Value = func.tb_vale_alimentacao.vl_vale_alimentacao;
                txtCodigoVA.Text = func.tb_vale_alimentacao.ds_codigo_va;
                cboPlanoDeSaude.Text = func.tb_plano_de_saude.ds_plano_funcionario;
                cboPlanoOdontologico.Text = func.tb_plano_odontologico.ds_plano_funcionario;
                cboSeguroDeVida.Text = func.tb_seguro_vida.ds_plano_funcionario;
                nudSalarioFamilia.Value = func.vl_salario_familia;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente");
            }
        }

        
    }
}
