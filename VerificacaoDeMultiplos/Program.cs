//Problema "multiplos" (adaptado de URI 1044)
//Fazer um programa para ler dois números inteiros, e dizer se um número é múltiplo do outro. Os
//números podem ser digitados em qualquer ordem. 

namespace VerificacaoDeMultiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Digite dois numeros inteiros: ");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            
            if (numero1 == 0 || numero2 == 0)
            {
                return;
            }

            if (numero1 % numero2 == 0 || numero2 % numero1 == 0  )
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
