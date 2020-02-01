using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class despesaBusiness
    {
        Database.despesasDatabase despesasDatabase = new Database.despesasDatabase();


        public void Inserir(Database.Entity.tb_despesa despesa)
        {
            if (string.IsNullOrWhiteSpace(despesa.nm_referencia))
            {
                throw new ArgumentException("Insira o nome de referência");
            }

            if (despesa.ds_previsto == 0.00m || despesa.ds_previsto == null)
            {
                throw new ArgumentException("Insira a descrição prevista");
            }


            if (despesa.ds_realizado == 0.00m || despesa.ds_previsto == null)
            {
                throw new ArgumentException("Insira a descrição realizada");
            }

            DateTime data = Convert.ToDateTime(14 / 01 / 2019);

            if (despesa.dt_entrada >= data)
            {
                throw new ArgumentException("Informe a data correta");
            }
            despesasDatabase.Inserir(despesa);
        }


        public List<Database.Entity.tb_despesa> ConsultarDespesa(string referencia, DateTime entrada)
        {
            if(string.IsNullOrWhiteSpace(referencia))
            {
                throw new ArgumentException("Informe uma referência");
            }
            DateTime data = Convert.ToDateTime(01 / 10 / 2019);
            if (entrada >= data)
            {
                throw new ArgumentException("Informe a data correta");
            }

            List<Database.Entity.tb_despesa> despesas = despesasDatabase.ConsultarDespesa(referencia, entrada);
            return despesas;
        }

        public void AlterarDespesa(Database.Entity.tb_despesa despesa)//Pegar o ID do DataGridView
        {
            if (string.IsNullOrWhiteSpace(despesa.nm_referencia))
            {
                throw new ArgumentException("Insira o nome de referência");
            }

            if (despesa.ds_previsto == 0.00m || despesa.ds_previsto == null)
            {
                throw new ArgumentException("Insira a descrição prevista");
            }


            if (despesa.ds_realizado == 0.00m || despesa.ds_previsto == null)
            {
                throw new ArgumentException("Insira a descrição realizada");
            }

            if (despesa.dt_entrada >= Convert.ToDateTime(01 / 10 / 2019))
            {
                throw new ArgumentException("Informe a data correta");
            }
            despesasDatabase.AlterarDespesa(despesa);
        }

        public void RemoverDespesa(int id)
        {
            if(id == 0 || id == null)
            {
                throw new ArgumentException("Informe qual registro pretende deletar");
            }

            despesasDatabase.RemoverDespesa(id);
        }

        public List<Database.Entity.tb_despesa> ListarTodos()
        {
            return despesasDatabase.ListarTodos();
        }

        public List<Database.Entity.tb_despesa> ConsultarPorReferencia(string referencia)
        {
            if(string.IsNullOrWhiteSpace(referencia))
            {
                throw new ArgumentException("Informe um parâmetro de consulta");
            }

            return despesasDatabase.ConsultarPorReferencia(referencia);
        }
    }
}
