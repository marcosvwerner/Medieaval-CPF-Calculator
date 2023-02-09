using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medieaval_CPF_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Everything is working fine. Press any key to proceed...");
            Console.ReadKey();

            Console.WriteLine("Enter cpf number:");
            string cpf = Console.ReadLine();
            Console.WriteLine(cpf);

            char cpf0 = cpf[0];
            Console.WriteLine(cpf0);
            int cpfi0 = cpf0 - '0';
            // explanation: cpf 0 - '0' means the ascii values of the characters are subtracted from each other. Since 0 comes directly before 1 in the ascii table the difference between the tow gives the number that the character cpf0 represents
            Console.WriteLine("converted: " + cpfi0);
            int calc0 = cpfi0 * 10;
            Console.WriteLine("Value is: " + calc0);


            //FIRST VALIDATOR DIGIT CALCULATION:
            int sumFirstDigit = 0;
            char cpfchar;
            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            foreach (int multi in multiplicador1)
            {
                Console.WriteLine("Array is: " + multi);
            }

            Console.WriteLine("Tamanho: " + multiplicador1.Length);

            for (int i = 0; i < 9; i++)
            {
                cpfchar = cpf[i]; //define o index do cpf
                Console.WriteLine(i + " " + cpfchar); //escreve o indice e o numero correspondente
                int cpfint = cpfchar - '0'; // converte o char cpf para numero inteiro
                int multiplyResult1 = cpfint * multiplicador1[i]; //multiplica o numero pelo valor do array correspondente
                sumFirstDigit += multiplyResult1; //soma todos os numeros para calculo do primeiro digito verificar do CPF
            }

            Console.WriteLine(sumFirstDigit);
            int modFirstDigit = sumFirstDigit % 11;
            Console.WriteLine("Módulo do primeiro digito: " + modFirstDigit);
            int result1stDigit = 11 - modFirstDigit;
            Console.WriteLine("Resultado do primeiro dígito é: " + result1stDigit);
            int finalResult1stDigit;

            if (result1stDigit > 9)
            {
                Console.WriteLine("O primeiro dígito deve ser 0");
                finalResult1stDigit = 0;
            }
            else
            {
                Console.WriteLine("O primeiro dígito deve ser " + result1stDigit);
                finalResult1stDigit = result1stDigit;

            }

            Console.WriteLine();

            //SECOND VALIDATOR DIGIT CALCULATION:
            int sum2ndDigit = 0;
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
          

            Console.WriteLine("Tamanho array 2: " + multiplicador2.Length);

            for (int i = 0; i < 10; i++)
            {
                cpfchar = cpf[i]; //define o index do cpf
                Console.WriteLine(i + " " + cpfchar); //escreve o indice e o numero correspondente
                int cpfint = cpfchar - '0'; // converte o char cpf para numero inteiro
                int multiplyResult2nd = cpfint * multiplicador2[i]; //multiplica o numero pelo valor do array correspondente
                sum2ndDigit += multiplyResult2nd; //soma todos os numeros para calculo do segundo digito verificar do CPF
            }

            Console.WriteLine(sum2ndDigit);
            int mod2ndDigit = sum2ndDigit % 11;
            Console.WriteLine("Módulo do segundo digito: " + mod2ndDigit);
            int result2ndDigit = 11 - mod2ndDigit;
            Console.WriteLine("Resultado do segundo dígito é: " + result2ndDigit);

            if (result2ndDigit > 9)
            {
                Console.WriteLine("O segundo dígito deve ser 0");
            }
            else
            {
                Console.WriteLine("O segundo dígito deve ser " + result2ndDigit + "\n");

            }



            //FINAL VALIDATION

            int cpf9 = cpf[9] - '0';
            Console.WriteLine(cpf9);

            int cpf10 = cpf[10] - '0';
            Console.WriteLine(cpf10);

            bool dig1 = false;
            bool dig2 = false;

            if (finalResult1stDigit == cpf9 && result2ndDigit == cpf10)
            {
                Console.WriteLine("All right!\n");
                dig1 = true;
                dig2 = true;

            }

            if (result2ndDigit == cpf10)
            {
                Console.WriteLine("Yeah, bitch!\n");
                dig2 = true;
            }

            Console.Write(dig1);
            Console.WriteLine(dig2);

            Console.WriteLine("All done! Press any key to exit...");

            Console.ReadKey();
        }

    }
}
