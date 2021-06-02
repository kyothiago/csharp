using System;
using System.Globalization;

namespace ExerciciosPropostos4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o número do exercício: (1-7)");
            int exercicio = int.Parse(Console.ReadLine());
            if (exercicio == 1)
            {
                Console.WriteLine("Escreva um número inteiro entre 1 e 1000");
                int x = int.Parse(Console.ReadLine());
                if (x < 1 || x > 1000)
                {
                    Console.WriteLine("Número Inválido");
                }
                else
                {
                    for (int i = 1; i <= x; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            else if (exercicio == 2)
            {
                Console.WriteLine("Escreva a quantidade de números");
                int n = int.Parse(Console.ReadLine());
                int countIn = 0;
                int countOut = 0;
                for (int i = 0; i < n; i++)
                {
                    int x = int.Parse(Console.ReadLine());
                    if (x >= 10 && x <= 20)
                    {
                        countIn++;
                    }
                    else
                    {
                        countOut++;
                    }
                }
                Console.WriteLine(countIn + " in");
                Console.WriteLine(countOut + " out");
            }
            else if (exercicio == 3)
            {
                Console.WriteLine("Escreva a quantidade de testes, cada teste consiste de 3 notas!");

                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    string[] line = Console.ReadLine().Split(' ');
                    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                    double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                    double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10;

                    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            else if (exercicio == 4)
            {
                Console.WriteLine("Escreva a quantidade de pares");

                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    string[] line = Console.ReadLine().Split(' ');
                    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                    double b = double.Parse(line[1], CultureInfo.InvariantCulture);

                    if(b == 0)
                    {
                        Console.WriteLine("Divisão impossível");
                    }
                    else
                    {
                        double div = (double)a / b;
                        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                    }

                }
            }
            else if (exercicio == 5)
            {
                Console.WriteLine("Escreva o número que quer saber o fatorial");
                int n = int.Parse(Console.ReadLine());
                int fatorial = 1;
                for(int i = 1; i <= n; i++)
                {
                    fatorial *= i;
                }
                Console.WriteLine(fatorial);

            }
            else if (exercicio == 6)
            {
                Console.WriteLine("Escreva o número que quer os divisores");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++){
                    if(n % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if (exercicio == 7)
            {
                Console.WriteLine("Escreva o número de linhas");
                int n = int.Parse(Console.ReadLine());
                if(n <= 0)
                {
                    Console.WriteLine("Número negativo");
                }
                else
                {
                    for(int i = 1; i <=n ; i++)
                    {
                        int primeiro = i;
                        int segundo = (int) Math.Pow(i, 2);
                        int terceiro = (int) Math.Pow(i, 3);
                        Console.WriteLine($"{primeiro} {segundo} {terceiro}");
                    }
                }

            }
            else
            {
                Console.WriteLine("Exercício inválido");
            }
        }
    }
}
