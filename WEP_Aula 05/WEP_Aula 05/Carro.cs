using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEP_Aula_05
{
    public enum Marcas {Fiat, VW, GM, Ford};

    sealed public class Carro
    {
        public string Nome;
        public Marcas Marca;
        private int velocidade;

        public int getVelocidade()
        {
            return velocidade;
        }
        public void setVelocidade(int vel)
        {
            if (vel >= 0 && vel <= 200)
                velocidade = vel;
        }

        public string DadosCarro()
        {
            return string.Format("O carro {0} da {1} está a {2} Km/h", Nome, Marca, getVelocidade());
        }
    }

    sealed public class CarroAvancado
    {
        public string Nome;
        public Marcas Marca;
        private int velocidade;
        public int Velocidade
        {
            get
            {
                return velocidade;
            }
            set
            {
                if (value >= 0 && value <= 150)
                    velocidade = value;
                else
                    throw new System.ArgumentException("Não é possível indicar velocidades menores que zero e maiores que 150!");
            }
        }

        private int consumo;
        public int Consumo
        {
            get
            {
                if (velocidade == 0)
                    return 30;
                else
                    if (Enumerable.Range(1, 40).Contains(velocidade))
                        return 20;
                    else
                        if (Enumerable.Range(41, 20).Contains(velocidade))
                            return 10;
                        else
                            if (Enumerable.Range(61, 40).Contains(velocidade))
                                return 12;
                            else
                                if (Enumerable.Range(101, 50).Contains(velocidade))
                                    return 8;
                                else
                                    return 0;
            }
        }

        public string DadosCarroAvancado()
        {
            return string.Format("O carro {0} da {1} está a {2} Km/h e seu consumo é {3} Km/L", Nome, Marca, Velocidade, Consumo);
        }

    }
}