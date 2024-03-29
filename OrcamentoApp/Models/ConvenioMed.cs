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
    
    public partial class ConvenioMed
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConvenioMed()
        {
            this.CargosPlano1 = new HashSet<Cargo>();
            this.CargosPlano2 = new HashSet<Cargo>();
            this.CargosPlano3 = new HashSet<Cargo>();
            this.Contratacao = new HashSet<Contratacao>();
            this.ReajConvenioMed = new HashSet<ReajConvenioMed>();
            this.Funcionario = new HashSet<Funcionario>();
        }
    
        public string Plano { get; set; }
        public double Valor { get; set; }
        public double ValorDependentes { get; set; }
        public int Codigo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cargo> CargosPlano1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cargo> CargosPlano2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cargo> CargosPlano3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contratacao> Contratacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReajConvenioMed> ReajConvenioMed { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }
}
