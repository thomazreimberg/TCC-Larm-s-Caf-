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
    
    public partial class tb_venda_produto
    {
        public int id_venda_produto { get; set; }
        public int qt_produto { get; set; }
        public decimal vl_total { get; set; }
        public int id_venda { get; set; }
        public int id_produtos { get; set; }
        public bool bt_vendido { get; set; }
    
        public virtual tb_produto tb_produto { get; set; }
        public virtual tb_venda tb_venda { get; set; }
    }
}
