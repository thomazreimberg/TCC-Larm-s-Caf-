using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Database
{
    class despesasDatabase
    {
        Entity.larmscafeEntities1 larmscafeEntities = new Entity.larmscafeEntities1();

        public void Inserir(Entity.tb_despesa despesa)
        {
            larmscafeEntities.tb_despesa.Add(despesa);
            larmscafeEntities.SaveChanges();
        }


        public List<Entity.tb_despesa> ConsultarDespesa(string referencia, DateTime entrada)
        {
            List<Entity.tb_despesa> despesa = larmscafeEntities.tb_despesa.
                                                                     Where(x => x.nm_referencia.
                                                                  Contains(referencia) && x.dt_entrada.Month == entrada.Month).
                                                                    ToList();

            return despesa;
        }

        public List<Entity.tb_despesa> ConsultarPorReferencia(string referencia)
        {
            List<Entity.tb_despesa> despesa = larmscafeEntities.tb_despesa.
                                                                     Where(x => x.nm_referencia.
                                                                  Contains(referencia)).ToList();
            return despesa;
        }

        public void AlterarDespesa (Entity.tb_despesa despesa)//Pegar o ID do DataGridView
        {
            Entity.tb_despesa alterar = larmscafeEntities.tb_despesa.
                                                               First(x => x.id_fluxo_caixa == despesa.id_fluxo_caixa);

            alterar.nm_referencia = despesa.nm_referencia;
            alterar.dt_saida = despesa.dt_saida;
            alterar.dt_entrada = despesa.dt_entrada;
            alterar.ds_realizado = despesa.ds_realizado;
            alterar.ds_previsto = despesa.ds_previsto;

            larmscafeEntities.SaveChanges();    
        }

        public void RemoverDespesa (int id)
        {
            Entity.tb_despesa despesa = larmscafeEntities.tb_despesa.
                                                               First(x => x.id_fluxo_caixa == id);

            larmscafeEntities.tb_despesa.Remove(despesa);

            larmscafeEntities.SaveChanges();
        }

        public List<Entity.tb_despesa> ListarTodos()
        {
            return larmscafeEntities.tb_despesa.ToList();
        }

    }
}
