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
    
    public partial class HEContratacao
    {
        public int ContratacaoCod { get; set; }
        public int PercentualHoras { get; set; }
        public int QtdaHoras { get; set; }
        public int CodMesOrcamento { get; set; }
    
        public virtual Contratacao Contratacao { get; set; }
        public virtual MesOrcamento MesOrcamento { get; set; }
    }
}
