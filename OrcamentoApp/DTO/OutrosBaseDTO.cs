using OrcamentoApp.Models;
using System;
using System.Collections.Generic;

namespace OrcamentoApp.DTO
{
    
    public partial class OutrosBaseDTO
    {
        public OutrosBaseDTO(OutrosBase o)
        {
            if (o == null) return;
            FuncionarioMatricula = o.FuncionarioMatricula;
            Mes = o.Mes;
            Outros = o.Outros;
            RemProdutividade = o.RemProdutividade;
        }
        public string FuncionarioMatricula { get; set; }
        public System.DateTime Mes { get; set; }
        public double Outros { get; set; }
        public double RemProdutividade { get; set; }
    }
}
