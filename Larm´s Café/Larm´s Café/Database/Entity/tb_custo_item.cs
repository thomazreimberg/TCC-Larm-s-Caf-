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
    
    public partial class tb_custo_item
    {
        public int id_custo__item { get; set; }
        public string vl_preco_unitario { get; set; }
        public int id_materia_prima { get; set; }
        public int id_custo { get; set; }
    
        public virtual tb_custo tb_custo { get; set; }
        public virtual tb_materia_prima tb_materia_prima { get; set; }
    }
}
