//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Larm_s_Café.Database.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_despesa
    {
        public int id_fluxo_caixa { get; set; }
        public string nm_referencia { get; set; }
        public decimal ds_previsto { get; set; }
        public decimal ds_realizado { get; set; }
        public System.DateTime dt_entrada { get; set; }
        public System.DateTime dt_saida { get; set; }
    }
}
