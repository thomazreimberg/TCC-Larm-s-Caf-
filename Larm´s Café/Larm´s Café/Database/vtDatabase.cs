using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class vtDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public void InserirVT(Entity.tb_vale_transporte vt)
        {
            larmscafeEntities.tb_vale_transporte.Add(vt);
            larmscafeEntities.SaveChanges();
        }

        public Entity.tb_vale_transporte ConsultarVT(string codigo, decimal valor)
        {
            return larmscafeEntities.tb_vale_transporte.
                                                  First(x => x.ds_codigo_bilhete_unico == codigo && 
                                                             x.vl_vt == valor);
        }

        public void Alterar(Entity.tb_vale_transporte vale)
        {
            Entity.tb_vale_transporte alterar = larmscafeEntities.tb_vale_transporte.
                                                                                First(x => x.ds_codigo_bilhete_unico == vale.ds_codigo_bilhete_unico &&
                                                                                           x.vl_vt == vale.vl_vt);

            alterar.vl_vt = vale.vl_vt;
            alterar.ds_codigo_bilhete_unico = vale.ds_codigo_bilhete_unico;
            larmscafeEntities.SaveChanges();
        }
    }
}
