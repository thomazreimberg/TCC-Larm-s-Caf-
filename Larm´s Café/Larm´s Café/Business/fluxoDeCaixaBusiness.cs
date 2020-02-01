using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class fluxoDeCaixaBusiness
    {
        Database.fluxoDeCaixaDatabase fluxoDeCaixaDatabase = new Database.fluxoDeCaixaDatabase();
        public List<Database.Entity.vw_fluxo_de_caixa> ConsultarViewFluxoDeCaixa(DateTime dt_inicio, DateTime dt_final)
        {
            List<Database.Entity.vw_fluxo_de_caixa> lista = 
                fluxoDeCaixaDatabase.ConsultarViewFluxoDeCaixa(dt_inicio, dt_final);
            return lista;
        }

        public List<Database.Entity.vw_fluxo_de_caixa> ConsultarTodos()
        {
            return fluxoDeCaixaDatabase.ConsultarTodos();
        }
    }
}

