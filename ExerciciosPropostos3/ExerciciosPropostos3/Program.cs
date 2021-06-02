using System;

namespace ExerciciosPropostos3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o número do exercício: (1-3)");
            int exercicio = int.Parse(Console.ReadLine());
            if(exercicio == 1)
            {
                int senha = 2002;
                Console.WriteLine("Informe a senha: ");
                int senhaInformada = int.Parse(Console.ReadLine());
                while (senhaInformada != senha)
                {
                    Console.WriteLine("Senha Inválida");
                    senhaInformada = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Acesso Permitido");
            }
            else if (exercicio == 2)
            {
                Console.WriteLine("Insira os valores de x e y");
                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);
                while (x != 0 && y != 0)
                {
                    if(x > 0 && y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else if(x < 0 && y > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                    else if(x < 0 && y < 0)
                    {
                        Console.WriteLine("terceiro");
                    }
                    else
                    {
                        Console.WriteLine("quarto");
                    }
                    valores = Console.ReadLine().Split(' ');
                    x = int.Parse(valores[0]);
                    y = int.Parse(valores[1]);
                }
            }
            else if (exercicio == 3)
            {
                int alcool = 0;
                int gasolina = 0;
                int diesel = 0;
                Console.WriteLine("insira o código do tipo de combustível (1 - alcool 2 - gasolina 3 - diesel 4 - Fim");
                int tipo = int.Parse(Console.ReadLine());
                while(tipo != 4)
                {
                    if(tipo == 1)
                    {
                        alcool++;
                    }
                    else if (tipo == 2)
                    {
                        gasolina++;
                    }
                    else if (tipo == 3)
                    {
                        diesel++;
                    }
                    else
                    {
                        Console.WriteLine("Código inválido");
                        Console.WriteLine("Insira novo código");
                    }
                    tipo = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Muito Obrigado");
                Console.WriteLine("Alcool: " + alcool);
                Console.WriteLine("Gasoline: " + gasolina);
                Console.WriteLine("Diesel: " + diesel);
            }
            else
            {
                Console.WriteLine("Exercício inválido");
            }
        }
    }
}
