//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WAP_Aula07parte3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int cd_Cliente { get; set; }
        public Nullable<int> cd_Profissao { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public Nullable<decimal> LimiteCompras { get; set; }
        public Nullable<decimal> LimiteCredito { get; set; }
        public Nullable<System.DateTime> DtNascimento { get; set; }
    
        public virtual Profisso Profisso { get; set; }
    }
}
