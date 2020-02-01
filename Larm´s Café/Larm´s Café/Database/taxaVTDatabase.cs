using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class taxaVTDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();
        public Entity.tb_taxa_vt ConsultarTaxa()
        {
            return larmscafeEntities.tb_taxa_vt.First();
        }
    }
}
