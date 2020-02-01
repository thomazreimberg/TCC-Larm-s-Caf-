using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class vendaDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities1 = new Entity.larmscafeEntities1();
        public void InserirVenda(Entity.tb_venda venda)
        {
            larmscafeEntities1.tb_venda.Add(venda);
            larmscafeEntities1.SaveChanges();
        }

        public List<Entity.tb_venda> ConsultarTodos()
        {
            return larmscafeEntities1.tb_venda.ToList();
        }

        public List<Entity.tb_venda> ConsultarVenda(DateTime dataDeVenda)
        {
            return larmscafeEntities1.tb_venda.Where(x => x.dt_venda == dataDeVenda).ToList();
        }

        public void AlterarVenda(Entity.tb_venda venda)
        {
            Entity.tb_venda alterar = larmscafeEntities1.tb_venda.First(x => x.id_venda == venda.id_venda);
            alterar.qt_parcelas = venda.qt_parcelas;
            alterar.vl_total_venda = venda.vl_total_venda;
            alterar.ds_modo_pagamento = venda.ds_modo_pagamento;
            alterar.dt_venda = venda.dt_venda;
            alterar.id_funcionario = venda.id_funcionario;

            larmscafeEntities1.SaveChanges();
        }


        public void RemoverVenda(int id)
        {
            Entity.tb_venda remover = larmscafeEntities1.tb_venda.First(x => x.id_venda == id);
            larmscafeEntities1.tb_venda.Remove(remover);
            larmscafeEntities1.SaveChanges();
        }
    }
}
