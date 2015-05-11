using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinhasClasses.Eletrodomesticos
{
    public interface ILigadoDesligado
    {
        void Ligar();
        void Desligar();
        string EstadoFuncionamento();
    }

    public class Eletro
    {
        public string Nome;
        public string Fabricante;
    }

    public class Liquidificador : Eletro, ILigadoDesligado
    {
        public int Velocidade;
        public void Ligar()
        {
            Velocidade = 50;
        }
        public void Desligar()
        {
            Velocidade = 0;
        }
        public string EstadoFuncionamento()
        {
            if (Velocidade == 50)
                return "O Liquidificador está funcionando";
            else
                return "O Liquidificador não está funcionando";
        }
    }

    public class ArCondicionado : Eletro, ILigadoDesligado
    {
        public int BTU;
        public bool Gelando;

        public void Ligar()
        {
            Gelando = true;
        }
        public void Desligar()
        {
            Gelando = false;
        }
        public string EstadoFuncionamento()
        {
            if (Gelando)            
                return "O ar condicionado está gelando";
            else
                return "O ar condicionado não está gelando";            
        }
    }
}