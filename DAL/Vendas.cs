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
    
    public partial class Vendas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendas()
        {
            this.ItensVendas = new HashSet<ItensVendas>();
        }
    
        public int Id { get; set; }
        public int Vendedor { get; set; }
        public Nullable<int> Cliente { get; set; }
        public System.DateTime DataVenda { get; set; }
        public string Pagamento { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItensVendas> ItensVendas { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}