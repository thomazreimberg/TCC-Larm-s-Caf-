using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class balancoPatrimonialDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public List<Entity.tb_balanco_patrimonial> ConsultarAtivo(int ano)
        {
            return larmscafeEntities.tb_balanco_patrimonial.Where(x => x.ds_categoria == "Ativo" &&
                                                                       x.dt_data.Year == ano).ToList();
        }

        public List<Entity.tb_balanco_patrimonial> ConsultarPassivo(int ano)
        {
            return larmscafeEntities.tb_balanco_patrimonial.Where(x => x.ds_categoria == "Passivo" &&
                                                                       x.dt_data.Year == ano).ToList();
        }

        public List<Entity.tb_balanco_patrimonial> ConsultarPatrimonioLiquido(int ano)
        {
            return larmscafeEntities.tb_balanco_patrimonial.Where(x => x.dt_data.Year == ano).ToList();
        }
    }
}
