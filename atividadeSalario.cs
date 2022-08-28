using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int habitantes, filhos, total_filhos;
            double media_salario, salario, media_filhos, percentual_salario, percentual, soma_salario, maior_salario;

            Console.WriteLine("Cálculo de médias de uma prefeitura");

            media_salario = 0;
            habitantes = 0;
            soma_salario = 0;
            maior_salario = 0;
            percentual_salario = 0;
            total_filhos = 0;
            media_filhos = 0;
            percentual = 0;

            do
            {
                Console.Write("\nDigite o valor do seu salário: R$");
                salario = double.Parse(Console.ReadLine());

                if (salario >= 0)
                {
                    habitantes += 1;
                    soma_salario = soma_salario + salario;
                    media_salario = soma_salario / habitantes;

                    if (salario <= 2000)
                    {
                        percentual_salario = percentual_salario + 1;  
                    }

                    if (maior_salario < salario)
                    {
                        maior_salario = salario;
                    }

                    Console.Write("\nDigite a quantidade de filhos: ");
                    filhos = int.Parse(Console.ReadLine());

                    total_filhos = total_filhos + filhos;
                    media_filhos = total_filhos / habitantes;
                }
                else
                    break;
            }
            while (salario >= 0) ;

            percentual = (percentual_salario * 100) / habitantes;

            Console.WriteLine("\nMédia dos salários: R$ {0:F2}", media_salario);
            Console.WriteLine("Média dos filhos: {0}", media_filhos);
            Console.WriteLine("Maior salário: R$ {0:F2}", maior_salario);
            Console.WriteLine("Percentual salários até R$2000.00: {0:F2}", percentual + "%");
            Console.WriteLine("Habitantes: " + habitantes);
            Console.WriteLine("Percentual salário: " + percentual_salario);

            Console.ReadKey();
        }    
    }
}
