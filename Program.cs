using System;

namespace Listasharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //questao 1

            int num;
            num = 1;
            while (num <= 40)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write(num);
                Console.Write("\t");
                num = num + 1;
            }
            Console.ReadKey();
            Console.Clear();

            //Questao 2

            int x;
            x = 2;
            int y;
            y = 3;

            {
                Console.WriteLine("x = " + x);
                Console.WriteLine(" O valor de x + x é " + (x + x));
                Console.WriteLine("x = ");
                Console.WriteLine((x + y) + " = " + (y + x));
                Console.ReadKey();
                Console.Clear();

                //Questão 3
                {
                    Console.WriteLine("*\n**\n***\n****\n*****");
                    Console.ReadLine();
                    Console.ReadKey();
                    Console.Clear();

                    //Questao 4
                }
                Console.Write("*");
                Console.Write("***");
                Console.WriteLine("*****");
                Console.Write("****");
                Console.WriteLine("**");
                Console.ReadKey();
                Console.Clear();

                //Questao 5
                {

                    Console.WriteLine("Qual seu Nome?");
                    var nome = Console.ReadLine();
                    Console.WriteLine("Qual seu Sobrenome?");
                    var sobrenome = Console.ReadLine();
                    Console.WriteLine("Qual sua matricula?");
                    var matricula = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write($" {matricula} " );
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"{nome} {sobrenome}");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.Clear();
                }

                //Questao 6

                {
                    int n1, n2;
                    int soma, sub, div, mult;

                    Console.WriteLine("Digite um número: ");

                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite outro número: ");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    soma = n1 + n2;
                    sub = n1 - n2;
                    div = n1 / n2;
                    mult = n1 * n2;

                    Console.WriteLine("a soma é: " + soma);
                    Console.WriteLine("a subtração é: " + sub);
                    Console.WriteLine("a divisão é: " + div);
                    Console.WriteLine("a multiplicação é: " + mult);
                    Console.ReadKey();
                    Console.Clear();

                    //Questão 7

                    double diametro;
                    double circuferencia;
                    double area;
                    double raio;
                    const double PI = 3.14D;

                    Console.WriteLine("Qual valor do raio?");
                    raio = int.Parse(Console.ReadLine());

                    area = PI * raio * raio;
                    diametro = 2 * raio;
                    circuferencia = PI * diametro;

                    Console.Write("\n\tA área do circulo é: " + area);
                    Console.Write("\n\tO diâmetro do circulo é: " + diametro);
                    Console.Write("\n\tA circunferência do circulo é: " + circuferencia);

                    Console.ReadKey();
                    Console.Clear();

                    //Questao 8

                    int a;
                    int b;
                    int resto = 0;

                    Console.WriteLine("Informe um valor para a: ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe um valor para b: ");
                    b = Convert.ToInt32(Console.ReadLine());

                    resto = a % b;

                    if (resto == 0)
                    {
                        Console.WriteLine($"{a} é divisível de {b}");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine($"{a} não é divisível de {b}");
                        Console.ReadKey();
                        Console.Clear();
                    }


                    //Questao 9

                    //Questao 10
                }
            }
         } 
    }
}