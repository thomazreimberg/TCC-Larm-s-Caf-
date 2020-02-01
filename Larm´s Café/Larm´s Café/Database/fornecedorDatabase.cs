using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class fornecedorDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public void InserirFornecedor (Entity.tb_fornecedores fornecedores)
        {
            larmscafeEntities.tb_fornecedores.
                                          Add(fornecedores);
            larmscafeEntities.SaveChanges();
        }

        public List<Entity.tb_fornecedores> ConsultarTodos()
        {
            List<Entity.tb_fornecedores> lista = larmscafeEntities.tb_fornecedores.
                                                                            ToList();
            return lista;
        }

        public List<Entity.tb_fornecedores> ConsultarFornecedores (string fornecedor)
        {
            List<Entity.tb_fornecedores> lista = larmscafeEntities.tb_fornecedores.
                                                                             Where(x => x.nm_empresa_fornecedor.
                                                                          Contains(fornecedor)).
                                                                            ToList();
            return lista;
        }

        public void AlterarFornecedores(Entity.tb_fornecedores fornecedores)
        {
            Entity.tb_fornecedores alterar = larmscafeEntities.tb_fornecedores.
                                                                         First(x => x.id_fornecedores == fornecedores.id_fornecedores);
            alterar.nm_empresa_fornecedor = fornecedores.nm_empresa_fornecedor;
            alterar.ds_cnpj = fornecedores.ds_cnpj;
            alterar.ds_telefone = fornecedores.ds_telefone;

            larmscafeEntities.SaveChanges();
        }

        public void RemoverFornecedor(int id)
        {
            Entity.tb_fornecedores remover = larmscafeEntities.tb_fornecedores.
                                                                         First(x => x.id_fornecedores == id);

            larmscafeEntities.tb_fornecedores.Remove(remover);
            larmscafeEntities.SaveChanges();
        }
    }
}
