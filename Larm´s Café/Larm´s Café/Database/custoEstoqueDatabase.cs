using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class custoEstoqueDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public void InserirCusto(Entity.tb_custo custo)
        {
            larmscafeEntities.tb_custo.Add(custo);
            larmscafeEntities.SaveChanges();
        }

        public List<Entity.tb_custo> ConsultarCusto (DateTime data)
        {
            List<Entity.tb_custo> lista = larmscafeEntities.tb_custo.
                                                               Where(x => x.dt_compra == data).ToList();
            return lista;
        }

        public List<Entity.tb_custo> ConsultarTodos()
        {
            List<Entity.tb_custo> lista = larmscafeEntities.tb_custo.ToList();
            return lista;
        }

        public void AlterarCusto(Entity.tb_custo custo)
        {
            Entity.tb_custo alterar = larmscafeEntities.tb_custo.First(x => x.id_custo == custo.id_custo);

            alterar.qt_quantidade_compra = custo.qt_quantidade_compra;
            alterar.vl_total = custo.vl_total;
            alterar.dt_compra = custo.dt_compra;

            larmscafeEntities.SaveChanges();
        }
    }
}
