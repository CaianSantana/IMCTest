using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCTest
{
    public static class IMC
    {
        public static double Divisao(double pNum, double sNum)
        {
            return (Math.Round(pNum / Math.Pow(sNum, 2), 2));
        }
        public static string Classificacao(double rNum)
        {
            if (rNum < 18.5)
            {
                return ("Baixo Peso.");
            }
            else if (rNum <= 24.99)
            {
                return ("Normal.");
            }
            else if (rNum <= 29.99)
            {
                return ("Sobrepeso.");
            }
            else 
            {
                return ("Obesidade.");
            }     
                    
        }
    }
}

