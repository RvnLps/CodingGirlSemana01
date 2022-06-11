using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício referente à aula do dia 09/06/2022
             * Vetore, matrizes e estruturas de repetição
             * 
             * Exercício 1: vetor, laço "for" para entrada de dados e tratamento de dados;
             * 
             * Exercício 2: vetor, laço "for" para tratar dados, e "if" para tratamentos de dados;
             * 
             * Exercício 3: matriz bidimensional, uso de laços "for", "if" e "foreach", e lógica de ordenação;
             * 
             * Exercício 4: vetor, uso de "do/while", "if" e "if/else";
             * 
             * Exercício 5: matriz tridimensional, laços de repetição complexos, operadores de condições e lógicos
             * 
             * 
             */

            // 1) Vetor com 10 valores de entrada e apresentação de dois vetores, um com os dados de entrada e outro com seus multiplos de 5
            Aula004Exerc01();

            // 2) Vetor com 10 dados de entrada, e dois vetores de saída, um com números pares e outro com números ímpares
            Aula004Exerc02();

            // 3) Ordenar 5 palavras por ordem de tamanho
           Aula004Exerc03();

            //4) Jogo Jokenpô
            Aula004Exerc04();

            //5) Jogo da Velha
            //OBS: esta resolução não contém tratamento parao caso de um dos jogadores escolherem uma opção já preenchida pelo outro jogador,
            //no entanto, o jogo ignora a escolha repetida e continua;
            Aula004Exerc05();
        }

        static void Aula004Exerc01()
        {
            // Crie um programa que solicite a entrada de 10 números pelo usuário, armazenando - os em um vetor,
            // e então monte outro vetor com os valores do primeiro multiplicados por 5.
            Console.WriteLine("---------- Exercício 1 ----------\n");
            int[] vetor = new int[10];
            int[] vetor5 = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.Write($"Digite valor da posição {i} do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
                vetor5[i] = vetor[i] * 5;
            }
            Console.WriteLine($"Original\tMultiplicado ");
            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"\t{vetor[i]}\t\t{vetor5[i]}");
            }
            Console.ReadLine();
        }
        static void Aula004Exerc02()
        {
            //Crie um programa que armazene 10 números digitados pelo usuário em dois vetores:
            //um somente para números pares, e outro somente para números ímpares.
            //Após, exiba os valores dos dois vetores na tela, um vetor em cada linha.
            Console.WriteLine("---------- Exercício 2 ----------\n");
            int[] vetorE = new int[10];
            int[] vetorP = new int[10];
            int[] vetorI = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.Write($"Digite valor da posição {i} do vetor: ");
                vetorE[i] = int.Parse(Console.ReadLine());
                if (vetorE[i] %2  == 0)
                {
                    vetorP[i] = vetorE[i];
                }
                else
                {
                    vetorI[i] = vetorE[i];
                }
            }
            Console.Write($"\nVelores pares: ");
            for (i = 0; i < 10; i++)
            {
                if (vetorP[i] != 0)
                {
                    Console.Write($"{vetorP[i]}, ");
                }                
            }
            Console.Write($"\nVelores ímpares:");
            for (i = 0; i < 10; i++)
            {
                if (vetorI[i] != 0)
                {
                    Console.Write($"{vetorI[i]}, ");
                }
            }
            Console.ReadLine();
        }
        static void Aula004Exerc03()
        {
            //Crie um programa que lê 5 palavras e as ordena em um vetor de strings pelo seu tamanho.
            //Se o tamanho das strings for igual, deve - se manter a ordem inserida pelo usuário.
            Console.WriteLine("---------- Exercício 3 ----------\n");
            string[] palavras = new string[5];
            int[] tamanho = new int[5];
            int i, j, aux;
            string auxiliar;

            for (i = 0; i < 5; i++)
            {
                Console.Write($"Digite uma palavra: ");
                palavras[i] = Console.ReadLine();
                tamanho[i] = palavras[i].Length;
                //tamanho[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 4; i++)
            {
                for (j = i+1; j < 5; j++)
                {
                    if (tamanho[i] > tamanho[j])//laço para comparar tamanhodas palavras e ordená-las junto com suas respectivas palavras
                    {
                        aux = tamanho[i];
                        auxiliar = palavras[i];
                        tamanho[i] = tamanho[j];
                        palavras[i] = palavras[j];
                        tamanho[j] = aux;
                        palavras[j] = auxiliar;

                    }
                }
            }
            Console.Write($"\nPalavra por ordem de tamanho: \n");
            foreach (string palavra in palavras)
            {
                Console.WriteLine($"\t{palavra}");
            }
            Console.ReadLine();
        }
        static void Aula004Exerc04()
        {
            //Jogo Jokenpô
            // Utilizando os conceitos aprendidos até estruturas de repetição, crie um programa que jogue pedra, papel e tesoura(Jokenpô) com você.
            //Permitir que eu decida quantas rodadas iremos fazer;
            //Ler a minha escolha(Pedra, papel ou tesoura);
            //Decidir de forma aleatória a decisão do computador;
            //Mostrar quantas rodadas cada jogador ganhou;
            //Determinar quem foi o grande campeão de acordo com a quantidade de vitórias de cada um(computador e jogador);
            //Perguntar se o Jogador quer jogar novamente, se sim inicie volte a escolha de quantidade de rodadas, se não finalize o programa.
            Console.WriteLine("---------- Exercício 4 ----------\n");
            bool jogar = true;
            int partidas, escolhaU, escolhaC, pontosU, pontosC, cont;
            string[] escolha = {"Pedra", "Papel", "Tesoura"};
            string resultado;
            Random rand = new Random();
            do
            {
                Console.Write($"Quantas partidas deseja jogar? ");
                partidas = int.Parse(Console.ReadLine());
                pontosU = 0;
                pontosC = 0;
                while (partidas > 0)
                {
                    Console.Write($"\nPedra (1)\tPapel (2)\tTesoura (3)");
                    Console.Write($"\nEscolha: ");
                    escolhaU = int.Parse(Console.ReadLine());
                    escolhaC = rand.Next(2) + 1;//escolha randômica do computador
                    Console.WriteLine($"\nVocê escolheu {escolha [escolhaU-1]} e o computador escolheu {escolha[escolhaC-1]}");
                    if(escolhaU == escolhaC)
                    {
                        Console.Write($"\nPartida empatada!\n"); pontosU++; pontosC++;
                    }
                    else if ((escolhaU == 1 && escolhaC == 2) || (escolhaU == 2 && escolhaC == 3) || (escolhaU == 3 && escolhaC == 1))
                    {
                        Console.Write($"\nO computador ganhou essa partida!\n"); pontosC++;
                    }
                    else 
                    {
                        Console.Write($"\nVocê ganhou essa partida\n"); pontosU++;
                    }
                    partidas--;
                }
                resultado = (pontosU == pontosC) ? "\nFinal empatado!\n" : resultado = (pontosU > pontosC) ? "\nParabéns! Você ganhou!!!\n" : "\nO computador ganhou!\n";
                Console.Write(resultado);
                Console.Write("\nDeseja jogar novamente?\tSim = 1\tNão = 0 \t");
                cont = int.Parse(Console.ReadLine());
                if (cont == 0) { jogar = false; }
            } while (jogar == true);
            Console.ReadLine();
        }
        static void Aula004Exerc05()
        {
            //Jogo da Velha
            //Crie um algorítimo que possibilite que dua pessoas joguem o jogo da velha e exiba quem foi o vencedor.
            //O tabuleiro é uma matriz de três linhas e três colunas.
            //Dois jogadores escolhem uma marcação cada um, geralmente um círculo(O) e um xis(X).
            //Os jogadores jogam alternadamente, uma marcação por vez, numa célula que esteja vazia.
            //O objetivo é conseguir três círculos ou três xis em linha, quer horizontal, vertical ou diagonal,
            //e ao mesmo tempo, quando possível, impedir o adversário de ganhar na próxima jogada.
            //Quando um jogador conquista o objetivo ele é o vencedor. Se os dois jogadores jogarem sempre da melhor forma,
            //o jogo terminará sempre em empate ou seja "Deu a Velha!".
            
            string[,] matrizJV = { {"1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            string posicaoX, posicaoO;
            int l, c, i = 0;
            do//laço de preenchimento
            {
                Console.WriteLine("---------- Exercício 5 ----------\n");
                for (l = 0; l < 3; l++)//mostra a matriz
                {
                    for (c = 0; c < 3; c++)
                    {
                        Console.Write($"\t{matrizJV[l, c]}");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine ("\n Jogador X escolha uma posição: ");
                posicaoX = Console.ReadLine();
                for (l = 0; l < 3; l++)//encontra respectiva posição na matriz para colocar o X
                {
                    for (c = 0; c < 3; c++)
                    {
                        if (posicaoX == matrizJV[l, c])
                        {
                            matrizJV[l, c] = "X";
                        }
                    }
                }
                if ((matrizJV[0, 0] == matrizJV[0, 1] && matrizJV[0, 1] == matrizJV[0, 2]) || //verificação de linha
                    (matrizJV[1, 0] == matrizJV[1, 1] && matrizJV[1, 1] == matrizJV[1, 2]) || //verificação de linha
                    (matrizJV[2, 0] == matrizJV[2, 1] && matrizJV[2, 1] == matrizJV[2, 2]) || //verificação de linha
                    (matrizJV[0, 0] == matrizJV[1, 0] && matrizJV[1, 0] == matrizJV[2, 0]) || //verificação de coluna
                    (matrizJV[0, 1] == matrizJV[1, 1] && matrizJV[1, 1] == matrizJV[2, 1]) || //verificação de coluna
                    (matrizJV[0, 2] == matrizJV[1, 2] && matrizJV[1, 2] == matrizJV[2, 2]) || //verificação de coluna
                    (matrizJV[0, 0] == matrizJV[1, 1] && matrizJV[1, 1] == matrizJV[2, 2]) || //verificação de diagonal
                    (matrizJV[0, 2] == matrizJV[1, 1] && matrizJV[1, 1] == matrizJV[2, 0]))   //verificação de diagonal
                {
                    Console.WriteLine("\nTemos um ganhador!\n");
                    i = 10;
                }
                else
                {
                    Console.WriteLine("\nContinue!\n");
                }
                if(i != 10)
                {
                    Console.WriteLine("\nJogador O escolha uma posição: ");
                    posicaoO = Console.ReadLine();
                    for (l = 0; l < 3; l++)//encontra respectiva posição na matriz para colocar o O
                    {
                        for (c = 0; c < 3; c++)
                        {
                            if (posicaoO == matrizJV[l, c])
                            {
                                matrizJV[l, c] = "O";
                            }
                        }
                    }
                    i++;
                }
                if ((matrizJV[0, 0] == matrizJV[0, 1] && matrizJV[0, 1] == matrizJV[0, 2]) || //verificação de linha
                    (matrizJV[1, 0] == matrizJV[1, 1] && matrizJV[1, 1] == matrizJV[1, 2]) || //verificação de linha
                    (matrizJV[2, 0] == matrizJV[2, 1] && matrizJV[2, 1] == matrizJV[2, 2]) || //verificação de linha
                    (matrizJV[0, 0] == matrizJV[1, 0] && matrizJV[1, 0] == matrizJV[2, 0]) || //verificação de coluna
                    (matrizJV[0, 1] == matrizJV[1, 1] && matrizJV[1, 1] == matrizJV[2, 1]) || //verificação de coluna
                    (matrizJV[0, 2] == matrizJV[1, 2] && matrizJV[1, 2] == matrizJV[2, 2]) || //verificação de coluna
                    (matrizJV[0, 0] == matrizJV[1, 1] && matrizJV[1, 1] == matrizJV[2, 2]) || //verificação de diagonal
                    (matrizJV[0, 2] == matrizJV[1, 1] && matrizJV[1, 1] == matrizJV[2, 0]))   //verificação de diagonal
                {
                    Console.WriteLine("\nTemos um ganhador!\n");
                    i = 10;
                }
                else 
                {
                    Console.WriteLine("\nContinue!\n");
                }
                i++;
                Console.WriteLine($"\ncontagem i = {i}\n");
                Console.ReadLine();
                Console.Clear();
            } while (i < 8);
            string final = (i <= 9) ? "\nDeu velha!\n" : "\nParabêns!\n";
            Console.WriteLine(final);
            for (l = 0; l < 3; l++)//mostra a matriz final
            {
                for (c = 0; c < 3; c++)
                {
                    Console.Write($"\t{matrizJV[l, c]}");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
