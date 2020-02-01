using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class tb_fgtsDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();
        public Entity.tb_fgts ListarTodos()
        {
            return larmscafeEntities.tb_fgts.First();
        }

        public Entity.tb_inss Listar()
        {
            return larmscafeEntities.tb_inss.First();
        }
    }
}
