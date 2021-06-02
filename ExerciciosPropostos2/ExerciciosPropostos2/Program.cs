using System;
using System.Globalization;

namespace ExerciciosPropostos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1");
            Console.WriteLine("Escreva um número inteiro!");
            int numero = int.Parse(Console.ReadLine());
            if(numero < 0)
            {
                Console.WriteLine("Número negativo!");
            }
            else
            {
                Console.WriteLine("Número positivo!");
            }

            Console.WriteLine("Exercício 2");
            Console.WriteLine("Escreva um número inteiro!");
            int numero2 = int.Parse(Console.ReadLine());
            if(numero2 % 2 == 0)
            {
                Console.WriteLine("Número par!");
            }
            else
            {
                Console.WriteLine("Número ímpar!");
            }
            Console.WriteLine("Exercício 3");
            Console.WriteLine("Escreva um número inteiro:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro número:");
            int b = int.Parse(Console.ReadLine());
            if(a%b == 0 || b%a == 0)
            {
                Console.WriteLine("Os números são múltiplos");
            }
            else
            {
                Console.WriteLine("Os números não são múltiplos");
            }
            Console.WriteLine("Exercício 4");
            Console.WriteLine("Escreva a hora que começou o jogo");
            int hora1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a hora que terminou o jogo");
            int hora2 = int.Parse(Console.ReadLine());
            int duracao;
            if(hora1 < hora2)
            {
                duracao = hora2 - hora1;
            }
            else
            {
                duracao = 24 - hora1 + hora2;
            }
            Console.WriteLine("O jogo durou: " + duracao + " horas");

            Console.WriteLine("Exercício 5");
            Console.WriteLine("Escreva o código e a quantidade do produto");
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);
            double total;
            if(codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if(codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if(codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if(codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }
            Console.WriteLine("Total R$: "+ total.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Exercício 6");
            Console.WriteLine("Escreva um valor:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor < 0 || valor > 100)
            {
                Console.WriteLine("Valor fora de intervalo");
            }
            else if (valor <= 25)
            {
                Console.WriteLine("Intervalo: [0, 25]"); 
            }
            else if (valor <= 50)
            {
                Console.WriteLine("Intervalo: [25, 50"); 
            }
            else if (valor <= 75)
            {
                Console.WriteLine("Intervalo: [50, 75]"); 
            }
            else
            {
                Console.WriteLine("Intervalo: [75, 100]");
            }
            Console.WriteLine("Exercício 7");
            Console.WriteLine("Escreva o valor no eixo x:");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Escreva o valor no eixo y:");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if(x == 0 && y != 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if(y == 0 && x != 0)
            {
                Console.WriteLine("Eixo y");
            }
            else
            {
                Console.WriteLine("Origem");
            }
            Console.WriteLine("Exercício 8");
            Console.WriteLine("Escreva o valor do salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;
            if(salario>= 0.0 && salario <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if(salario <= 3000.0)
            {
                imposto = (salario - 2000) * 0.08;
            }
            else if(salario <= 4500.0)
            {
                imposto = (salario - 3000) * 0.18 + 1000.0 * 0.08;
                
            }
            else(salario > 4500.0)
            {
                imposto = (salario - 4500) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
            if(salario < 0.0)
            {
                Console.WriteLine("Salário inválido");
            }
            else
            {
                Console.WriteLine("Imposto foi de: " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
