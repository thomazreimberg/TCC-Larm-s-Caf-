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
    public partial class frmInserirFolhaDePagamento : Form
    {
        public frmInserirFolhaDePagamento()
        {
            InitializeComponent();
            CarregarCampos();
        }

        Business.funcionarioBusiness funcionarioBusiness = new Business.funcionarioBusiness();
        Business.folhaDePagamentoBusiness folhaDePagamentoBusiness = new Business.folhaDePagamentoBusiness();

        private void CarregarCampos()
        {
            cboNomeFiltro.ValueMember = nameof(Database.Entity.tb_funcionario.nm_funcionario);
            cboNomeFiltro.DataSource = funcionarioBusiness.ConsultarTodos();
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

        private void btnGerarFolha_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_funcionario funcionario = cboNomeFiltro.SelectedItem as Database.Entity.tb_funcionario;
            Database.Entity.tb_fopag folha = new Database.Entity.tb_fopag();


            folha.id_funcionario = funcionario.id_funcionario;
            folha.vl_fgts = nudFGTS.Value;
            folha.vl_gratificacao = nudGratificacao.Value;
            folha.ds_adiantamento_semanal = nudDSR.Value;
            folha.ds_cnpj = txtCNPJ.Text;
        }

        Database.tb_fgtsDatabase tb_fgtsDatabase = new Database.tb_fgtsDatabase();
        private void cboNomeFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.Entity.tb_funcionario funcionario = cboNomeFiltro.SelectedItem as Database.Entity.tb_funcionario;

            Database.Entity.tb_funcionario func = cboNomeFiltro.SelectedItem as Database.Entity.tb_funcionario;

            Database.Entity.tb_fopag lista = folhaDePagamentoBusiness.ConsultarFolhaDePagamentoInserir(func.nm_funcionario);
            cboCargo.Text = lista.tb_funcionario.tb_cargo.ds_cargo;
            txtCNPJ.Text = lista.ds_cnpj;
            txtEmpresa.Text = lista.tb_funcionario.nm_empresa;
            txtNome.Text = lista.tb_funcionario.nm_funcionario;
            nudValeAlimentacao.Value = Convert.ToDecimal(lista.tb_funcionario.tb_vale_alimentacao.vl_vale_alimentacao);
            nudDSR.Value = lista.ds_adiantamento_semanal;
            nudFaltas.Value = lista.qt_falta;
            nudFGTS.Value = lista.vl_fgts;
            nudGratificacao.Value = lista.vl_gratificacao;
            nudHoraExtra.Value = lista.qt_hora_extra;
            nudINSS.Value = lista.tb_funcionario.vl_inss;
            nudOdontologico.Value = lista.tb_funcionario.tb_plano_odontologico.vl_plano;
            nudPericulosidade.Value = lista.tb_funcionario.vl_periculosidade;
            nudPlanoSaude.Value = lista.tb_funcionario.tb_plano_de_saude.vl_plano;
            nudRenumeracao.Value = lista.tb_funcionario.vl_salario_bruto;
            nudSalarioBruto.Value = lista.tb_funcionario.vl_salario_bruto;
            nudSalarioFamilia.Value = lista.tb_funcionario.vl_salario_familia;
            nudSeguroVida.Value = lista.tb_funcionario.tb_seguro_vida.vl_plano;
            nudValeRefeicao.Value = lista.tb_funcionario.tb_vale_refeicao.vl_vale_refeicao;
            nudValeTransporte.Value = lista.tb_funcionario.tb_vale_transporte.vl_vt;
            nudTotalDescontos.Text = "Total: R$" + lista.vl_total_desconto;
            nudTotalProventos.Text = "Total: R$" + lista.vl_total_proventos;
            nudSalarioLiquido.Text = "Total: R$" + lista.vl_salario;
            //nudIR.Value = ;

            dtpAdmissao.Value = lista.tb_funcionario.dt_adimissao.Date;
            dtpDemissao.Value = lista.dt_demitido.Date;

            decimal taxaAte = 0;
            decimal taxaEntre = 0;
            decimal taxaEntre2 = 0;
            decimal taxaAcima = 0;
            int qtFaltas = 0;
            int passagensVezes = 0;
            decimal valorAte = 0;
            Objetos.FolhasDePagamento folhaDePagamento = new Objetos.FolhasDePagamento();

            folhaDePagamento.GerarFolha(lista, nudHoraExtra.Value, qtFaltas, passagensVezes);

            nudSalarioLiquido.Value = folhaDePagamento.SalarioLiquido;
            nudTotalProventos.Value = folhaDePagamento.TotalProventos;
            nudTotalDescontos.Value = folhaDePagamento.TotalDescontos;
            nudValeTransporte.Value = folhaDePagamento.VT;
            nudDSR.Value = folhaDePagamento.DSR;
            nudFGTS.Value = folhaDePagamento.FGTS;
            nudHoraExtra.Value = folhaDePagamento.HoraExtra;
            nudINSS.Value = folhaDePagamento.INSS;
            nudFaltas.Value = folhaDePagamento.Faltas;
            
            
        }

        private void frmInserirFolhaDePagamento_Load(object sender, EventArgs e)
        {

        }

        private void nudSalarioBruto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudRenumeracao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudSalarioFamilia_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
