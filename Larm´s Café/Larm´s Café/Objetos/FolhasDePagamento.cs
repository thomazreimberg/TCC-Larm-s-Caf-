using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Objetos
{
    class FolhasDePagamento
    {
        public decimal SalarioLiquido { get; set; }
        public decimal VT { get; set; }
        public decimal TotalProventos { get; set; }
        public decimal TotalDescontos { get; set; }
        public decimal HoraExtra { get; set; }
        public decimal DSR { get; set; }
        public decimal INSS { get; set; }
        public decimal FGTS { get; set; }
        public decimal Faltas { get; set; }
        public decimal Insalubridade { get; set; }
        public decimal SalarioBase { get; set; }



        public void GerarFolha(Database.Entity.tb_fopag folha, decimal horaExtra,  int qtFaltas, int passagesVezes)
        {

            TotalProventos = CalcularProventos(folha.tb_funcionario.vl_salario_bruto, horaExtra, folha);

            INSS = CalcularINSS(folha.tb_funcionario.vl_salario_bruto, horaExtra);

            FGTS = CalcularFGTS(folha.tb_funcionario.vl_salario_bruto, horaExtra);

            VT = CalcularVT(folha.tb_funcionario.vl_salario_bruto, passagesVezes);

            Faltas = CalcularFaltas(qtFaltas, folha.tb_funcionario.vl_salario_bruto);

            Insalubridade = CalcularInsalubridade(1039, CalcularSalarioBase(folha.tb_funcionario.vl_salario_bruto, horaExtra));

            SalarioBase = CalcularSalarioBase(folha.tb_funcionario.vl_salario_bruto, horaExtra);

            HoraExtra = CalcularHoraExtra50(folha.tb_funcionario.vl_salario_bruto, horaExtra);

            DSR = CalcularDSR(HoraExtra);

            TotalDescontos = VT + INSS + folha.tb_funcionario.tb_vale_refeicao.vl_vale_refeicao + folha.tb_funcionario.tb_vale_alimentacao.vl_vale_alimentacao +
                folha.tb_funcionario.tb_plano_de_saude.vl_plano + folha.tb_funcionario.tb_plano_odontologico.vl_plano + folha.tb_funcionario.tb_seguro_vida.vl_plano +
                Faltas;

            SalarioLiquido = TotalProventos - TotalDescontos;

        }

        private decimal CalcularProventos(decimal salario, decimal horaExtra, Database.Entity.tb_fopag folha)
        {
            decimal horaExtraTotal = CalcularHoraExtra50(salario, horaExtra);
            decimal dsr = CalcularDSR(horaExtraTotal);
            decimal salarioFamilia = folha.vl_salario_familia;
            decimal insalubridade = CalcularInsalubridade(980.00m, horaExtraTotal+dsr+salario); // Alterar O salário mímimo
            decimal proventos = horaExtraTotal + salario + dsr + salarioFamilia + insalubridade;
            return proventos;
        }

        private decimal CalcularHoraExtra50(decimal salario, decimal horaExtra)//Provento
        {
            decimal horaExtraValor = salario / 220;
            decimal horaExtraTrabalhada = (horaExtraValor * 0.50m) + horaExtraValor;
            decimal total = horaExtraTrabalhada * horaExtra;
            return total;
        }

        private decimal CalcularHoraExtra100(decimal salario, decimal horaExtra)//Provento
        {
            decimal horaExtraValor = salario / 220;
            decimal horaExtraTrabalhada = (horaExtraValor * 1.00m) + horaExtraValor;
            decimal total = horaExtraTrabalhada * horaExtra;
            return total;
        }

        private decimal CalcularDSR (decimal horaExtraTotal)//Provento
        {
            decimal dsr = (horaExtraTotal / 26) * 4;
            return dsr;
        }

        //Desconto
        private decimal CalcularINSS (decimal salario, decimal horaExtra)
        {
            Database.Entity.tb_inss insstaxa = new Database.Entity.tb_inss();
            
            decimal baseInss = CalcularSalarioBase(salario, horaExtra);
            decimal inss = 0;
            if(salario <= 1751.81m)//Vai vir de consulta
            {
                inss = baseInss * 0.08m;
            }
            
            else if(salario >= 0 && salario < insstaxa.vl_salario_inicial)
            {
                inss = baseInss * 0.09m;
            }

            else if(salario >= 1751.82m && salario < 2919.72m)
            {
                inss = baseInss * 0.11m;
            }
            
            else
            {
                inss = baseInss * 0.15m;
            }

            return inss;
        }

        private decimal CalcularFGTS (decimal salario, decimal horaExtra)
        {
            decimal baseFGTS = CalcularSalarioBase(salario, horaExtra); 
            decimal FGTS = baseFGTS * 0.08m;
            return FGTS;
        }

        private decimal CalcularVT (decimal salario, int passagesVezes)
        {
            Database.taxaVTDatabase taxaVTDatabase = new Database.taxaVTDatabase();
            Database.Entity.tb_taxa_vt taxaVT = taxaVTDatabase.ConsultarTaxa();


            decimal vtBase = salario * taxaVT.vl_taxa;
            decimal passagemTotal = (passagesVezes * 4.20m) * 26;
            decimal vt;

            if(vtBase < passagemTotal)
            {
                vt = vtBase;
            }
            else
            {
                vt = passagemTotal;
            }

            return vt;
        }

        private decimal CalcularFaltas(int qtFaltas, decimal salario)
        {
            decimal valorFalta = salario / 30;
            decimal totalFaltas = valorFalta * qtFaltas;
            return totalFaltas;
        }

        private decimal CalcularInsalubridade(decimal salarioMinimo, decimal salarioBase)
        {
            decimal insalubridade = (salarioMinimo * 0.10m) + salarioBase;
            return insalubridade;
        }

        private decimal CalcularSalarioBase(decimal salario, decimal horaExtra)
        {
            decimal horaExtraTotal = CalcularHoraExtra50(salario, horaExtra);
            decimal dsr = CalcularDSR(horaExtraTotal);
            decimal salarioBase = salario + horaExtraTotal + dsr;
            return salarioBase;
        }
    }
}
