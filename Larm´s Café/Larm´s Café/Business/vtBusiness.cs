using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class vtBusiness
    {
        Database.vtDatabase vtDatabase = new Database.vtDatabase();
        public void InserirVT(Database.Entity.tb_vale_transporte vt)
        {
            if (vt.vl_vt == null || vt.vl_vt == 0.00m)
                throw new ArgumentException("Informe o valor do Vale Transporte");

            if (string.IsNullOrWhiteSpace(vt.ds_codigo_bilhete_unico))
                throw new ArgumentException("Informe o código do Vale Transporte");

            vt.ds_codigo_uso = "000";

            vtDatabase.InserirVT(vt);
        }

        public Database.Entity.tb_vale_transporte ConsultarVT(string codigo, decimal valor)
        {
            if (valor == null || valor == 0.00m)
                throw new ArgumentException("Informe o valor do Vale Transporte");

            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("Informe o código do Vale Transporte");

            return vtDatabase.ConsultarVT(codigo, valor);
        }

        public void Alterar(Database.Entity.tb_vale_transporte vale)
        {
            vtDatabase.Alterar(vale);
        }
    }
}
