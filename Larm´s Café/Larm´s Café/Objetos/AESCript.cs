using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Objetos
{
    class AESCript
    { //Código alterado por medidas de segurança
        public string Criptografar(string mensagem)
        {
            string chave = "--"; 
            // Cria objeto para criptografia AES
            System.Security.Cryptography.RijndaelManaged rijndael = new System.Security.Cryptography.RijndaelManaged();
            rijndael.Mode = System.Security.Cryptography.CipherMode.CBC;
            rijndael.KeySize = 128;

            byte[] chaveBytes;
            byte[] criptografiaBytes;
            byte[] mensagemBytes;
            string criptografia;

            // Transforma chave e mensagem em array de byts
            chaveBytes = Encoding.UTF8.GetBytes(chave);
            mensagemBytes = Encoding.UTF8.GetBytes(mensagem);

            // Realiza criptografia
            System.Security.Cryptography.ICryptoTransform cryptor = rijndael.CreateEncryptor(chaveBytes, chaveBytes);
            criptografiaBytes = cryptor.TransformFinalBlock(mensagemBytes, 0, mensagemBytes.Length);
            cryptor.Dispose();

            // Transforma criptografia em string
            criptografia = Convert.ToBase64String(criptografiaBytes);
            return criptografia;
        }


        public string Descriptografar(string criptografia)
        {
            string chave = "--";
            // Cria objeto para criptografia AES
            System.Security.Cryptography.RijndaelManaged rijndael = new System.Security.Cryptography.RijndaelManaged();
            rijndael.Mode = System.Security.Cryptography.CipherMode.CBC;
            rijndael.KeySize = 128;

            byte[] chaveBytes;
            byte[] criptografiaBytes;
            byte[] mensagemBytes;
            string mensagem;

            // Transforma chave e mensagem em array de byts
            chaveBytes = Encoding.UTF8.GetBytes(chave);
            mensagemBytes = Convert.FromBase64String(criptografia);


            // Realiza criptografia
            System.Security.Cryptography.ICryptoTransform cryptor = rijndael.CreateDecryptor(chaveBytes, chaveBytes);
            criptografiaBytes = cryptor.TransformFinalBlock(mensagemBytes, 0, mensagemBytes.Length);
            cryptor.Dispose();

            // Transforma criptografia em string
            mensagem = Encoding.UTF8.GetString(criptografiaBytes);
            return mensagem;
        }
    }
}
