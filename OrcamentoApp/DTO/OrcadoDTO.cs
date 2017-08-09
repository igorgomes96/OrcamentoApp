using OrcamentoApp.Models;
using System;
using System.Collections.Generic;

namespace OrcamentoApp.DTO
{
    
    public partial class OrcadoDTO
    {

        public OrcadoDTO (Orcado o)
        {
            if (o == null) return;
            CentroCustoCod = o.CentroCustoCod;
            ContaContabilCod = o.ContaContabilCod;
            Mes = o.Mes;
            Valor = o.Valor;
        }

        public string CentroCustoCod { get; set; }
        public string ContaContabilCod { get; set; }
        public System.DateTime Mes { get; set; }
        public double Valor { get; set; }

    }
}
