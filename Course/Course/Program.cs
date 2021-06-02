using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 23;
            double saldo = 10.65462;
            string nome = "Ana";

            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); //F como texto com número ao lado para definir quantidade de casas decimais.
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //para usar o "." ao invés de "," 
            //CultureInfo é uma função do System.Globalization necessário colocar ele para funcionar!
            Console.WriteLine("{0} tem {1} anos e tem saldo de {2:F2} reais", nome, idade, saldo); //para alterar no meio da frase a quantidade de casas decimais usa-se :F(casasdecimais)
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo de {saldo:F2} reais"); //usando o $ antes das aspas, pode usar diretamente as variaveis dentro dos {} ao invés de puxar ao final!

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF"; //+= também faz concatenação de elementos string! 
            Console.WriteLine(s); //é possível inicializar várias variaveis na mesma linha!
            double a = 1.0, b = -3.0, c = -4.0; //forma que se inicializa mais de uma variável do mesmo tipo na mesma linha, porém isso não é uma boa prática!
            double delta = b * b - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(delta);
            Console.WriteLine("o valor x1 da equação é: " + x1);
            Console.WriteLine("o valor x2 da equação é: " + x2);

            string frase = Console.ReadLine();

            Console.WriteLine("Você digitou: " + frase);

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            string[] vet = Console.ReadLine().Split(' ');//o split vai reconhecer onde tem um espaço na frase e armazenar em um vetor
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            //para receber um número inteiro, int/char/double/float.Parse(Console.ReadLine()); no caso de números quebrados usar o "CultureInfo.InvariantCulture"

        }
    }
}
