using System;
using static System.Console;

namespace Desafio_041_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /* A Confederação Nacional de Natação precisa de um programa que leia o ano de nascimento de um atleta e mostre sua categoria, de acordo com a idade:
             – Até 9 anos: MIRIM
             – Até 14 anos: INFANTIL
             – Até 19 anos: JÚNIOR
             – Até 25 anos: SÊNIOR
             – Acima de 25 anos: MASTER */

            WriteLine("Digite o ano de nascimento do atleta: "); // Pede para o usuário digitar o dado
            int ano_nascimento = Convert.ToInt32(ReadLine()); // Recebe o dado e converte para INTEIRO na mesma linha
            int ano_atual = DateTime.Now.Year; // Pega o ano atual da DATA
            WriteLine(""); // Pula uma linha

            if((ano_atual - ano_nascimento) > 0 && (ano_atual - ano_nascimento) <= 9)
            {
                WriteLine("O Atleta é da categoria MIRIM");
            }
            else if ((ano_atual - ano_nascimento) > 9 && (ano_atual - ano_nascimento) <= 14)
            {
                WriteLine("O Atleta é da categoria INFANTIL");
            }
            else if ((ano_atual - ano_nascimento) > 14 && (ano_atual - ano_nascimento) <= 19)
            {
                WriteLine("O Atleta é da categoria JÚNIOR");
            }
            else if ((ano_atual - ano_nascimento) > 19 && (ano_atual - ano_nascimento) <= 25)
            {
                WriteLine("O Atleta é da categoria SÊNIOR");
            }
            else
            {
                WriteLine("O Atleta é da categoria MASTER");
            }

        }
    }
}
