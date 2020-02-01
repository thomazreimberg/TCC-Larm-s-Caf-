using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Larm_s_Café.Business
{
    class funcionarioBusiness
    {
        Database.funcionarioDatabase funcionarioDatabase = new Database.funcionarioDatabase();

        public void InserirFuncionario(Database.Entity.tb_funcionario funcionario)
        {
            Regex regex = new Regex("^[0-9]{3}.?[0-9]{3}.?[0-9]{3}-?[0-9]{2}");

            if (regex.IsMatch(funcionario.ds_cpf))
                throw new ArgumentException("Informe um CPF válido");

            if (string.IsNullOrWhiteSpace(funcionario.nm_funcionario))
                throw new ArgumentException("Informe o nome do funcionário");

            if (string.IsNullOrWhiteSpace(funcionario.ds_email) || funcionario.ds_email.Contains("@") == false)
                throw new ArgumentException("Informe um e-mail válido");

            if (string.IsNullOrWhiteSpace(funcionario.ds_endereco))
                throw new ArgumentException("Informe o endereço");

            if (string.IsNullOrWhiteSpace(funcionario.ds_telefone))
                throw new ArgumentException("Informe o telefone");

            if (funcionario.vl_salario_bruto == 0.00m)
                throw new ArgumentException("Informe um valor acima de 0,00");

            if (funcionario.dt_demitido != DateTime.Now.Date)
                throw new ArgumentException("essa data já passou");

            if (funcionario.dt_adimissao < DateTime.Now.Date)
                throw new ArgumentException("essa data já passou");

            
            if (funcionario.vl_inss == 0.00m)
                throw new ArgumentException("Informe um valor acima de 0,00");

            if (funcionario.vl_salario_familia == 0.00m)
                throw new ArgumentException("Informe um valor acima de 0,00");

            if (funcionario.vl_periculosidade == 0.00m)
                throw new ArgumentException("Informe um valor acima de 0,00");

            if (funcionario.vl_insalubridade == 0.00m)
                throw new ArgumentException("Informe um valor acima de 0,00");

            


            funcionarioDatabase.InserirFuncionario(funcionario);

        }

        public List<Database.Entity.tb_funcionario> ConsultarTodos()
        {
            return funcionarioDatabase.ConsultarTodos();
        }

        public List<Database.Entity.tb_funcionario> ConsultarFuncionario(string funcionario, int id)
        {
            return funcionarioDatabase.ConsultarFuncionario(funcionario, id);
        }

        public void AlterarFuncionrio(Database.Entity.tb_funcionario funcionario)
        {
            Regex regex = new Regex("^[0-9]{3}.?[0-9]{3}.?[0-9]{3}-?[0-9]{2}");

            if (regex.IsMatch(funcionario.ds_cpf))
                throw new ArgumentException("Informe um CPF válido");

            if (string.IsNullOrWhiteSpace(funcionario.nm_funcionario))
                throw new ArgumentException("Informe o nome do funcionário");

            if (string.IsNullOrWhiteSpace(funcionario.ds_email) || funcionario.ds_email.Contains("@") == false)
                throw new ArgumentException("Informe um e-mail válido");

            if (string.IsNullOrWhiteSpace(funcionario.ds_endereco))
                throw new ArgumentException("Informe o endereço");

            if (string.IsNullOrWhiteSpace(funcionario.ds_telefone))
                throw new ArgumentException("Informe o telefone");

            if (funcionario.vl_salario_bruto == 0.00m)
                throw new ArgumentException("Informe um valor acima de 0,00");

            if (funcionario.vl_salario_familia == 0.00m)
                throw new ArgumentException("Informe um valor acima de 0,00");

            if (funcionario.vl_periculosidade == 0.00m)
                throw new ArgumentException("Informe um valor acima de 0,00");

            funcionarioDatabase.AlterarFuncionrio(funcionario);
        }

        public void RemoverFuncionario(int id)
        {
            funcionarioDatabase.RemoverFuncionario(id);
        }

        public List<Database.Entity.tb_funcionario> ConsultarFuncionarioAlterar(string funcionario)
        {
            if (string.IsNullOrWhiteSpace(funcionario))
                throw new ArgumentException("Informe o nome do funcionário");

            return funcionarioDatabase.ConsultarFuncionarioAlterar(funcionario);
        }
    }
}
