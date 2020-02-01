using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class clienteBusiness
    {

        Database.Entity.clienteDatabase clienteDatabase = new Database.Entity.clienteDatabase();
        public void InserirCliente(Database.Entity.tb_cliente cliente)
        {
            cliente.nm_cliente.Trim();
            cliente.ds_endereco.Trim();
            cliente.ds_email.Trim();

            if(string.IsNullOrWhiteSpace(cliente.nm_cliente))
            {
                throw new ArgumentException("Informe o nome do cliente");
            }

            if(string.IsNullOrWhiteSpace(cliente.ds_email))
            {
                throw new ArgumentException("Informe o e-mail do cliente");
            }

            if(cliente.ds_email.Contains("@") == false)
            {
                throw new ArgumentException("E-mail inválido");
            }

            if(string.IsNullOrWhiteSpace(cliente.ds_endereco))
            {
                throw new ArgumentException("Informe o endereço");
            }

            if(string.IsNullOrWhiteSpace(cliente.ds_telefone))
            {
                throw new ArgumentException("Informe o telefone do cliente");
            }

            bool existe = clienteDatabase.VerificarSeExisteOCliente(cliente.nm_cliente);
            if(existe == true)
            {
                throw new ArgumentException("Cliente já existente");
            }

            clienteDatabase.InserirCliente(cliente);

        }

        public List<Database.Entity.tb_cliente> ConsultarCliente(string nome, bool ativo, bool fidelizado)
        {
            nome = nome.Trim();

            if(string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("Informe o nome para Consultar");
            }

            List<Database.Entity.tb_cliente> cliente = clienteDatabase.ConsultarCliente(nome, ativo, fidelizado);
            return cliente;
        }

        public void AlterarCliente(Database.Entity.tb_cliente cliente, int id)
        {
            cliente.nm_cliente.Trim();
            cliente.ds_endereco.Trim();
            cliente.ds_email.Trim();

            if (string.IsNullOrWhiteSpace(cliente.nm_cliente))
            {
                throw new ArgumentException("Informe o nome do cliente");
            }

            if (string.IsNullOrWhiteSpace(cliente.ds_email))
            {
                throw new ArgumentException("Informe o e-mail do cliente");
            }

            if (cliente.ds_email.Contains("@") == false)
            {
                throw new ArgumentException("E-mail inválido");
            }

            if (string.IsNullOrWhiteSpace(cliente.ds_endereco))
            {
                throw new ArgumentException("Informe o endereço");
            }

            if (string.IsNullOrWhiteSpace(cliente.ds_telefone))
            {
                throw new ArgumentException("Informe o telefone do cliente");
            }

            clienteDatabase.AlterarCliente(cliente, id);

        }

        public List<Database.Entity.tb_cliente> ListarTodos()
        {
            return clienteDatabase.ListarTodos();
        }
    }
}
