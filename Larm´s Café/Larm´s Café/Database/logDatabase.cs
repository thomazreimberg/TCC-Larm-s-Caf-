using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class logDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public void Inserir(Entity.tb_log log)
        {
            larmscafeEntities.tb_log.Add(log);
            larmscafeEntities.SaveChanges();
        }
    }
}
