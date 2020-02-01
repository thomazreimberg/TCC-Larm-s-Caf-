using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class fornecedorBusiness
    {
        Database.fornecedorDatabase fornecedorDatabase = new Database.fornecedorDatabase();
        public void InserirFornecedor(Database.Entity.tb_fornecedores fornecedores)
        {
            if (string.IsNullOrWhiteSpace(fornecedores.nm_empresa_fornecedor))
                throw new ArgumentException("Informe o nome da empresa do fornecedor");


            if (string.IsNullOrWhiteSpace(fornecedores.ds_cnpj))
                throw new ArgumentException("Informe o CNPJ");


            if (string.IsNullOrWhiteSpace(fornecedores.ds_marca_fornecida))
                throw new ArgumentException("Informe a marca");


            if (string.IsNullOrWhiteSpace(fornecedores.ds_telefone))
                throw new ArgumentException("Informe o funcionário");

            fornecedorDatabase.InserirFornecedor(fornecedores);
        }

        public List<Database.Entity.tb_fornecedores> ConsultarTodos()
        {
            return fornecedorDatabase.ConsultarTodos();
        }

        public List<Database.Entity.tb_fornecedores> ConsultarFornecedores(string fornecedor)
        {
            if (string.IsNullOrWhiteSpace(fornecedor))
                throw new ArgumentException("Informe a marca");

            return fornecedorDatabase.ConsultarFornecedores(fornecedor);
        }

        public void AlterarFornecedores(Database.Entity.tb_fornecedores fornecedores)
        {
            if(fornecedores.id_fornecedores == null || fornecedores.id_fornecedores == 0)
                throw new ArgumentException("Informe um fornecedor");

            if (string.IsNullOrWhiteSpace(fornecedores.nm_empresa_fornecedor))
                throw new ArgumentException("Informe o nome da empresa do fornecedor");


            if (string.IsNullOrWhiteSpace(fornecedores.ds_cnpj))
                throw new ArgumentException("Informe o CNPJ");


            if (string.IsNullOrWhiteSpace(fornecedores.ds_marca_fornecida))
                throw new ArgumentException("Informe a marca");


            if (string.IsNullOrWhiteSpace(fornecedores.ds_telefone))
                throw new ArgumentException("Informe o funcionário");
            fornecedorDatabase.AlterarFornecedores(fornecedores);
        }

        public void RemoverFornecedor(int id)
        {
            if (id == null || id == 0)
                throw new ArgumentException("Informe um fornecedor");

            fornecedorDatabase.RemoverFornecedor(id);
        }
    }
}
