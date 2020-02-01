using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class folhaDePagamentoBusiness
    {
        Database.folhaDePagamentoDatabase folhaDePagamentoDatabase = new Database.folhaDePagamentoDatabase();

        public void InserirFolhaDePagamento(Database.Entity.tb_fopag folha)
        {
            folhaDePagamentoDatabase.InserirFolhaDePagamento(folha);
        }

        public Database.Entity.tb_fopag ConsultarFolhaDePagamento(string funcionario, int mes)
        {
            return folhaDePagamentoDatabase.ConsultarFolhaDePagamento(funcionario, mes);
        }

        public Database.Entity.tb_fopag ConsultarFolhaDePagamentoInserir(string funcionario)
        {
            return folhaDePagamentoDatabase.ConsultarFolhaDePagamentoInserir(funcionario);
        }

        public List<Database.Entity.tb_fopag> ConsultarTodos()
        {
            return folhaDePagamentoDatabase.ConsultarTodos();
        }

        public void AlterarFolhaDePagamento(Database.Entity.tb_fopag folha)
        {
            folhaDePagamentoDatabase.AlterarFolhaDePagamento(folha);
        }

        
        public Database.Entity.tb_fopag ConsultarPorIDDoFuncionario(int id)
        {
            if(id == 0 || id == null)
            {
                throw new ArgumentException("Informe o funcionário");
            }

            return folhaDePagamentoDatabase.ConsultarPorIDDoFuncionario(id);
        }
    }
}
