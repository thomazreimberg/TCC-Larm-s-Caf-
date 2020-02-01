using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database.Entity
{

    public partial class tb_fopag
    {
        public string nm_funcionario { get { return this.tb_funcionario.nm_funcionario; } }
        public string ds_cargo { get { return this.tb_funcionario.tb_cargo.ds_cargo; } }
        public string ds_cpf { get {return this.tb_funcionario.ds_cpf; } }
        public DateTime dt_demitido { get { return this.tb_funcionario.dt_demitido; } }
        public DateTime dt_adimissao { get { return this.tb_funcionario.dt_adimissao; } }
        public string ds_telefone { get { return this.tb_funcionario.ds_telefone; } }
        public string ds_endereco { get { return this.tb_funcionario.ds_endereco; } }
        public string ds_email { get { return this.tb_funcionario.ds_email; } }
        public string nm_empresa { get { return this.tb_funcionario.nm_empresa; } }
        public decimal vl_vt { get { return this.tb_funcionario.tb_vale_transporte.vl_vt; } }
        public decimal vl_insalubridade { get { return this.tb_funcionario.vl_insalubridade; } }
        public decimal vl_inss { get { return this.tb_funcionario.vl_inss; } }
        public decimal vl_periculosidade { get { return this.tb_funcionario.vl_periculosidade; } }
        public decimal vl_salario_bruto { get { return this.tb_funcionario.vl_salario_bruto; } }
        public decimal vl_salario_familia { get { return this.tb_funcionario.vl_salario_familia; } }
        public decimal vl_vale_alimentacao { get { return this.tb_funcionario.tb_vale_alimentacao.vl_vale_alimentacao; } }
        public string ds_codigo_va { get { return this.tb_funcionario.tb_vale_alimentacao.ds_codigo_va; } }
        public string ds_plano_funcionario_saude { get { return this.tb_funcionario.tb_plano_de_saude.ds_plano_funcionario; } }
        public decimal vl_plano_vida { get { return this.tb_funcionario.tb_seguro_vida.vl_plano; } }
        public string ds_plano_funcionario_odonto { get { return this.tb_funcionario.tb_plano_odontologico.ds_plano_funcionario; } }
        public decimal vl_plano_odonto { get { return this.tb_funcionario.tb_plano_odontologico.vl_plano; } }
        public string ds_codigo_vr { get { return this.tb_funcionario.tb_vale_refeicao.ds_codigo_vr; } }
        public string ds_plano_funcionario_vida { get { return this.tb_funcionario.tb_seguro_vida.ds_plano_funcionario; } }
        public decimal vl_vale_refeicao { get { return this.tb_funcionario.tb_vale_refeicao.vl_vale_refeicao; } }
        public decimal vl_plano_saude { get { return this.tb_funcionario.tb_plano_de_saude.vl_plano; } }

    }

    public partial class tb_funcionario
    {
        public string ds_cargo { get { return this.tb_cargo.ds_cargo; } }
    }

    public partial class tb_venda_produto
    {
        public string nm_produto { get { return this.tb_produto.nm_produto; } }
        public string ds_categoria { get { return this.tb_produto.ds_categoria; } }
        public decimal vl_preco { get { return this.tb_produto.vl_preco; } }
        public string ds_observacao { get { return this.tb_produto.ds_observacao; } }
    }

    
}
