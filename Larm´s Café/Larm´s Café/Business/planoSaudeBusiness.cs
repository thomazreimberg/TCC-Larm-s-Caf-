using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class planoSaudeBusiness
    {
        Database.planoSaudeDatabase planoSaudeDatabase = new Database.planoSaudeDatabase();

        public List<Database.Entity.tb_plano_de_saude> ListarTodos()
        {
            return planoSaudeDatabase.ListarTodos();
        }
    }
}
