using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database.Entity
{
    class clienteDatabase
    {
        larmscafeEntities1 larmscafeEntities = new larmscafeEntities1();

        public void InserirCliente(tb_cliente cliente)
        {
            larmscafeEntities.tb_cliente.Add(cliente);
            larmscafeEntities.SaveChanges();
        }

        public List<tb_cliente> ConsultarCliente(string nome, bool ativo, bool fidelizado)
        {
            List<tb_cliente> consulta = larmscafeEntities.tb_cliente.
                                                               Where(x => x.nm_cliente.Contains(nome) &&
                                                               x.bt_ativo == ativo &&
                                                               x.bt_fidelizado == fidelizado).ToList();

            return consulta;
        }

        public void AlterarCliente(tb_cliente cliente, int id)
        {
            tb_cliente alterar = larmscafeEntities.tb_cliente.First(x => x.id_cliente == id);
            alterar.nm_cliente = cliente.nm_cliente;
            alterar.ds_telefone = cliente.ds_telefone;
            alterar.ds_endereco = cliente.ds_endereco;
            alterar.ds_email = cliente.ds_email;
            alterar.bt_fidelizado = cliente.bt_fidelizado;
            alterar.bt_ativo = cliente.bt_ativo;

            larmscafeEntities.SaveChanges();
        }

        public bool VerificarSeExisteOCliente(string nomeCliente)
        {
            bool existe = larmscafeEntities.tb_cliente.Any(x => x.nm_cliente == nomeCliente);

            return existe;
        }

        public List<tb_cliente> ListarTodos()
        {
            return larmscafeEntities.tb_cliente.ToList();
        }
    }
}
