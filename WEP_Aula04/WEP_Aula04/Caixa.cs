using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinhasClasses
{
    public class Caixa // : Object
    {
        public virtual string Mostra()
        {
            return "Mostra da Caixa";
        }
    }

        public class CaixaColorida : Caixa
        {
            public override string Mostra()
            {
                return "Mostra da Caixa Colorida";
            }
        }

        public class CaixaAvancada : CaixaColorida
        {
            public override string Mostra()
            {
                return "Mostra da Caixa Avançada";
            }        
        }
}