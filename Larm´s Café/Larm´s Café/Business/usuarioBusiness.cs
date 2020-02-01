using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class usuarioBusiness
    {
        Database.usuarioDatabase usuarioDatabase = new Database.usuarioDatabase();

        public bool EfetuarLogin (string usuario, string senha)
        {
            //Remove os espaços
            usuario = usuario.Trim();
            senha = senha.Trim();
            // Condições para Verificar se os campos não estão vazios
            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new ArgumentException("Por favor, informe um usuário!");
            }
            if (string.IsNullOrWhiteSpace(senha))
            {
                throw new ArgumentException("Por favor, informe a senha!");
            }

            Objetos.AESCript cript = new Objetos.AESCript();
            senha = cript.Criptografar(senha);
            // Invocamento da função EfetuarLogin do Database
            bool contem = usuarioDatabase.EfetuarLogin(usuario, senha);

            if (contem == false)
            {

                throw new ArgumentException("Usuário não encontrado");
                return false;
            }
            return true;
        }

        public bool VerificarFuncionario(int funcionario)
        {
            //Verifica se não tem nada ou espaços em brancos
            if(funcionario == null)
            {
                throw new ArgumentException("Informe o Funcionário");
            }

            bool contem = usuarioDatabase.VerificarFuncionario(funcionario);
            return contem;
        }

        public void Cadastro(Database.Entity.tb_usuario usuario)
        {
            Objetos.AESCript cript = new Objetos.AESCript();
            usuario.nm_senha = cript.Criptografar(usuario.nm_senha);

            usuarioBusiness usuarioBusiness = new usuarioBusiness();
            if(string.IsNullOrWhiteSpace(usuario.nm_usuario))
            {
                throw new ArgumentException("Informe o usuário");
            }

            if(string.IsNullOrWhiteSpace(usuario.nm_senha))
            {
                throw new ArgumentException("Informe uma senha");
            }


            if (usuario.id_funcionario == 0 || usuario.id_funcionario == null)
            {
                throw new ArgumentException("Informe o funcionário");
            }
            bool contemVerificarFuncionario = usuarioDatabase.VerificarFuncionario(usuario.id_funcionario);

            if (contemVerificarFuncionario == false)
                throw new ArgumentException("Funcionário não existente");

            bool contemUsuario = usuarioDatabase.UsuarioExistente(usuario.nm_usuario);

            if (contemUsuario == true)
                throw new ArgumentException("Usuário existente");

            FuncionarioPossuiLogin(usuario.id_funcionario);

            usuarioDatabase.Cadastro(usuario);
        }

        public void FuncionarioPossuiLogin(int idFuncionario)
        {
            if (idFuncionario == null || idFuncionario == 0)
                throw new ArgumentException("Informe o usuário");

            bool contem = usuarioDatabase.FuncionarioPossuiLogin(idFuncionario);
            if(contem == true)
            {
                throw new ArgumentException("Esse funcionário já possui uma conta nesse sistema");
            }
        }

        public void ConsultarUsuario(string usuario, bool whatsapp)
        {
            
            if (string.IsNullOrWhiteSpace(usuario))
                throw new ArgumentException("Informe o usuário");

            Database.Entity.tb_usuario usu = usuarioDatabase.ConsultarUsuario(usuario);
            Objetos.CodigoAleatorio codigoAleatorio = new Objetos.CodigoAleatorio();
            Objetos.GmailSender gmailSender = new Objetos.GmailSender();
            
            string codigo = codigoAleatorio.GerarCodigo();

            string mensagem = "Olá, " + usu.tb_funcionario.nm_funcionario + ", seu código de alteração é: " + codigo;
            if (whatsapp == false)
            {
                gmailSender.EnviarSMS("+55" + usu.tb_funcionario.ds_telefone, mensagem);
                gmailSender.Enviar(usu.tb_funcionario.ds_email, "Código de recuperação", mensagem);
            }
            else
            {
                if ("+55" + usu.tb_funcionario.ds_telefone != "+5511994465801")
                    throw new ArgumentException("É diferente");

                gmailSender.EnviarWhatsApp("+55" + usu.tb_funcionario.ds_telefone, mensagem);
            }

            usuarioDatabase.AdicionarCodigo(codigo, usuario);
        }

        public Database.Entity.tb_usuario ModeloUsuarioAtivo(string usuario)
        {
            return usuarioDatabase.ModeloUsuarioAtivo(usuario);
        }

        public void AlterarSenha(string usuario, string senha, string codigo)
        {
            if(string.IsNullOrWhiteSpace(usuario))
            {
                throw new ArgumentException("Informe o usuário");
            }

            if(string.IsNullOrWhiteSpace(senha))
            {
                throw new ArgumentException("Informe a senha");
            }

            if(string.IsNullOrWhiteSpace(codigo))
            {
                throw new ArgumentException("Informe o código");
            }

            bool existeUsuario = usuarioDatabase.UsuarioExistente(usuario);
            bool codigoValido = usuarioDatabase.VerificarCodigo(usuario, codigo);

            if (existeUsuario == false)
                throw new ArgumentException("Usuário não encontrado");

            if (codigoValido == false)
                throw new ArgumentException("Código não válido");

            Objetos.AESCript cript = new Objetos.AESCript();
            senha = cript.Criptografar(senha);

            usuarioDatabase.AlterarSenha(usuario, senha, codigo);

        }
    }
}
