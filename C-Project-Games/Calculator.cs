using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("--- Calculator ---");
                Console.WriteLine("------------------");

                Console.Write("Masukkan angka pertama: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan angka kedua: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Masukkan Opsi: ");
                Console.WriteLine("\t+ : tambah");
                Console.WriteLine("\t- : kurang");
                Console.WriteLine("\t* : kali");
                Console.WriteLine("\t/ : bagi");
                Console.Write("Masukkan opsi: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Hasilnya : {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Hasilnya : {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Hasilnya : {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Hasilnya : {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Opsi tidak valid");
                        break;
                }
                Console.WriteLine("apakah kamu mau melanjutkannya? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
