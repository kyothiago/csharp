using System;
using System.Globalization;

namespace ExerciciosPropostos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1: ");
            Console.WriteLine("Insira o primeiro inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo inteiro: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine("SOMA = " + soma);

            Console.WriteLine("Exercício 2: ");
            double pi = 3.14159;
            Console.WriteLine("Insira o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = Math.Pow(raio, 2.0) * pi;
            Console.WriteLine($"A área é = {area:F4}");
            Console.WriteLine("Exercício 3: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int diferenca = a * b - c * d;
            Console.WriteLine("Diferença = " + diferenca);

            Console.WriteLine("Exercício 4: ");
            int id = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = (horas * valor);
            Console.WriteLine("NUMBER = " + id);
            Console.WriteLine("SALARY = " + salario.ToString("F2"));

            Console.WriteLine("Exercício 5");
            int cod1, cod2, qtde1, qtde2;
            double preco1, preco2, total;
            string[] vet = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vet[0]);
            qtde1 = int.Parse(vet[1]);
            preco1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vet[0]);
            qtde2 = int.Parse(vet[1]);
            preco2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = preco1*qtde1 + preco2*qtde2;
            Console.WriteLine("Valor a pagar = R$ " + total);

            Console.WriteLine("Exercício 6: ");
            double A, B, C, triangulo, retangulo, circulo, trapezio, quadrado;
            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);
            triangulo = A * C / 2.0;
            circulo = Math.Pow(C, 2) * 3.14159;
            trapezio = (A + B) / 2.0 * C;
            quadrado = Math.Pow(B, 2.0);
            retangulo = A * B;
            Console.WriteLine("triângulo = " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("círculo = " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("trapézio = " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("quadrado = " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("retângulo = " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
