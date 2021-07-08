using System;

namespace leituraEMultiplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] n = new int[10];

                inicio();

                // for (int i = 1; i == 10; i++)
                // {
                //     Console.Write($"- Digite o {i}º valor.:  ");
                //     n[0] = Convert.ToInt32(Console.ReadLine());
                //     Console.WriteLine("|");
                // }


                Console.Write("- Digite o primeiro valor.:  ");
                n[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("|");

                Console.Write("- Digite o segundo valor...: ");
                n[1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("|");

                Console.Write("- Digite o terceiro valor..: ");
                n[2] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("|");

                Console.Write("- Digite o quarto valor....: ");
                n[3] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("|");

                Console.Write("- Digite o quinto valor....: ");
                n[4] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("|");

                Console.Write("- Digite o sexto valor.....: ");
                n[5] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("|");

                Console.Write("- Digite o sétimo valor....: ");
                n[6] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("|");

                Console.Write("- Digite o oitavo valor....: ");
                n[7] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("|");

                Console.Write("- Digite o nono valor......: ");
                n[8] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("|");

                Console.Write("- Digite o décimo valor....: ");
                n[9] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                int[] b = new int[]{n[0] * 3, n[1] * 2, n[2] * 3, n[3] * 2,
                                    n[4] * 3, n[5] * 2, n[6] * 3, n[7] * 2,
                                    n[8] * 3, n[9] * 2
                                    };

                Console.WriteLine("* Lembrando que a multiplicação acontece por posição.");
                Console.WriteLine();

                int contador = 1;
                foreach (int valorImpresso in b)
                {
                    Console.WriteLine($" {contador}º resultado: {valorImpresso}");
                    contador++;
                }
            }

            catch (FormatException)
            {
                Console.WriteLine();

                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Atenção!! O valor de entrada não está no formato correto.");
                Console.ResetColor();
            }

            catch (OverflowException)
            {
                Console.WriteLine();

                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Atenção!! O valor de entrada excede o tamanho permitido.");
                Console.ResetColor();
            }
        }

        static void inicio()
        {
            Console.Clear();

            Console.Beep();
            Console.WriteLine("|----------------------------------------");
            Console.WriteLine("|-- Exercício Leitura e Multiplicação ---");
            Console.WriteLine("|----------------------------------------");
            Console.Beep();

            Console.WriteLine("|");

            Console.Write("|--> Leitura de um vetor de 10 números inteiros e geração de um ");
            Console.Write("segundo vetor (que deve ser impresso), cujo valor das posições pares ");
            Console.WriteLine("são o dobro do vetor original e as ímpares são o triplo.");
            Console.WriteLine();
        }
    }
}
