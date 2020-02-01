using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class estoqueBusiness
    {
        Database.estoqueDatabase estoqueDatabase = new Database.estoqueDatabase();
        public void InserirEstoque(Database.Entity.tb_estoque estoque)
        {
            
            if (string.IsNullOrWhiteSpace(estoque.ds_situacao_produto))
                    throw new ArgumentException("Informe a situação do produto");

            if (string.IsNullOrWhiteSpace(estoque.ds_especificacao))
                throw new ArgumentException("Informe a situação da especificação");
    

            if (estoque.qt_estoque == 0.00m)
                throw new ArgumentException("Informe a quantidade do produto");

            if (estoque.dt_validade_prevista < DateTime.Now.Date)
                throw new ArgumentException("Essa data já passou");

            if (estoque.vl_total == 0.00m)
                throw new ArgumentException("Informe o total");

            if (estoque.id_materia_prima == null || estoque.id_materia_prima == 0)
                throw new ArgumentException("Informe a matéria prima");

            estoqueDatabase.InserirEstoque(estoque);
        }

        public List<Database.Entity.tb_estoque> ConsultarEstoque(string produto, string categoria, bool urgente, bool abastecer)
        {
            return estoqueDatabase.ConsultarEstoque(produto, categoria, urgente, abastecer);
        }

        public List<Database.Entity.tb_estoque> ConsultarTodos()
        {
            return estoqueDatabase.ConsultarTodos();
        }

        public void Alterar(Database.Entity.tb_estoque estoque)
        {
            if (string.IsNullOrWhiteSpace(estoque.ds_situacao_produto))
                throw new ArgumentException("Informe a situação do produto");

            if (string.IsNullOrWhiteSpace(estoque.ds_especificacao))
                throw new ArgumentException("Informe a situação da especificação");


            if (estoque.qt_estoque == 0.00m)
                throw new ArgumentException("Informe a quantidade do produto");

            if (estoque.dt_validade_prevista < DateTime.Now.Date)
                throw new ArgumentException("Essa data já passou");

            if (estoque.vl_total == 0.00m)
                throw new ArgumentException("Informe o total");

            if (estoque.id_materia_prima == null || estoque.id_materia_prima == 0)
                throw new ArgumentException("Informe a matéria prima");

            estoqueDatabase.Alterar(estoque);
        }
    }
}
