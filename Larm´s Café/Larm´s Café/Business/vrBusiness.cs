using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class vrBusiness
    {
        Database.vrDatabase vrDatabase = new Database.vrDatabase();
        public void InserirVR(Database.Entity.tb_vale_refeicao valeRefeicao)
        {
            if (string.IsNullOrWhiteSpace(valeRefeicao.ds_codigo_vr))
                valeRefeicao.ds_codigo_vr = "00000";

            vrDatabase.InserirVR(valeRefeicao);
        }

        public List<Database.Entity.tb_vale_refeicao> ConsultarTodos()
        {
            return vrDatabase.ConsultarTodos();
        }

        public List<Database.Entity.tb_vale_refeicao> ConsultarPorValor(decimal valor)
        {
            return vrDatabase.ConsultarPorValor(valor);
        }

        public void Alterar(Database.Entity.tb_vale_refeicao valeRefeicao)
        {
            if (string.IsNullOrWhiteSpace(valeRefeicao.ds_codigo_vr))
                valeRefeicao.ds_codigo_vr = "00000";

            vrDatabase.Alterar(valeRefeicao);
        }

        public Database.Entity.tb_vale_refeicao ConsultarVR(string codigo, decimal valor)
        {
            return vrDatabase.ConsultarVR(codigo, valor);
        }

    }
}
