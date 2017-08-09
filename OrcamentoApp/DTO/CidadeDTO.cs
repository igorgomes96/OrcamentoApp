using OrcamentoApp.Models;
using System;
using System.Collections.Generic;

namespace OrcamentoApp.DTO
{
    
    public partial class CidadeDTO
    {
        public CidadeDTO(Cidade c)
        {
            if (c == null) return;
            NomeCidade = c.NomeCidade;
            VT = c.VT;
            EhFilial = c.EhFilial;
        }
    
        public string NomeCidade { get; set; }
        public double VT { get; set; }
        public bool EhFilial { get; set; }
    
    }
}
