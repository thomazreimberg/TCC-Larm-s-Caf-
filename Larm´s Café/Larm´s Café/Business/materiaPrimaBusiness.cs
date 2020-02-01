using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class materiaPrimaBusiness
    {
        Database.materiaPrimaDatabase materiaPrimaDatabase = new Database.materiaPrimaDatabase();
        public void InserirMateriaPrima(Database.Entity.tb_materia_prima materiaPrima)
        {
            if (string.IsNullOrWhiteSpace(materiaPrima.nm_produto))
            {
                throw new ArgumentException("Informe o nome do produto");
            }

            if (string.IsNullOrWhiteSpace(materiaPrima.ds_categoria))
            {
                throw new ArgumentException("Informe a categoria");
            }

            if (materiaPrima.vl_preco == 0.00m || materiaPrima.vl_preco == null)
            {
                throw new ArgumentException("Informe o preço do produto");
            }

            materiaPrimaDatabase.InserirMateriaPrima(materiaPrima);
        }

        public List<Database.Entity.tb_materia_prima> ConsultarMateriaPrima(string produto, string categoria)
        {
            if (string.IsNullOrWhiteSpace(produto))
            {
                throw new ArgumentException("Informe o nome do produto");
            }

            if (string.IsNullOrWhiteSpace(categoria))
            {
                throw new ArgumentException("Informe a categoria");
            }

            List<Database.Entity.tb_materia_prima> lista = materiaPrimaDatabase.ConsultarMateriaPrima(produto, categoria);
            return lista;
        }

        public void AlterarMateriaPrima(Database.Entity.tb_materia_prima materiaPrima)// Pegar o id do DataGridView
        {
            if (string.IsNullOrWhiteSpace(materiaPrima.nm_produto))
            {
                throw new ArgumentException("Informe o nome do produto");
            }

            if (string.IsNullOrWhiteSpace(materiaPrima.ds_categoria))
            {
                throw new ArgumentException("Informe a categoria");
            }

            if (materiaPrima.vl_preco == 0.00m || materiaPrima.vl_preco == null)
            {
                throw new ArgumentException("Informe o preço do produto");
            }

            if (materiaPrima.id_materia_prima == 0 || materiaPrima.id_materia_prima == null)
            {
                throw new ArgumentException("Informe o registro que deseja alterar");
            }

            materiaPrimaDatabase.AlterarMateriaPrima(materiaPrima);
        }

        public void RemoverMateriaPrima(int id)
        {
            if (id == 0 || id == null)
            {
                throw new ArgumentException("Informe o registro que deseja remover");
            }

            materiaPrimaDatabase.RemoverMateriaPrima(id);
        }

        public List<Database.Entity.tb_materia_prima> ListarTodos()
        {
            return materiaPrimaDatabase.ListarTodos();
        }
    }
}
