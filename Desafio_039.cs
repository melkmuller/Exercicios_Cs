using System;

namespace Desafio_039_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia o ano de nascimento de um jovem e informe, de acordo com a sua idade,
              se ele ainda vai se alistar ao serviço militar, se é a hora exata de se alistar ou se já passou 
              do tempo do alistamento. Seu programa também deverá mostrar o tempo que falta ou que passou do prazo.*/

            Console.WriteLine("Digite o ano do seu nascimento: "); // Solicita o dado ao usuário
            int ano_nascimento = Convert.ToInt32(Console.ReadLine()); // Recebe o dado enquanto transforma em INTEIRO
            int ano_atual = DateTime.Now.Year; // Pega o somente o ANO da data de hoje
            int idade = ano_atual - ano_nascimento;

            if(idade < 18)
            {
                Console.WriteLine("Ainda faltam " + (18 - idade) + " ano(s) para você se alistar");
            }
            else if(idade > 18)
            {
                Console.WriteLine("Você já deveria ter se alistado a " + (idade - 18) + " ano(s) atrás");
            }
            else
            {
                Console.WriteLine("Parabéns Soldado, este ano você deverá se alistar OBRIGATORIAMENTE!");
            }



            




        }
    }
}
