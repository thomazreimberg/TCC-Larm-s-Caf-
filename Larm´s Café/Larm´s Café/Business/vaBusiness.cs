using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class vaBusiness
    {
        Database.vaDatabase vaDatabase = new Database.vaDatabase();

        public void InserirVA(Database.Entity.tb_vale_alimentacao va)
        {
            if (string.IsNullOrWhiteSpace(va.ds_codigo_va))
                va.ds_codigo_va = "0";

            vaDatabase.InserirVA(va);
        }

        public Database.Entity.tb_vale_alimentacao ValeAlimentacao(decimal preco, string codigo)
        {
            return vaDatabase.ValeAlimentacao(preco, codigo);
        }

        public void AlterarVA(Database.Entity.tb_vale_alimentacao vale)
        {
            vaDatabase.AlterarVA(vale);
        }
    }
}
