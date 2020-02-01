using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class vendaProdutoBusiness
    {
        Database.vendaProdutoDatabase vendaProdutoDatabase = new Database.vendaProdutoDatabase();
        public void InserirVendaProduto(Database.Entity.tb_venda_produto venda)
        {
            vendaProdutoDatabase.InserirVendaProduto(venda);
        }
    }
}
