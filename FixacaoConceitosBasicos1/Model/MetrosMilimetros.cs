using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class MetrosMilimetros
    {
        public static double Converter()
        {
            double metros = 1;
            double milimetros = metros * 1000;
            Assert.AreEqual(MetrosMilimetros.Converter(metros), milimetros);
        }
    }
}
