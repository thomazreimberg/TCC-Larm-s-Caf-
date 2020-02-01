using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class planoSaudeDatabase
    {
        Database.Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();
        //public Entity.tb_plano_de_saude ConsultarPlano (decimal plano)
        //{
            //return larmscafeEntities.tb_plano_de_saude.First(x => x.vl_plano == plano);
        //}

        public List<Entity.tb_plano_de_saude> ListarTodos()
        {
            return larmscafeEntities.tb_plano_de_saude.ToList();
        }
    }
}
