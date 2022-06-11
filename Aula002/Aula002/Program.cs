using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercícios referente à aula do dia 07/06/2022
             * Nesta aula testamos diferentes formas de conversão de tipo 
             * 
             * Exercício 1: entrada de dado, conversão de tipo, cálculo simples e saída de resultado;
             * 
             * Exercício 2: entrada de dados, estrutura de repetição, conversão de tipo e saída de resultado;
             * 
             * Exercício 3: entradas de tipos diferentes de dados, conversão de tipo, cálculo simples e saídas  de diferentes tipos de dados;
             * 
             * Exercício 4: entrada de dados, conversão de tipo e cálculos simples realizados na saída de resultados;
             * 
             * Exercício 5: entrada de dado e saída com conversão, cálculo e configuração da saída simultaneamente
             * OBS: Os testes aplicando "Math.Round(moedaReal,2)" não funcinaram devidamente.
            */

            // 1) Escreve ano de nascimento e imprime idade.
            Aula002Exerc01();

            // 2) Soma 10 valores
            Aula002Exerc02();

            // 3) Cálculo de salário
            Aula002Exerc03();

            // 4) Converter idade em meses e dias
            Aula002Exerc04();

            // 5) Conversor de moedas
            Aula002Exerc05();

        }
        static void Aula002Exerc01()
        {
            // 1) Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.

            Console.WriteLine("---------- Exercício 1 ----------\n");

            int anoNasc;
            int idade;

            Console.WriteLine("Digite os quatro dígitos do seu ano de nacimento:");
            anoNasc = int.Parse(Console.ReadLine()); // ou anoNasc = Convert.ToInt32(Console.ReadLine());

            idade = 2022 - anoNasc;

            Console.WriteLine("Sua idade é " + idade);
            Console.ReadLine();
        }
        static void Aula002Exerc02()
        {
            // 2) Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números

            Console.WriteLine("---------- Exercício 2 ----------\n");

            int soma = 0, i = 0;

            Console.WriteLine("Digite 10 valores:");
            while (i != 10)
            {
                soma += int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine($"A soma dos valores é {soma}");
            Console.ReadLine();

        }
        static void Aula002Exerc03()
        {
            // 3) Escreva um programa que leia o número de horas trabalhadas e um funcionário,
            // o valor que recebe por hora e calcula o salário desse funcionário.
            // A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

            Console.WriteLine("---------- Exercício 3 ----------\n");

            string nomeFuncionario;
            int horasTrab;
            double salarioHora;
            double salario;

            Console.WriteLine("Nome do Funcionário:");
            nomeFuncionario = Console.ReadLine();

            Console.WriteLine("Horas trabalhadas no mês, pelo funcionáro:");
            horasTrab = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Salário por hora do funcionário:");
            salarioHora = Convert.ToDouble(Console.ReadLine());

            salario = horasTrab * salarioHora;

            Console.WriteLine($"O funcionário {nomeFuncionario} trabalhou {horasTrab} horas e receberá {salario} este mês");
            Console.ReadLine();
        }
        static void Aula002Exerc04()
        {
            // 4) Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.
            //Ano = 365 dias; Mês = 30 dias.

            Console.WriteLine("---------- Exercício 4 ----------\n");

            int idade;

            Console.WriteLine("Digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{idade} anos de idade representa aproximadamente: \n{idade*365/12} meses de vida!\n{idade * 365} dias, de vida!");
            Console.ReadLine();

        }
        static void Aula002Exerc05()
        {
            // 5) Construa um conversor de moedas:
            // REAL = 1; DOLAR = 0,21; EURO = 0,19; LIBRA ESTERLINA = 0,16; DÓLAR CANADENSE 0,16; PESO ARGENTINO = 24,90; PESO CHILENO = 169,36

            Console.WriteLine("---------- Exercício 5 ----------\n");

            double moedaReal;

            Console.WriteLine("Digite um valor em real que deseja converter:");
            moedaReal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\n\tReal: R$ {moedaReal.ToString("0.00")}"); // ou {moedaReal.ToString("N2")}
            Console.WriteLine($"\tDólar: US$ {(moedaReal * 0.21).ToString("0.00")}");//{(moedaReal * 0.21).ToString("N2")}
            Console.OutputEncoding = Encoding.UTF8;//Mostra o simbolo de euro, não está em um lugar elegante, mas está funcional
            Console.WriteLine($"\tEuro: € {(moedaReal * 0.19).ToString("0.00")}");//{(moedaReal * 0.19).ToString("N2")}
            Console.WriteLine($"\tLibras esterlinas: £ {(moedaReal * 0.16).ToString("0.00")}");//{(moedaReal * 0.16).ToString("N2")}
            Console.WriteLine($"\tDólar canadense: C$ {(moedaReal * 0.16).ToString("0.00")}");//{(moedaReal * 0.16).ToString("N2")}
            Console.WriteLine($"\tPeso argentino: $ {(moedaReal * 24.90).ToString("0.00")}");//{(moedaReal * 24.90).ToString("N2")}
            Console.WriteLine($"\tPeso chileno: CLP {(moedaReal * 169.36).ToString("0.00")}");//{(moedaReal * 169.36).ToString("N2")}
            Console.ReadLine();
        }

    }
}
