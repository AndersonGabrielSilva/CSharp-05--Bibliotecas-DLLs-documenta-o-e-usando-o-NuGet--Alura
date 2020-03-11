using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // AutenticacaoHelper teste;//É visivel somente dentro da biblioteca (projeto), quando ultiliza o modificador de acesso internal

            ContaCorrente conta = new ContaCorrente(1612,58974);

            new ContaCorrente(1612, 45789);
            Console.WriteLine(conta.Numero);
            Console.ReadLine();

        }
    }
}
