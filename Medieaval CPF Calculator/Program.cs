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

            string keepRunning = "1";

            while (keepRunning == "1")
            {
                Console.WriteLine("\nEnter cpf number:");
                string cpf = Console.ReadLine();

                Console.WriteLine("\nO número CPF a ser validado é: " + cpf);




                //FIRST VALIDATOR DIGIT CALCULATION:
                int sumFirstDigit = 0;
                char cpfchar;
                int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };


                Console.WriteLine("\nTamanho do primeiro array multiplicador: " + multiplicador1.Length);

                for (int i = 0; i < 9; i++)
                {
                    cpfchar = cpf[i]; //define o index do cpf               
                    int cpfint = cpfchar - '0'; // converte o char cpf para numero inteiro (- '0' means the ascii values of the characters are subtracted from each other. Since 0 comes directly before 1 in the ascii table the difference between the tow gives the number that the character cpf0 represents)
                    int multiplyResult1 = cpfint * multiplicador1[i]; //multiplica o numero pelo valor do array correspondente
                    sumFirstDigit += multiplyResult1; //soma todos os numeros para calculo do primeiro digito verificar do CPF
                }

                Console.WriteLine("Soma dos valores após multiplicão dos 9 primeiros dígitos: " + sumFirstDigit);
                int modFirstDigit = sumFirstDigit % 11;
                Console.WriteLine("Módulo da divisão: " + modFirstDigit);
                int result1stDigit = 11 - modFirstDigit;
                Console.WriteLine("Resultado do primeiro dígito verificador é: " + result1stDigit);
                int finalResult1stDigit;

                if (result1stDigit > 9)
                {
                    Console.WriteLine("Neste caso o primeiro dígito verificador deve ser 0");
                    finalResult1stDigit = 0;
                }
                else
                {
                    Console.WriteLine("Neste caso o primeiro dígito verificador deve ser " + result1stDigit);
                    finalResult1stDigit = result1stDigit;

                }

                Console.WriteLine();

                //SECOND VALIDATOR DIGIT CALCULATION:
                int sum2ndDigit = 0;
                int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };


                Console.WriteLine("Tamanho do segundo array multiplicador: " + multiplicador2.Length);

                for (int i = 0; i < 10; i++)
                {
                    cpfchar = cpf[i]; //define o index do cpf                
                    int cpfint = cpfchar - '0'; // converte o char cpf para numero inteiro
                    int multiplyResult2nd = cpfint * multiplicador2[i]; //multiplica o numero pelo valor do array correspondente
                    sum2ndDigit += multiplyResult2nd; //soma todos os numeros para calculo do segundo digito verificar do CPF
                }

                Console.WriteLine("Soma dos valores após multiplicão dos 10 primeiros dígitos: " + sum2ndDigit);
                int mod2ndDigit = sum2ndDigit % 11;
                Console.WriteLine("Módulo da divisão: " + mod2ndDigit);
                int result2ndDigit = 11 - mod2ndDigit;
                Console.WriteLine("O resultado do segundo dígito verificador é: " + result2ndDigit);
                int finalResult2ndDigit;

                if (result2ndDigit > 9)
                {
                    Console.WriteLine("Neste caso o segundo dígito verificador deve ser 0");
                    finalResult2ndDigit = 0;
                }
                else
                {
                    Console.WriteLine("Neste caso o segundo dígito verificador deve ser " + result2ndDigit + "\n");
                    finalResult2ndDigit = result2ndDigit;

                }



                //FINAL VALIDATION

                int cpf9 = cpf[9] - '0';
                int cpf10 = cpf[10] - '0';


                Console.WriteLine();
                bool isValid;

                if (finalResult1stDigit == cpf9 && finalResult2ndDigit == cpf10)
                {
                    Console.WriteLine("CPF VÁLIDO \n");
                    isValid = true;
                    Console.Beep();

                }
                else
                {
                    Console.WriteLine("CPF INVÁLIDO");
                    Console.Beep();
                    Console.Beep();
                    isValid = false;
                }
                Console.WriteLine("Deseja validar outro CPF? 1-Sim/2-Não");
                keepRunning = Console.ReadLine(); 
                
            }
            

            

            

            Console.WriteLine("\nDone! Press any key to exit...");

            Console.ReadKey();
        }

    }
}
