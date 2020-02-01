using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larm_s_Café.Modelos
{
    class folhaDePagamentoResultado
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

    }
}
