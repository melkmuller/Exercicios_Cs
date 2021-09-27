using System;

namespace Volume_de_Cubo

    // Programa para calcular o volume de um cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a variável valor para ser a medida do cubo
            double valor = 0;

            //Entrada de dados
            Console.WriteLine("Digite o valor do lado do cubo: ");
            valor = Double.Parse(Console.ReadLine());

            //Processamento e sáida de dados
            Console.WriteLine("O Volume do cubo é de: " + (valor*valor*valor));

        }
    }
}
