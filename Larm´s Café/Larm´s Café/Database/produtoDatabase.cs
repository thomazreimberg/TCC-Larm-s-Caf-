using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class produtoDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public void InserirProduto (Entity.tb_produto produto)
        {
            larmscafeEntities.tb_produto.
                                     Add(produto);
            larmscafeEntities.SaveChanges();
        }

        public List<Entity.tb_produto> ConsultarProduto(string produto, string categoria)
        {
            List<Entity.tb_produto> lista = larmscafeEntities.tb_produto.
                                                                   Where(x => x.nm_produto.
                                                                Contains(produto) && x.ds_categoria == categoria).
                                                                  ToList();
            return lista;
        }

        public void AlterarProduto (Entity.tb_produto produto)// Pegar o id do DataGridView
        {
            Entity.tb_produto alterar = larmscafeEntities.tb_produto.First(x => x.id_produtos == produto.id_produtos);
            alterar.nm_produto = produto.nm_produto;
            alterar.vl_preco = produto.vl_preco;
            alterar.ds_categoria = produto.ds_categoria;
            alterar.ds_observacao = produto.ds_observacao;

            larmscafeEntities.SaveChanges();
        }

        public void RemoverProduto (int id)
        {
            Entity.tb_produto remover = larmscafeEntities.tb_produto.First(x => x.id_produtos == id);
            larmscafeEntities.tb_produto.Remove(remover);

            larmscafeEntities.SaveChanges();
        }

        public List<Entity.tb_produto> ListarTodos()
        {
            return larmscafeEntities.tb_produto.ToList();
        }
    }
}
