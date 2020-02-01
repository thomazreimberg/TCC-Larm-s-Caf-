using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class balancoPatrimonialBusiness
    {
        Database.balancoPatrimonialDatabase balancoPatrimonialDatabase = new Database.balancoPatrimonialDatabase();
        public List<Database.Entity.tb_balanco_patrimonial> ConsultarAtivo(int ano)
        {
            return balancoPatrimonialDatabase.ConsultarAtivo(ano);
        }

        public List<Database.Entity.tb_balanco_patrimonial> ConsultarPassivo(int ano)
        {
            return balancoPatrimonialDatabase.ConsultarPassivo(ano);
        }

        public List<Database.Entity.tb_balanco_patrimonial> ConsultarPatrimonioLiquido(int ano)
        {
            return balancoPatrimonialDatabase.ConsultarPatrimonioLiquido(ano);
        }
    }
}
