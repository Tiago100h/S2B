using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinhasClasses.Caixa
{
    public class Caixa
    {
        //Atributos - armazenar caracteristicas, informações...
        public int Altura;
        public int Largura;
        public int Comprimento;

        //Métodos - Capacidade de executar algo... ação...
        public double CalculaVolume()
        {
            return Altura * Comprimento * Largura;
        }
        public double CalculaArea()
        {
            return 2 * Altura * Largura + 2 * Comprimento * Altura + 2 * Altura * Largura;
        }
        public Caixa(int alt = 1, int comp = 1, int larg = 1)
        {
            this.Altura = alt;
            this.Comprimento = comp;
            this.Largura = larg;
        }
    }
}