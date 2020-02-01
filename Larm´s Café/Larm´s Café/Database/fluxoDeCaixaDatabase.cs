using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class fluxoDeCaixaDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public List<Entity.vw_fluxo_de_caixa> ConsultarViewFluxoDeCaixa(DateTime data_inicio, DateTime data_final)
        {
            List<Entity.vw_fluxo_de_caixa> lista = larmscafeEntities.vw_fluxo_de_caixa.
                                                                     Where(x => x.dt_pagamento >= data_inicio 
                                                                             && x.dt_pagamento <= data_final).
                                                                     ToList();
            return lista;
        }

        public List<Entity.vw_fluxo_de_caixa> ConsultarTodos()
        {
            return larmscafeEntities.vw_fluxo_de_caixa.ToList();
        }
    }
}
