# crivo-erat-stenes-
Crivo Eratóstenes CSharp - Prime numbersusing System;
using System.Globalization;
using System.Transactions;
using System.Collections;
using System.ComponentModel;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList final = new ArrayList();
            int num_inicial;
            int num_final;
            Boolean primo;

            Console.WriteLine("Olá, bem vindx ao jogo! \nDigite o número inicial:");
            num_inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número final:");
            num_final = int.Parse(Console.ReadLine());

            for (int i = num_inicial; i <= num_final; i++)
            {
                primo = true;
                if (i == 1)
                {
                    primo = false;
                }
                if (primo)
                {
                    if ((i % 2 == 0) && (i != 2))
                    {
                        primo = false;

                    }

                }
                if (primo)
                {

                    for (int j = 3; j <= (i / 2); j++)
                    {
                        if (i % j == 0)
                        {

                            primo = false;
                            break;

                        }
                    }

                }

                if (primo)
                {

                    final.Add(i);


                }

            }

            for (int x = 0; x < final.Count; x++)
            {
                Console.Write(final[x] + " ");

            }

        }
    }
}
























