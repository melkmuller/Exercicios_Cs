using System;

namespace Calculo_de_media_aritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria a variável que vai receber o valor das notas somadas
            double soma = 0;

            // Faz o programa rodar três vezes
            for(int i=0; i<3; i++)
            {
                // Solicita a inserção da nota e mostra o número dela (i+1)
                Console.WriteLine("Digite a nota " + (i + 1));
                soma = soma + Double.Parse(Console.ReadLine());

            }

            // Mostra o resultado e faz a conta na mesma linha
            Console.WriteLine("A média é: " + (soma / 3));
        }
    }
}
