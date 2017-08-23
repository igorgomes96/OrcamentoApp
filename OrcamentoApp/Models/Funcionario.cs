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
    
    public partial class Funcionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcionario()
        {
            this.Afastamento = new HashSet<Afastamento>();
            this.CalculoEventoBase = new HashSet<CalculoEventoBase>();
            this.HEBase = new HashSet<HEBase>();
            this.OutrosBase = new HashSet<OutrosBase>();
            this.SolicitacaoAlteracaoCargo = new HashSet<SolicitacaoAlteracaoCargo>();
            this.SolicitacaoAlteracaoSalario = new HashSet<SolicitacaoAlteracaoSalario>();
            this.SolicitacaoDesligamento = new HashSet<SolicitacaoDesligamento>();
            this.Transferencia = new HashSet<Transferencia>();
            this.ValoresAbertosBase = new HashSet<ValoresAbertosBase>();
        }
    
        public string Matricula { get; set; }
        public double AuxCreche { get; set; }
        public double AuxEducacao { get; set; }
        public double AuxFilhoExc { get; set; }
        public double PrevidenciaPrivada { get; set; }
        public double AuxSeguro { get; set; }
        public int AvosFerias { get; set; }
        public System.DateTime DataAdmissao { get; set; }
        public double Gratificacoes { get; set; }
        public Nullable<System.DateTime> MesDesligamento { get; set; }
        public Nullable<System.DateTime> MesFerias { get; set; }
        public string Nome { get; set; }
        public bool Periculosidade { get; set; }
        public int QtdaDependentes { get; set; }
        public int QtdaDiasVendidosFerias { get; set; }
        public Nullable<double> RemProdutividade { get; set; }
        public double Salario { get; set; }
        public string TipoAviso { get; set; }
        public double VT { get; set; }
        public string CentroCustoCod { get; set; }
        public string CidadeNome { get; set; }
        public int EmpresaCod { get; set; }
        public int CargaHoraria { get; set; }
        public string Situacao { get; set; }
        public int CargoCod { get; set; }
        public int SindicatoCod { get; set; }
        public Nullable<int> ConvenioMedCod { get; set; }
        public string Nome2 { get; set; }
        public float ValorConvMedico { get; set; }
        public float ValorConvOdontologico { get; set; }
        public bool AdCondutor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Afastamento> Afastamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalculoEventoBase> CalculoEventoBase { get; set; }
        public virtual CentroCusto CentroCusto { get; set; }
        public virtual ConvenioMed ConvenioMed { get; set; }
        public virtual Filial Filial { get; set; }
        public virtual Sindicato Sindicato { get; set; }
        public virtual Variaveis Variaveis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HEBase> HEBase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutrosBase> OutrosBase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolicitacaoAlteracaoCargo> SolicitacaoAlteracaoCargo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolicitacaoAlteracaoSalario> SolicitacaoAlteracaoSalario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolicitacaoDesligamento> SolicitacaoDesligamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transferencia> Transferencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValoresAbertosBase> ValoresAbertosBase { get; set; }
    }
}
