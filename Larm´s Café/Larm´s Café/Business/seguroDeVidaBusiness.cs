using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class seguroDeVidaBusiness
    {
        Database.seguroDeVidaDatabase seguroDeVidaDatabase = new Database.seguroDeVidaDatabase();

        public Database.Entity.tb_seguro_vida ConsultarPlano(decimal plano)
        {
            return seguroDeVidaDatabase.ConsultarPlano(plano);
        }

        public List<Database.Entity.tb_seguro_vida> ListarTodos()
        {
            return seguroDeVidaDatabase.ListarTodos();
        }
    }
}
