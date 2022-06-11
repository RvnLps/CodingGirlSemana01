using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício referente à aula do dia 06/06/2022.
             * 
             * Nesses exercícios explorei formas diferentes de escrever mensagens no console:
             * 
             * No exercício 1 apliquei interpolaçao de caracteres com variáveis fixas;
             * 
             * No exercício 2 apliquei escrita linha por linha de cadeias de caracteres;
             * 
             * No exercício 3 apliquei o comando @, literais de cadeia de caracteres verbatim, 
             * que permite escrever textos longos de forma vertical, mas limita o uso de outros comando com barra, como \n
             * OBS: Existe os literais de cadeia de caracteres brutos, aplicando três ou mais asterísticos no 
             * início e fim do testo longo, mas não consegui aplicar;
             * 
             * No exercício 4 apliquei interplolação por soma de cadeias de caracteres.
            */

            //1) Escreve seu nome completo, seu endereço, o CEP e telefone em linhas separadas.
            Aula001Exerc01();

            //2) Mulher famosa na história da tecnologia.
            Aula001Exerc02();

            //3) Letra de música que você gosta, o compositor e o gênero musical em linhas separadas.
            Aula001Exerc03();

            //4) Mensagem de incentiva para mulheres entrarem na área de tecnologia.
            Aula001Exerc04();


        }

        static void Aula001Exerc01()
        {
            //1)Elabore um programa que escreva seu nome completo, seu endereço, o CEP e telefone em linhas separadas.
            Console.WriteLine("---------- Exercício 01 ----------\n");

            string nome = "Fulana Ciclana Beltrana";
            string endereco = "Rua Sem Fim, 1000, Bairro do Fim do Mundo, Lugar Nenhum - SP";
            string cep = "12345-678";
            string telefone = "(xx) 91234-5678";

            Console.WriteLine($"Nome: {nome}\nEndereço: {endereco}\nCEP: {cep}\nTelefone: {telefone}\n\n");
            Console.ReadLine();
        }
        static void Aula001Exerc02()
        {
            //2)Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome,
            //sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.
            Console.WriteLine("---------- Exercício 02 ----------\n");

            Console.WriteLine("\tUma mulher que revolucionou a tecnologia!\n");
            Console.WriteLine("\tHedy Lamarr\n");
            Console.WriteLine("\tA internet Wi-Fi e a conexão Bluetooth, duas das tecnologias mais importantes nos dias de hoje, " +
                "só saíram do papel graças a uma mulher judia que se refugiou nos Estados Unidos. Hedy Lamarr, que morreu em 2000 " +
                "aos 85 anos, além de ser uma renomada atriz do começo do século passado, era também inventora. Ela desenvolveu o " +
                "sistema de salto em frequência, planejado originalmente para guiar torpedos submarinos usando sinais de rádio.\n\n");
            Console.ReadLine();
        }
        static void Aula001Exerc03()
        {
            //3)Elabore um programa que mostre na tela uma letra de música que você gosta, o compositor e o gênero musical em linhas separadas.
            Console.WriteLine("---------- Exercício 03 ----------\n");

            Console.WriteLine(@"Minha música preferida: a tradução de ""Friends for life"", canção composta por Andrew Lloyd Webber e letra de Donald Blackstone, interpretada por Sarah Brightman e José Carreira na cerimônia de encerramento dos Jogos Olímpicos de Verão de 1992. 

            ----- Amigos para sempre (Friend for life) -----
            
            Compositores originais: Andrew Lloyd Webber e Donald Blackstone
            Gênero: Clássica

            Eu não tenho nada pra dizer
            Você parece no momento até saber
            O quanto eu estou sofrendo

            Vem, veja através dos olhos meus
            A emoção que sinto em estar aqui
            Sentir seu coração me amando

            Amigos para sempre é o que nós iremos ser
            Na primavera ou em qualquer das estações
            Nas horas tristes, nos momentos de prazer
            Amigos para sempre

            Amigos para sempre é o que nós iremos ser
            Na primavera ou em qualquer das estações
            Nas horas tristes, nos momentos de prazer
            Amigos para sempre

            Você pode estar longe, muito longe sim
            Mas por te amar, sinto você perto de mim
            E o meu coração contente

            Não nos perderemos, não te esquecerei
            Você é a minha vida, tudo que sonhei
            E quis para mim um dia

            Amigos para sempre é o que nós iremos ser
            Na primavera ou em qualquer das estações
            Nas horas tristes, nos momentos de prazer
            Amigos para sempre");
            Console.ReadLine();
        }
        static void Aula001Exerc04()
        {
            //4)Elabore um programa que exibe uma mensagem que incentive outras mulheres a entrar na tecnologia.
            Console.WriteLine("---------- Exercício 04 ----------\n");

            Console.WriteLine("Lugar de mulher é onde ela quiser!!!" + "\n" + "Inclusive na tecnologia!" + "\n" + 
            "Para quem não sabe, a primeira programadora do mundo foi uma mulher: A Condessa de Lovelace!!" +
            "Ela foi reconhecida como a primeira programadora da história por ter escrito o primeiro algoritmo a ser processado por uma máquina " +
            "– a máquina analítica de Charles Babbage – no século XIX.");
            Console.ReadLine();
        }
    }
}
