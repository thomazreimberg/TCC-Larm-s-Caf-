using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class materiaPrimaDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public void InserirMateriaPrima(Entity.tb_materia_prima materiaPrima)
        {
            larmscafeEntities.tb_materia_prima.Add(materiaPrima);
            larmscafeEntities.SaveChanges();
        }

        public List<Entity.tb_materia_prima> ConsultarMateriaPrima(string produto, string categoria)
        {
            List<Entity.tb_materia_prima> lista = larmscafeEntities.tb_materia_prima.
                                                                   Where(x => x.nm_produto.
                                                                Contains(produto) && x.ds_categoria == categoria).
                                                                  ToList();
            return lista;
        }

        public void AlterarMateriaPrima(Entity.tb_materia_prima materiaPrima)// Pegar o id do DataGridView
        {
            Entity.tb_materia_prima alterar = larmscafeEntities.tb_materia_prima.
                                                                     First(x => x.id_materia_prima == materiaPrima.id_materia_prima);
            alterar.nm_produto = materiaPrima.nm_produto;
            alterar.vl_preco = materiaPrima.vl_preco;
            alterar.ds_categoria = materiaPrima.ds_categoria;
            

            larmscafeEntities.SaveChanges();
        }

        public void RemoverMateriaPrima(int id)
        {
            Entity.tb_materia_prima remover = larmscafeEntities.tb_materia_prima.
                                                               First(x => x.id_materia_prima == id);
            larmscafeEntities.tb_materia_prima.Remove(remover);

            larmscafeEntities.SaveChanges();
        }

        public List<Database.Entity.tb_materia_prima> ListarTodos()
        {
            return larmscafeEntities.tb_materia_prima.ToList();
        }
    }
}
