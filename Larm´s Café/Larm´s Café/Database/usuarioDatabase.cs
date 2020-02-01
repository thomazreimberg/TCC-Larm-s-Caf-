using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class usuarioDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public bool EfetuarLogin (string usuario, string senha)
        {
            bool contem = larmscafeEntities.tb_usuario
                                           .Any(x => x.nm_usuario == usuario && x.nm_senha == senha);

            return contem;
        }

        public bool VerificarFuncionario (int funcionario)
        {
            bool contem = larmscafeEntities.tb_funcionario
                                           .Any(x => x.id_funcionario == funcionario);
            return contem;
        }

        public void Cadastro(Entity.tb_usuario usuario)
        {
            larmscafeEntities.tb_usuario
                             .Add(usuario);
            larmscafeEntities.SaveChanges();
        }

        // Exemplo Join
        // Estou usando var, mas tambem funcionaria se colocasse uma lista de string.
        // Usem o var apenas para identificar exatamente qual tipo de variável vai ser usado, e depois troquem...

        //var a = larmscafeEntities.tb_usuario
        //.Select(x => x.nm_usuario + ":" + x.tb_funcionario.nm_funcionario)
        // .ToList();

        //var r = larmscafeEntities.tb_usuario// Tabela usada (from table1)
        // .Join(larmscafeEntities.tb_funcionario, //tabela que pretendo utilizar o join... (join table 2)
        //  c => c.id_funcionario, p => p.id_funcionario, // a letra c (nesse caso que eu fiz) representa a tabela de usuario
        //a letra p (mesma coisa) representa o id do funcionário (tem digitar tudo pois não apareceu para completar depois do p. ...
        // (c, p) => c.nm_usuario + "corresponde ao funcionário:" + p.nm_funcionario).ToList();
        // Joga na lista de string o nome do usuario + a mensagem + o nome do funcionario da tabela de funcionários

        public bool UsuarioExistente (string usuario)
        {
            //Verifica se já existe esse usuário
            bool contem = larmscafeEntities.tb_usuario
                                           .Any(x => x.nm_usuario == usuario);

            return contem;
        }

        public bool FuncionarioUsuario (string funcionario)
        {
            //Verifica se esse funcioário já tem um usuário
            bool contem = larmscafeEntities.tb_usuario
                                           .Any(x => x.tb_funcionario.nm_funcionario == funcionario);

            return contem;
        }

        public bool FuncionarioPossuiLogin(int idFuncionario)
        {
            return larmscafeEntities.tb_usuario.Any(x => x.id_funcionario == idFuncionario);
        }

        public Entity.tb_usuario ConsultarUsuario(string usuario)
        {
            return larmscafeEntities.tb_usuario.First(x => x.nm_usuario == usuario); 
        }

        public void AdicionarCodigo(string codigo, string usuario)
        {
            Entity.tb_usuario alterar = larmscafeEntities.tb_usuario.First(x => x.nm_usuario == usuario);
            alterar.ds_codigo_alteracao = codigo;
            larmscafeEntities.SaveChanges();
        }

        public void LimparCodigo(string usuario)
        {
            Entity.tb_usuario alterar = larmscafeEntities.tb_usuario.First(x => x.nm_usuario == usuario);
            alterar.ds_codigo_alteracao = string.Empty;
            larmscafeEntities.SaveChanges();
        }

        public Entity.tb_usuario ModeloUsuarioAtivo (string usuario)
        {
            Entity.tb_usuario lista = larmscafeEntities.tb_usuario.
                                                    FirstOrDefault(x => x.nm_usuario == usuario);

            return lista;
        }

        public void AlterarSenha(string usuario, string senha, string codigo)
        {
            Entity.tb_usuario alterar = larmscafeEntities.tb_usuario.First(x => x.nm_usuario == usuario && 
                                                                                x.ds_codigo_alteracao == codigo);
            alterar.ds_codigo_alteracao = "";
            alterar.nm_senha = senha;

            larmscafeEntities.SaveChanges();
        }

        public bool VerificarCodigo(string usuario, string codigo)
        {
            return larmscafeEntities.tb_usuario.Any(x => x.nm_usuario == usuario && 
                                                         x.ds_codigo_alteracao == codigo);
        }


    }
}
