using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula003
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Exercício referente à aula dodia 08/06/2022
             * Uso de operadores de comparação, lógicos e estruturas condicionais
             * 
             * Ecercício 1: estrutura de repetição porque com estrutura lógica ficaria muito longo;
             * 
             * Exercício 2: estrutura lógica com operadores de comparação;
             * 
             * Exercício 3: operador ternário;
             * 
             * Exercício 4: estrutura condicional encadeada;
             * 
             * Exercício 5: estrutura condicional encadeada com apresentação de dados e cálculo simultâneos.
             * 
            */

            // 1) Calcular número de notas de determinado valor
            //Aula003Exerc01();

            // 2) Maior entre três valores 
            //Aula003Exerc02();

            // 3) Média de três notas de aluno
            Aula003Exerc03();

            // 4 )Média de três notas dp aluno com classificação
            //Aula003Exerc04();

            // 5) Reajuste de salário
            //Aula003Exerc05();
        }
        static void Aula003Exerc01()
        {
            //Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. 
            //A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. 
            //As notas consideradas são de 100, 50, 20, 10, 5, 2.

            Console.WriteLine("---------- Exercício 1 ---------\n");
            Console.WriteLine("Digite um valor: ");
            float valorf = float.Parse(Console.ReadLine());
            int cem = 0, cinquenta = 0, vinte = 0, dez = 0, cinco = 0, dois = 0;
            while (valorf >= 100.00)
            {
                valorf = valorf - 100;
                cem++;
            }
            while (valorf < 100 && valorf >= 50)
            {
                valorf = valorf - 50;
                cinquenta++;
            }
            while (valorf < 50 && valorf >= 20)
            {
                valorf = valorf - 20;
                vinte++;
            }
            while (valorf < 20 && valorf >= 10)
            {
                valorf = valorf - 10;
                dez++;
            }
            while (valorf < 10 && valorf >= 5)
            {
                valorf = valorf - 5;
                cinco++;
            }
            while (valorf < 5 && valorf >= 2)
            {
                valorf = valorf - 2;
                dois++;
            }

            Console.WriteLine($"O valor será decomposto do seguinte modo:\n\n" +
                $"{cem} notas de R$ 100,00\n" +
                $"{cinquenta} notas de R$ 50,00\n" +
                $"{vinte} notas de R$ 20,00\n" +
                $"{dez} notas de R$ 10,00\n" +
                $"{cinco} notas de R$ 5,00\n" +
                $"{dois} notas de R$ 2,00\n" +
                $"E sobrará {valorf.ToString("0.00")} em moedas");
            Console.ReadLine();
        }
        static void Aula003Exerc02()
        {
            //Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “x é o maior”.
            Console.WriteLine("---------- Exercício 2 ---------\n");

            double maior;

            Console.WriteLine("Digite o primeiro valor:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor valor:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num1 >= num2)
            {
                maior = num1;
            }
            else
            {
                maior = num2;
            }
            Console.WriteLine("Digite o terceiro valor valor:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            if (maior >= num3)
            {
                Console.WriteLine($"{maior} é o maior número!");
            }
            else
            {
                Console.WriteLine($"{num3} é o maior número");
            }

            Console.ReadLine();
        }
        static void Aula003Exerc03()
        {
            //Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
            //Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
            //Imprima se o aluno foi aprovado ou reprovado considerando a média 7.
            Console.WriteLine("---------- Exercício 3 ---------\n");

            Console.WriteLine(" Primera nota: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Tercceira nota: ");
            float nota3 = float.Parse(Console.ReadLine());
            string media = (((nota1 + nota2 + nota3) / 3) >= 7) ? "Aluno aprovado!" : "Aluno reprovado!";
            Console.WriteLine(media);
            /*if (((nota1 + nota2 + nota3)/3) >= 7)
            {
                Console.WriteLine(" Aluno aprovado!");
            }
            else
            {
                Console.WriteLine(" Aluno reprovado!");
            }*/
            Console.ReadLine();
        }
        static void Aula003Exerc04()
        {
            //Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
            // Se a nota for menor que 6.0, deve exibir a nota F.
            // Se a nota for de 6.0 até 7.0, deve exibir a nota D.
            // Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
            // Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
            // Se a nota for entre 9.0 e 10.0, deve exibir um belo de um A.
            Console.WriteLine("---------- Exercício 4 ---------\n");

            Console.WriteLine(" Primera nota: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine(" Tercceira nota: ");
            float nota3 = float.Parse(Console.ReadLine());
            float mediaf = (nota1 + nota2 + nota3) / 3;
            if (mediaf < 6)
            {
                Console.WriteLine(" Nota F: aluno reprovado!");
            }
            else if (mediaf >=6 && mediaf <7)
            {
                Console.WriteLine(" Nota D: aluno reprovado!");
            }
            else if (mediaf >= 7 && mediaf < 8)
            {
                Console.WriteLine(" Nota C: aluno aprovado!");
            }
            else if (mediaf >= 8 && mediaf < 9)
            {
                Console.WriteLine(" Nota B: aluno aprovado!");
            }
            else
            {
                Console.WriteLine(" Nota A: aluno aprovado!");
            }

            Console.ReadLine();
        }
        static void Aula003Exerc05()
        {
            // A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
            // Salário de 0 até 400.00 ganha 15 %
            // Salário de 400.01  até 800.00 ganha 12 %
            // Salário de 800.01 até 1200.00 ganha 10 %
            // Salário de 1200.01 até 2000.00 ganha 7 %
            // Acima de 2000.00 ganha 4 %
            // Leia o salário do funcionário, calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado em percentual.
            Console.WriteLine("---------- Exercício 5 ---------\n");

            Console.WriteLine("Nome do funncionário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Salário atual: ");
            double salarioAtual = Convert.ToDouble(Console.ReadLine());
            if (salarioAtual <=400.00)
            {
                Console.WriteLine($" O salário atual do {nome} é R$ {salarioAtual}, " +
                    $"receberá 15% de reajuste e seu salário passará a ser R$ {(salarioAtual + salarioAtual* 0.15).ToString("0.00")} ");
            }
            else if (salarioAtual > 400.00 && salarioAtual<=800.00)
            {
                Console.WriteLine($" O salário atual do {nome} é R$ {salarioAtual}, " +
                    $"receberá 12% de reajuste e seu salário passará a ser R$ {(salarioAtual + salarioAtual * 0.12).ToString("0.00")} ");
            }
            else if (salarioAtual > 800.00 && salarioAtual <= 1200.00)
            {
                Console.WriteLine($" O salário atual do {nome} é R$ {salarioAtual}, " +
                    $"receberá 10% de reajuste e seu salário passará a ser R$ {(salarioAtual + salarioAtual * 0.10).ToString("0.00")} ");
            }
            else if (salarioAtual > 1200.00 && salarioAtual <= 2000.00)
            {
                Console.WriteLine($" O salário atual do {nome} é R$ {salarioAtual}, " +
                    $"receberá 7% de reajuste e seu salário passará a ser R$ {(salarioAtual + salarioAtual * 0.07).ToString("0.00")} ");
            }
            else
            {
                Console.WriteLine($" O salário atual do {nome} é R$ {salarioAtual}, " +
                   $"receberá 4% de reajuste e seu salário passará a ser R$ {(salarioAtual + salarioAtual * 0.04).ToString("0.00")} ");
            }

            Console.ReadLine();
        }


    }
}
