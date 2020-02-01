using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Larm_s_Café.Telas.Consultar.RH
{
    public partial class frmConsultarFolhaDePagamento : Form
    {
        public frmConsultarFolhaDePagamento()
        {
            InitializeComponent();
            CarregarFuncionarios();
            List<Database.Entity.tb_fopag> listar = folhaDePagamentoBusiness.ConsultarTodos();
            dgvLista.AutoGenerateColumns = false;
            dgvLista.DataSource = listar;
        }

        Business.funcionarioBusiness funcionarioBusiness = new Business.funcionarioBusiness();
        Business.folhaDePagamentoBusiness folhaDePagamentoBusiness = new Business.folhaDePagamentoBusiness();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_funcionario func = cboNomeBuscar.SelectedItem as Database.Entity.tb_funcionario;
            int data = dtpDataPagamentoBuscar.Value.Date.Month;

            Database.Entity.tb_fopag lista = folhaDePagamentoBusiness.ConsultarFolhaDePagamento(func.nm_funcionario, data);
            cboCargo.Text = lista.tb_funcionario.tb_cargo.ds_cargo;
            txtCnpj.Text = lista.ds_cnpj;
            txtEmpresa.Text = lista.tb_funcionario.nm_empresa;
            txtNome.Text = lista.tb_funcionario.nm_funcionario;
            nudAlimentacao.Value = Convert.ToDecimal(lista.tb_funcionario.tb_vale_alimentacao.vl_vale_alimentacao);
            nudDsr.Value = lista.ds_adiantamento_semanal;
            nudFaltas.Value = lista.qt_falta;
            nudFgts.Value = lista.vl_fgts;
            nudGratificacao.Value = lista.vl_gratificacao;
            nudHoraExtra.Value = lista.qt_hora_extra;
            nudInss.Value = lista.tb_funcionario.vl_inss;
            nudOdontologico.Value = lista.tb_funcionario.tb_plano_odontologico.vl_plano;
            nudPericulosidade.Value = lista.tb_funcionario.vl_periculosidade;
            nudPlanoSaude.Value = lista.tb_funcionario.tb_plano_de_saude.vl_plano;   
            nudRenumeracao.Value = lista.tb_funcionario.vl_salario_bruto;
            nudSalarioBruto.Value = lista.tb_funcionario.vl_salario_bruto;
            nudSalarioFamilia.Value = lista.tb_funcionario.vl_salario_familia;
            nudSeguroVida.Value = lista.tb_funcionario.tb_seguro_vida.vl_plano;
            nudValeRefeicao.Value = lista.tb_funcionario.tb_vale_refeicao.vl_vale_refeicao;
            nudValeTransporte.Value = lista.tb_funcionario.tb_vale_transporte.vl_vt;
            lblTotalDescontos.Text = "Total: R$" + lista.vl_total_desconto;
            lblTotalProventos.Text = "Total: R$" + lista.vl_total_proventos;
            lblSalarioLiquido.Text = "Total: R$" + lista.vl_salario;

            dtpAdmissao.Value = lista.tb_funcionario.dt_adimissao.Date;
            dtpDataPagamento.Value = lista.dt_pagamento.Date;
            dtpDemissao.Value = lista.dt_demitido.Date;
        }

        private void CarregarFuncionarios()
        {
            List<Database.Entity.tb_funcionario> lista = funcionarioBusiness.ConsultarTodos();

            cboNomeBuscar.ValueMember = nameof(Database.Entity.tb_funcionario.nm_funcionario);
            cboNomeBuscar.DataSource = lista;
        }

        private void label28_Click(object sender, EventArgs e)
        {
            Hide();
            Outros.Outro.frmMenu start = new Outros.Outro.frmMenu();
            start.Show();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
