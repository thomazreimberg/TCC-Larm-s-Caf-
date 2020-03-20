using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Objetos
{
    class CodigoAleatorio
    {
        public string GerarCodigo()
        {
            int tamanhoSenha = 10;
            string senha = string.Empty;

            for(int i = 0; i < tamanhoSenha; i++)
            {
                Random random = new Random();
                int codigo = Convert.ToInt32(random.Next(48, 122).ToString());
                if((codigo >= 48 && codigo <= 57) || codigo >= 97 && codigo <= 122)
                {
                    string _char = ((char)codigo).ToString();
                    if (!senha.Contains(_char))
                    {
                        senha += _char;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }
            return senha;
        }
    }
}
