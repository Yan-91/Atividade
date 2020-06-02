using System;

namespace Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
           CartaoCredito visa = new CartaoCredito();
           visa.limite = 3000f;

           Console.WriteLine("Deseja aumentar seu limite? Quanto de acréscimo?");
           float acrescimo = float.Parse( Console.ReadLine());
           
           visa.AumentarLimite(acrescimo);
           Console.WriteLine("Novo limite: R$ "+visa.limite);

           System.Console.WriteLine("digite a data do pagamento");
           visa.data= DateTime.Parse(Console.ReadLine() );
           System.Console.WriteLine("Data: " + visa.data);
        }
    }
}
