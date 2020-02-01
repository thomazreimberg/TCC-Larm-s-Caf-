using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class logBusiness
    {
        Database.logDatabase logDatabase = new Database.logDatabase();
        
        public void Inserir(Database.Entity.tb_log log)
        {
            logDatabase.Inserir(log);
        }
    }
}
