using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class folhaDePagamentoDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();
        public void InserirFolhaDePagamento (Entity.tb_fopag folha)
        {
            larmscafeEntities.tb_fopag.Add(folha);
            larmscafeEntities.SaveChanges();
        }

       
        public Entity.tb_fopag ConsultarFolhaDePagamento (string funcionario, int mes)
        {
            return larmscafeEntities.tb_fopag.
                                        First(x => x.tb_funcionario.nm_funcionario.Contains(funcionario) &&
                                                   x.dt_pagamento.Month == mes);

        }
        public Entity.tb_fopag ConsultarFolhaDePagamentoInserir(string funcionario)
        {
            return larmscafeEntities.tb_fopag.
                                        First(x => x.tb_funcionario.nm_funcionario == funcionario);

        }

        public List<Entity.tb_fopag> ConsultarTodos()
        {
            return larmscafeEntities.tb_fopag.
                                       ToList();

        }

        public void AlterarFolhaDePagamento (Entity.tb_fopag folha)
        {
            Entity.tb_fopag alterar = larmscafeEntities.tb_fopag.
                                                           First(x => x.id_fopag == folha.id_fopag);
            alterar.id_funcionario = folha.id_funcionario;
            alterar.qt_falta = folha.qt_falta;
            alterar.qt_hora_extra = folha.qt_hora_extra;
            alterar.vl_adicional_noturno = folha.vl_adicional_noturno;
            alterar.vl_gratificacao = folha.vl_gratificacao;
            alterar.vl_plr = folha.vl_plr;
            alterar.vl_salario = folha.vl_salario;
            alterar.vl_total_desconto = folha.vl_total_desconto;
            alterar.vl_total_proventos = folha.vl_total_proventos;
            alterar.dt_pagamento = folha.dt_pagamento;
            alterar.ds_cnpj = folha.ds_cnpj;
            alterar.ds_adiantamento_semanal = folha.ds_adiantamento_semanal;

            larmscafeEntities.SaveChanges();
        }

        public Entity.tb_fopag ConsultarPorIDDoFuncionario(int id)
        {
            return larmscafeEntities.tb_fopag.First(x => x.tb_funcionario.id_funcionario == id);
        }
    }
}
