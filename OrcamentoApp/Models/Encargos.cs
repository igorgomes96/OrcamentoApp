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
    
    public partial class Encargos
    {
        public double Enc13 { get; set; }
        public double AvisoPrevio { get; set; }
        public double Ferias { get; set; }
        public double FGTS { get; set; }
        public double INSS { get; set; }
        public int EmpresaCod { get; set; }
        public Nullable<float> INCRA { get; set; }
        public Nullable<float> SalEducacao { get; set; }
        public Nullable<float> Sebrae { get; set; }
        public Nullable<float> Senai { get; set; }
        public Nullable<float> SESI { get; set; }
    
        public virtual Empresa Empresa { get; set; }
    }
}
