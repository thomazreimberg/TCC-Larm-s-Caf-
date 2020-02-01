using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class cargoBusiness
    {
        Database.cargoDatabase cargoDatabase = new Database.cargoDatabase();

        public void InserirCargo(Database.Entity.tb_cargo cargo)
        {
            if (string.IsNullOrWhiteSpace(cargo.ds_cargo))
                throw new ArgumentException("Informe o nome do cargo");

            if (string.IsNullOrWhiteSpace(cargo.ds_codigo_cargo))
                throw new ArgumentException("Informe o novo código");

            cargoDatabase.InserirCargo(cargo);
        }

        public List<Database.Entity.tb_cargo> ConsultarTodos()
        {
            List<Database.Entity.tb_cargo> lista = cargoDatabase.ConsultarTodos();
            return lista;
        }

        public List<Database.Entity.tb_cargo> Consultarcargo(string cargo)
        {
            if (string.IsNullOrWhiteSpace(cargo))
                throw new ArgumentException("Informe o nome do cargo");

            
            return cargoDatabase.Consultarcargo(cargo);
        }

        public void AlterarCodigo(Database.Entity.tb_cargo cargo)
        {
            if (string.IsNullOrWhiteSpace(cargo.ds_cargo))
                throw new ArgumentException("Informe o nome do cargo");

            if (string.IsNullOrWhiteSpace(cargo.ds_codigo_cargo))
                throw new ArgumentException("Informe o novo código");

            cargoDatabase.AlterarCodigo(cargo);
        }

        public void RemoverCargo(int id)
        {
            if(id == 0)
            {
                throw new ArgumentException("Informe qual registro pretende apagar");
            }

            cargoDatabase.RemoverCargo(id);
        }

        public List<Database.Entity.tb_funcionario> ConsultarCargoEFuncionario(string funcionario, string cargo)
        {
            if(string.IsNullOrWhiteSpace(funcionario))
            {
                throw new ArgumentException("Informe o nome do funcionário");
            }

            if(string.IsNullOrWhiteSpace(cargo))
            {
                throw new ArgumentException("Informe o cargo do funcionário");
            }

            return cargoDatabase.ConsultarCargoEFuncionario(funcionario, cargo);
        }
    }
}
