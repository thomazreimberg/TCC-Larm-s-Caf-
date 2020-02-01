using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class vendaBusiness
    {
        Database.vendaDatabase vendaDatabase = new Database.vendaDatabase();
        public void InserirVenda(Database.Entity.tb_venda venda)
        {
            vendaDatabase.InserirVenda(venda);
        }
    }
}
