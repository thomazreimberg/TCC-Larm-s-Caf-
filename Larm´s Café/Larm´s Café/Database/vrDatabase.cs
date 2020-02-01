using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class vrDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();
        public void InserirVR(Entity.tb_vale_refeicao valeRefeicao)
        {
            larmscafeEntities.tb_vale_refeicao.Add(valeRefeicao);
            larmscafeEntities.SaveChanges();
        }

        public List<Entity.tb_vale_refeicao> ConsultarTodos()
        {
            return larmscafeEntities.tb_vale_refeicao.ToList();
        }

        public List<Entity.tb_vale_refeicao> ConsultarPorValor(decimal valor)
        {
            return larmscafeEntities.tb_vale_refeicao.
                                                Where(x => x.vl_vale_refeicao == valor).
                                               ToList();
        }

        public void Alterar(Entity.tb_vale_refeicao valeRefeicao)
        {
            Entity.tb_vale_refeicao alterar = larmscafeEntities.tb_vale_refeicao
                                                               .First(x => x.ds_codigo_vr == valeRefeicao.ds_codigo_vr &&
                                                                           x.vl_vale_refeicao == valeRefeicao.vl_vale_refeicao);

            alterar.vl_vale_refeicao = valeRefeicao.vl_vale_refeicao;
            alterar.ds_codigo_vr = valeRefeicao.ds_codigo_vr;
            larmscafeEntities.SaveChanges();
        }

        public Entity.tb_vale_refeicao ConsultarVR (string codigo, decimal valor)
        {
            return larmscafeEntities.tb_vale_refeicao.
                                                First(x => x.ds_codigo_vr == codigo && 
                                                           x.vl_vale_refeicao == valor);
        }
    }
}
