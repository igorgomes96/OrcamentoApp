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
    
    public partial class Variaveis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Variaveis()
        {
            this.Contratacoes = new HashSet<Contratacao>();
            this.Funcionarios = new HashSet<Funcionario>();
            this.Salario = new HashSet<Salario>();
            this.SolicitacaoContratacao = new HashSet<SolicitacaoContratacao>();
            this.SolicitacaoAlteracaoCargo = new HashSet<SolicitacaoAlteracaoCargo>();
            this.SolicitacaoAlteracaoCargo1 = new HashSet<SolicitacaoAlteracaoCargo>();
        }
    
        public int CargaHoraria { get; set; }
        public int EmpresaCod { get; set; }
        public double ParticipacaoLucros { get; set; }
        public double RemuneracaoVariavel { get; set; }
        public Nullable<double> PL { get; set; }
        public Nullable<double> PR { get; set; }
        public int CargoCod { get; set; }
    
        public virtual CargaHoraria CargaHorariaObj { get; set; }
        public virtual Cargo Cargo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contratacao> Contratacoes { get; set; }
        public virtual Empresa Empresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salario> Salario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolicitacaoContratacao> SolicitacaoContratacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolicitacaoAlteracaoCargo> SolicitacaoAlteracaoCargo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolicitacaoAlteracaoCargo> SolicitacaoAlteracaoCargo1 { get; set; }
    }
}
