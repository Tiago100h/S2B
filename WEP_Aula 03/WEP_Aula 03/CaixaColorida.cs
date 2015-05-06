using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MinhasClasses.Caixa.Colorida
{
    public class CaixaColorida : Caixa
    {
        public Color Cor;

        public CaixaColorida()
        {
            this.Cor = Color.Black;
        }

        public new double CalculaVolume()
        {
            return base.CalculaVolume() * 1.02;
        }
    }
}