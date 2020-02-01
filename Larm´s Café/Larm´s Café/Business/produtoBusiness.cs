using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class produtoBusiness
    {
        Database.produtoDatabase produtoDatabase = new Database.produtoDatabase();
        public void InserirProduto(Database.Entity.tb_produto produto)
        {
            if (string.IsNullOrWhiteSpace(produto.nm_produto))
            {
                throw new ArgumentException("Informe o nome do produto");
            }

            if (string.IsNullOrWhiteSpace(produto.ds_categoria))
            {
                throw new ArgumentException("Informe a categoria");
            }

            if(string.IsNullOrWhiteSpace(produto.ds_observacao))
            {
                throw new ArgumentException("Informe uma observação");
            }

            if(produto.vl_preco == 0.00m || produto.vl_preco == null)
            {
                throw new ArgumentException("Informe o preço do produto");
            }

            produtoDatabase.InserirProduto(produto);
        }

        public List<Database.Entity.tb_produto> ConsultarProduto(string produto, string categoria)
        {
            if(string.IsNullOrWhiteSpace(produto))
            {
                throw new ArgumentException("Informe o nome do produto");
            }

            if(string.IsNullOrWhiteSpace(categoria))
            {
                throw new ArgumentException("Informe a categoria");
            }

            List<Database.Entity.tb_produto> lista = produtoDatabase.ConsultarProduto(produto, categoria);
            return lista;
        }

        public void AlterarProduto(Database.Entity.tb_produto produto)// Pegar o id do DataGridView
        {
            if (string.IsNullOrWhiteSpace(produto.nm_produto))
            {
                throw new ArgumentException("Informe o nome do produto");
            }

            if (string.IsNullOrWhiteSpace(produto.ds_categoria))
            {
                throw new ArgumentException("Informe a categoria");
            }

            if (string.IsNullOrWhiteSpace(produto.ds_observacao))
            {
                throw new ArgumentException("Informe uma observação");
            }

            if (produto.vl_preco == 0.00m || produto.vl_preco == null)
            {
                throw new ArgumentException("Informe o preço do produto");
            }

            if(produto.id_produtos == 0 || produto.id_produtos == null)
            {
                throw new ArgumentException("Informe o registro que deseja alterar");
            }

            produtoDatabase.AlterarProduto(produto);
        }

        public void RemoverProduto(int id)
        {
            if (id == 0 || id == null)
            {
                throw new ArgumentException("Informe o registro que deseja remover");
            }

            produtoDatabase.RemoverProduto(id);
        }

        public List<Database.Entity.tb_produto> ListarTodos()
        {
            return produtoDatabase.ListarTodos();
        }
    }
}
