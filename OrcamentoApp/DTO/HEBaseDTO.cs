using OrcamentoApp.Models;
using System;
using System.Collections.Generic;

namespace OrcamentoApp.DTO
{
    
    public partial class HEBaseDTO
    {
        public HEBaseDTO(HEBase h)
        {
            if (h == null) return;
            FuncionarioMatricula = h.FuncionarioMatricula;
            Mes = h.Mes;
            PercentualHoras = h.PercentualHoras;
            QtdaHoras = h.QtdaHoras;
        }
        public string FuncionarioMatricula { get; set; }
        public System.DateTime Mes { get; set; }
        public double PercentualHoras { get; set; }
        public Nullable<int> QtdaHoras { get; set; }
    
    }
}
