using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAluguelCarro
    {
        public static double valorDiaria = 95;
        public static double valorQuilometro = 0.35;
        public static int Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
        {
           return (CalculaAluguelCarro.valorDiaria * dias) + ((quilometragemFinal - quilometragemInicial) * CalculaAluguelCarro.valorQuilometro);
        }
    }
}
