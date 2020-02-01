using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Inserir.RH
{
    public partial class frmInserirFuncionarios : Form
    {
        public frmInserirFuncionarios()
        {
            InitializeComponent();
            Carregarcampos();
        }

        Business.funcionarioBusiness funcionarioBusiness = new Business.funcionarioBusiness();
        Database.planoOdontologicoDatabase planoOdontologicoDatabase = new Database.planoOdontologicoDatabase();
        Database.planoSaudeDatabase planoSaudeDatabase = new Database.planoSaudeDatabase();
        Database.seguroDeVidaDatabase seguroDeVidaDatabase = new Database.seguroDeVidaDatabase();
        Database.Entity.tb_funcionario funcionario = new Database.Entity.tb_funcionario();
        Database.cargoDatabase cargoDatabase = new Database.cargoDatabase();
        Database.Entity.tb_plano_de_saude plano_De_Saude = new Database.Entity.tb_plano_de_saude();
        Business.vaBusiness vaBusiness = new Business.vaBusiness();
        Business.vrBusiness vrBusiness = new Business.vrBusiness();
        Business.vtBusiness vtBusiness = new Business.vtBusiness();

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

        private void btnInserirFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                // Converte os itens do ComboBox para modelo:
                Database.Entity.tb_cargo cargo = cboCargo.SelectedItem as Database.Entity.tb_cargo;
                Database.Entity.tb_plano_de_saude planoSaude = cboPlanoDeSaude.SelectedItem as Database.Entity.tb_plano_de_saude;
                Database.Entity.tb_plano_odontologico planoOdontologico = cboPlanoOdontologico.SelectedItem as Database.Entity.tb_plano_odontologico;
                Database.Entity.tb_seguro_vida seguroVida = cboSeguroDeVida.SelectedItem as Database.Entity.tb_seguro_vida;

                // Funções para inserir os novos benefícios:
                InserirVA();
                InserirVR();
                InserirVT();

                // Funções para Consultar Benefícios inseridos:
                Database.Entity.tb_vale_alimentacao va = vaBusiness.ValeAlimentacao(nudValeAlimentacao.Value, txtCodigoVA.Text);
                Database.Entity.tb_vale_refeicao vr = vrBusiness.ConsultarVR(txtCodigoRF.Text, nudValeRefeicao.Value);
                Database.Entity.tb_vale_transporte vt = vtBusiness.ConsultarVT(txtCodigoVT.Text, nudValeTransporte.Value);

                funcionario.nm_empresa = txtEmpresa.Text;
                funcionario.nm_funcionario = txtNome.Text;
                funcionario.vl_salario_bruto = nudSalarioBruto.Value;
                funcionario.vl_inss = nudINSS.Value;
                funcionario.vl_periculosidade = nudPericulosidade.Value;
                funcionario.ds_cpf = txtCPF.Text.Replace(".", "").Replace("-", "");
                funcionario.ds_email = txtEmail.Text;
                funcionario.ds_endereco = txtEndereco.Text;
                funcionario.ds_telefone = txtTelefone.Text.Replace("-", "");
                funcionario.dt_adimissao = dtpAdmissao.Value.Date;
                funcionario.dt_demitido = dtpDemissao.Value.Date;
                funcionario.dt_nascimento = dtpNascimento.Value.Date;
                funcionario.id_cargo = cargo.id_cargo;
                funcionario.id_plano_de_saude = planoSaude.id_plano_de_saude;
                funcionario.id_plano_odontologico = planoOdontologico.id_plano_odontologico;
                funcionario.id_seguro_vida = seguroVida.id_seguro_vida;
                funcionario.id_vale_alimentacao = va.id_vale_alimentacao;
                funcionario.id_vale_refeicao = vr.id_vale_refeicao;
                funcionario.id_vale_transporte = vt.id_vale_transporte;
                funcionario.vl_salario_familia = nudSalarioFamilia.Value;

                funcionarioBusiness.InserirFuncionario(funcionario);

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

        private void nudSalarioBruto_ValueChanged(object sender, EventArgs e)
        {
            decimal salario = nudSalarioBruto.Value;

            nudValeTransporte.Value = salario * 0.06m;
        }

        public void Carregarcampos()
        {
            // Cargo
            cboCargo.ValueMember = nameof(Database.Entity.tb_cargo.ds_cargo);
            cboCargo.DataSource = cargoDatabase.ConsultarTodos();

            // Plano Odontológico
            cboPlanoOdontologico.ValueMember = nameof(Database.Entity.tb_plano_odontologico.ds_plano_funcionario);
            cboPlanoOdontologico.DataSource = planoOdontologicoDatabase.ListarTodos();

            // Plano de Saúde
            cboPlanoDeSaude.ValueMember = nameof(Database.Entity.tb_plano_de_saude.ds_plano_funcionario);
            cboPlanoDeSaude.DataSource = planoSaudeDatabase.ListarTodos();

            // Seguro de Vida
            cboSeguroDeVida.ValueMember = nameof(Database.Entity.tb_seguro_vida.ds_plano_funcionario);
            cboSeguroDeVida.DataSource = seguroDeVidaDatabase.ListarTodos();
        }

        private void InserirVA()
        {
            Database.Entity.tb_vale_alimentacao valeAlimentacao = new Database.Entity.tb_vale_alimentacao();
            valeAlimentacao.ds_codigo_va = txtCodigoVA.Text;
            valeAlimentacao.vl_vale_alimentacao = nudValeAlimentacao.Value;

            vaBusiness.InserirVA(valeAlimentacao);
        }

        private void InserirVR()
        {
            Database.Entity.tb_vale_refeicao valeRefeicao = new Database.Entity.tb_vale_refeicao();
            valeRefeicao.ds_codigo_vr = txtCodigoRF.Text.Trim();
            valeRefeicao.vl_vale_refeicao = nudValeRefeicao.Value;
            vrBusiness.InserirVR(valeRefeicao);
        }

        private void InserirVT()
        {
            Database.Entity.tb_vale_transporte valeTransporte = new Database.Entity.tb_vale_transporte();
            valeTransporte.ds_codigo_bilhete_unico = txtCodigoVT.Text;
            valeTransporte.vl_vt = nudValeTransporte.Value;
            valeTransporte.ds_codigo_uso = "000000";

            vtBusiness.InserirVT(valeTransporte);
        }

        private void frmInserirFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void lblFechar_Click_1(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void lblMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
