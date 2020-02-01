using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class vendaProdutoDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities1 = new Entity.larmscafeEntities1();
        public void InserirVendaProduto(Entity.tb_venda_produto venda)
        {
            larmscafeEntities1.tb_venda_produto.Add(venda);
            larmscafeEntities1.SaveChanges();
        }
    }
}
