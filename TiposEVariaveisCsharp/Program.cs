using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEVariaveisCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroInt = 10;

            int maiorNumeroInt = int.MaxValue;
            int menorNumeroInt = int.MinValue;

            long numeroLong = 123123123123123;

            long maiorNumeroLong = long.MaxValue;
            long menorNumeroLong = long.MinValue;

            decimal numeroDecimal = 10.52m;

            double numeroDouble = 12.3;
            double menorNumeroDouble = double.MinValue;

            bool verdadeiro = true;
            bool falso = false;

            var numero = 10;

            string nome = "Bruno Mota";
            char letra = 'B';

            DateTime entradaEmpresa = new DateTime(2021, 1, 1);
            TimeSpan quantoTempoDeEmpresa = DateTime.Now - entradaEmpresa;


            Console.Read();
        }
    }
}
