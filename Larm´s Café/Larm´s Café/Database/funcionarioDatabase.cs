using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class funcionarioDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public void InserirFuncionario(Entity.tb_funcionario funcionario)
        {
            larmscafeEntities.tb_funcionario
                             .Add(funcionario);

            larmscafeEntities.SaveChanges();
        }

        public List<Entity.tb_funcionario> ConsultarTodos()
        {
            List<Entity.tb_funcionario> lista = larmscafeEntities.tb_funcionario.ToList();
            return lista;
        }

        public List<Entity.tb_funcionario> ConsultarFuncionario(string funcionario, int id)
        {
            return larmscafeEntities.tb_funcionario.
                                              Where(x => x.id_cargo == id && x.nm_funcionario == funcionario)
                                                   .ToList();
        }

        public List<Entity.tb_funcionario> ConsultarFuncionarioAlterar(string funcionario)
        {
            return larmscafeEntities.tb_funcionario.
                                              Where(x => x.nm_funcionario == funcionario)
                                                   .ToList();
        }

        public void AlterarFuncionrio(Entity.tb_funcionario funcionario)
        {
            Entity.tb_funcionario alterar = larmscafeEntities.tb_funcionario.
                                                                           First(x => x.id_funcionario == funcionario.id_funcionario);

            alterar.nm_funcionario = funcionario.nm_funcionario;
            alterar.id_cargo = funcionario.id_cargo;
            alterar.id_plano_de_saude = funcionario.id_plano_de_saude;
            alterar.id_plano_odontologico = funcionario.id_plano_odontologico;
            alterar.id_seguro_vida = funcionario.id_seguro_vida;
            alterar.id_vale_alimentacao = funcionario.id_vale_alimentacao;
            alterar.id_vale_refeicao = funcionario.id_vale_refeicao;
            alterar.id_vale_transporte = funcionario.id_vale_transporte;
            alterar.ds_endereco = funcionario.ds_endereco;
            alterar.ds_email = funcionario.ds_email;
            alterar.ds_cpf = funcionario.ds_cpf;
            alterar.ds_telefone = funcionario.ds_telefone;
            alterar.dt_demitido = funcionario.dt_demitido;
            alterar.vl_insalubridade = funcionario.vl_insalubridade;
            alterar.vl_inss = funcionario.vl_inss;
            alterar.vl_periculosidade = funcionario.vl_periculosidade;
            alterar.vl_salario_bruto = funcionario.vl_salario_bruto;
            alterar.vl_salario_familia = funcionario.vl_salario_familia;

            larmscafeEntities.SaveChanges();
        }

        public void RemoverFuncionario(int id)
        {
            Entity.tb_funcionario remover = larmscafeEntities.tb_funcionario.First(x => x.id_funcionario == id);
            larmscafeEntities.tb_funcionario.
                                      Remove(remover);
            larmscafeEntities.SaveChanges();
        }
    }
}
