//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrcamentoApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventoFolha
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventoFolha()
        {
            this.CalculosEventosBase = new HashSet<CalculoEventoBase>();
            this.CalculosEventosContratacoes = new HashSet<CalculoEventoContratacao>();
            this.ValoresAbertosBase = new HashSet<ValoresAbertosBase>();
        }
    
        public string Codigo { get; set; }
        public string NomeEvento { get; set; }
        public string Descricao { get; set; }
        public string CodConta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalculoEventoBase> CalculosEventosBase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalculoEventoContratacao> CalculosEventosContratacoes { get; set; }
        public virtual ContaContabil ContaContabil { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValoresAbertosBase> ValoresAbertosBase { get; set; }
    }
}
