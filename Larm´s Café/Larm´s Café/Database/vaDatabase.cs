using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class vaDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public void InserirVA (Entity.tb_vale_alimentacao va)
        {
            larmscafeEntities.tb_vale_alimentacao.Add(va);
            larmscafeEntities.SaveChanges();
        }

        public Entity.tb_vale_alimentacao ValeAlimentacao(decimal preco, string codigo)
        {
            return larmscafeEntities.tb_vale_alimentacao.
                                                   First(x => x.vl_vale_alimentacao == preco && 
                                                              x.ds_codigo_va == codigo);
        }


        public void AlterarVA(Entity.tb_vale_alimentacao vale)
        {
            Entity.tb_vale_alimentacao alterar = larmscafeEntities.tb_vale_alimentacao.
                                                                                 First(x => x.ds_codigo_va == vale.ds_codigo_va &&
                                                                                            x.vl_vale_alimentacao == vale.vl_vale_alimentacao);

            alterar.vl_vale_alimentacao = vale.vl_vale_alimentacao;
            alterar.ds_codigo_va = vale.ds_codigo_va;
            larmscafeEntities.SaveChanges();
        }
    }
}
