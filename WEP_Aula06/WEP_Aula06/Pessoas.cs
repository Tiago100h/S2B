using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinhasClasses.Pessoas
{
    public class Pessoas: IComparable, IEquatable<Pessoas>
    {
        public string Nome;
        public int idade;
        public int Idade
        {
            get 
            {
                return idade;
            }
            set
            {
                if (value >= 0 && value <= 120)
                    idade = value;
                else
                    throw new ArgumentException("Valor de idade inválido");
            }
        }
        private double altura;
        public double Altura
        {
            get
            {
                return altura;
            }
            set
            {
                if (value >= 0.30 && value <= 2.20)
                    altura = value;
                else
                    throw new ArgumentException("Valor de altura inválido");
            }
        }

        public int CompareTo(Object outraPessoa)
        {
            if ((outraPessoa as Pessoas).Idade > this.Idade)
                return -1;
            else
                if ((outraPessoa as Pessoas).Idade < this.Idade)
                    return 1;
                else
                    return 0;
        }

        public bool Equals(Pessoas outraPessoa)
        {
            if (outraPessoa.Nome == this.Nome && 
                outraPessoa.Idade == this.Idade)
                return true;
            else
                return false;
        }
    }
}