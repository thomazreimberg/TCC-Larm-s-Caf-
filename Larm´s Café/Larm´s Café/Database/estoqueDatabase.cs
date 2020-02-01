using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class estoqueDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public void InserirEstoque(Entity.tb_estoque estoque)

        {
            larmscafeEntities.tb_estoque.Add(estoque);
            larmscafeEntities.SaveChanges();
        }

        public List<Entity.tb_estoque> ConsultarEstoque(string produto, string categoria, bool urgente, bool abastecer)
        {
            return larmscafeEntities.tb_estoque.Where(x => x.tb_materia_prima.nm_produto.Contains(produto) &&
                                                           x.tb_materia_prima.ds_categoria == categoria &&
                                                           x.bt_urgente == urgente &&
                                                           x.bt_abastecer == abastecer).ToList();
        }

        public List<Entity.tb_estoque> ConsultarTodos()
        {
            return larmscafeEntities.tb_estoque.ToList();
        }

        public void Alterar(Entity.tb_estoque estoque)
        {
            Entity.tb_estoque alterar = larmscafeEntities.tb_estoque.First(x => x.id_estoque == estoque.id_estoque);
            alterar.id_materia_prima = estoque.id_materia_prima;
            alterar.qt_estoque = estoque.qt_estoque;
            alterar.vl_total = estoque.vl_total;
            alterar.dt_validade_prevista = estoque.dt_validade_prevista;
            alterar.ds_situacao_produto = estoque.ds_situacao_produto;
            alterar.ds_especificacao = estoque.ds_especificacao;
            alterar.bt_urgente = estoque.bt_urgente;
            alterar.bt_abastecer = estoque.bt_abastecer;

            larmscafeEntities.SaveChanges();
        }
    }
}
