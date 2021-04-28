using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello, World
            Console.WriteLine("Hala Madrid!");

            //Variaveis numéricas
            int idade = 21;
            double altura = 1.77;
            long idadeUniverso = 13000000000;
            short chuteiras = 9;
            int novaAltura = (int)altura; // Cast

            //Char e Strings
            char letra = 'n';
            string frase = "Eu amo Maria";

            //Boolean
            bool amoMaria = true; //eu sou muito babão

            //Prints
            Console.WriteLine("Minha idade é " + idade);
            Console.WriteLine("Tenho " + altura + " metros de altura");
            Console.WriteLine("O universo tem uns " + idadeUniverso + " de anos");
            Console.WriteLine("\n" + frase);

            // if's

            if (chuteiras == 7) {
                Console.WriteLine("Número de chuteiras é o número do papai Cris");
            }

            else if (chuteiras == 12) {
                Console.WriteLine("Número de chuteiras é o número de M12");
            }

            else {
                Console.WriteLine("As chuteiras foram perdidas :(\n");
            }


            int n = 0;
            while (true) {
                Console.WriteLine("O que vale é o que importa");
                n++;

                if (n == 3) {
                    Console.WriteLine();
                    break;
                }
            }

            //Fatorial (sem recursão)

            int resultado = 0;
            int multi = 1;
            int fatorial = 0;

            for (int i = 1; i < 11; i++) {
                fatorial = i;
                resultado = multi * fatorial;
                multi = resultado;

                Console.WriteLine("Fatorial de " + i + " é " + resultado);                
            }        
        }
    }
}
