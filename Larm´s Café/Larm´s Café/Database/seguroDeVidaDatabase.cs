using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class seguroDeVidaDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public Entity.tb_seguro_vida ConsultarPlano (decimal plano)
        {
            return larmscafeEntities.tb_seguro_vida.First(x => x.vl_plano == plano);
        }

        public List<Entity.tb_seguro_vida> ListarTodos()
        {
            return larmscafeEntities.tb_seguro_vida.ToList();
        }
    }
}
