//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItensVendas
    {
        public int Id { get; set; }
        public int Venda { get; set; }
        public int Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal { get; set; }
    
        public virtual Vendas Vendas { get; set; }
        public virtual Produtos Produtos { get; set; }
    }
}
