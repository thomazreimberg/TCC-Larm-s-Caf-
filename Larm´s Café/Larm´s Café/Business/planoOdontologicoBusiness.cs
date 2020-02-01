using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class planoOdontologicoBusiness
    {
        Database.planoOdontologicoDatabase planoOdontologicoDatabase = new Database.planoOdontologicoDatabase();
        public Database.Entity.tb_plano_odontologico ConsultarPlano(decimal plano)
        {
            return planoOdontologicoDatabase.ConsultarPlano(plano);
        }

        public List<Database.Entity.tb_plano_odontologico> ListarTodos()
        {
            return planoOdontologicoDatabase.ListarTodos();
        }
    }
}
