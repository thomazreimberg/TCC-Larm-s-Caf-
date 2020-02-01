using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class cargoDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public void InserirCargo(Entity.tb_cargo cargo)
        {
            larmscafeEntities.tb_cargo.
                                   Add(cargo);
            larmscafeEntities.SaveChanges();
        }

        public List<Entity.tb_cargo> ConsultarTodos()
        {
            List<Entity.tb_cargo> lista = larmscafeEntities.tb_cargo.
                                                              ToList();
            return lista;
        }

        public List<Entity.tb_cargo> Consultarcargo(string cargo)
        {
            List<Entity.tb_cargo> lista = larmscafeEntities.tb_cargo.
                                                               Where(x => x.ds_cargo == cargo).
                                                              ToList();
            return lista;
        }

        public void AlterarCodigo(Entity.tb_cargo cargo)
        {
            Entity.tb_cargo alterar = larmscafeEntities.tb_cargo.
                                                           First(x => x.id_cargo == cargo.id_cargo);
            alterar.ds_cargo = cargo.ds_cargo;
            alterar.ds_codigo_cargo = cargo.ds_codigo_cargo;

            larmscafeEntities.SaveChanges();
        }

        public void RemoverCargo(int id)
        {
            Entity.tb_cargo remover = larmscafeEntities.tb_cargo.
                                                           First(x => x.id_cargo == id);
            larmscafeEntities.tb_cargo.
                                Remove(remover);

            larmscafeEntities.SaveChanges();
        }

        public List<Entity.tb_funcionario> ConsultarCargoEFuncionario(string funcionario, string cargo)
        {
            return larmscafeEntities.tb_funcionario.
                                              Where(x => x.nm_funcionario.
                                           Contains(funcionario) && x.tb_cargo.ds_cargo == cargo).ToList();
        }
    }
}
