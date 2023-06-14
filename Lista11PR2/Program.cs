using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        public static void Exercicio1()
        {
            int num, stop = 0;
            int[] vet;
            vet = new int[1000];
            Random rand = new Random();

            for (int i = 0; stop < 1; i++)
            {
                vet[i] = rand.Next(1, 10);
                Console.WriteLine("digite um numero:");
                num = int.Parse(Console.ReadLine());

                for (int j = 0; j < 1000; j++)
                {
                    if (vet[j] == num)
                    {
                        Console.WriteLine("voce adivinhou o número!");
                        stop = 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("numero errado!");
                        break;
                    }
                }

            }
        }
        public static void Exercicio2()
        {
            int num, q = 0, stop = 0;
            int[] vet;
            vet = new int[20000];
            Random rand = new Random();

            for (int i = 0; i < 20000; i++)
            {
                vet[i] = rand.Next(1, 100);
            }

            Console.WriteLine("digite um numero:");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 20000; i++)
            {
                if (vet[i] == num)
                {
                    q = q + 1;
                }
            }
            Console.WriteLine("a quantidade deste numero no vetor é: " + q);
        }

        public static void Exercicio3()
        {
            int[] vet, vetp, veti;
            vet = new int[10];
            vetp = new int[10];
            veti = new int[10];
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                vet[i] = rand.Next(1, 100);
            }

            for (int i = 0; i < 10; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    vetp[i] = vet[i] / 2;
                    Console.WriteLine("numero par ápós dividir por 2 no vetor é: " + vetp[i]);
                }
                else
                {
                    veti[i] = vet[i] * 3;
                    Console.WriteLine("numero impar ápós multiplicar por 3 no vetor é: " + veti[i]);
                }
            }
        }
        public static void Exercicio4()
        {
            int[] vet, num;
            vet = new int[5000];
            Random rand = new Random();

            for (int i = 0; i < 5000; i++)
            {
                vet[i] = rand.Next(1, 100);
            }


            for (int i = 1; i < 5000; i++)
            {
                for (int j = 2; j < vet[i]; j++)
                {
                    if (vet[i] % j == 1)
                    {
                        Console.WriteLine("o numero " + vet[i] + " é primo");
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            int option;

            do
            {
                Console.WriteLine("=================MENU=================");
                Console.WriteLine("para executar o exercício 1 - digite 1");
                Console.WriteLine("para executar o exercício 2 - digite 2");
                Console.WriteLine("para executar o exercício 3 - digite 3");
                Console.WriteLine("para executar o exercício 4 - digite 4");
                Console.WriteLine("para sair do programa    -    digite 0");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("thank you for using my system!");

                        break;

                    case 1:
                        Exercicio1();

                        break;

                    case 2:
                        Exercicio2();

                        break;

                    case 3:
                        Exercicio3();

                        break;

                    case 4:
                        Exercicio4();

                        break;

                    default:
                        Console.WriteLine("wrong option!");

                        break;
                }
            } while (option != 0);
        }
    }
}
