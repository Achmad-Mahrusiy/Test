using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine(); 

            if (name != "")
            {
                Console.WriteLine("Welcome " + name);
            }
            else
            {
                Console.WriteLine("Kamu tidak menuliskan nama kamu");
            }

            Console.WriteLine("Enter yout age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age == 18)
            {
                Console.WriteLine("You are now signed");
            }
            else if (age < 17)
            {
                Console.WriteLine("kamu masih dibawah umur untuk login ke halaman ini");
            }
            else if (age >= 18) {
                Console.WriteLine("Selamat anda sudah dewasa, untuk menjalani kehidupanmu sendiri");
            }
            else
            {
                Console.WriteLine("You must be 18+ to signed up!");
            }

            Console.WriteLine("Sekarang hari apa?");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Senin":
                    Console.WriteLine("Hari Gajelas");
                    break;
                case "Selasa":
                    Console.WriteLine("Harinya Lumayan enak dikit");
                    break;
                case "Rabu":
                    Console.WriteLine("Hari agak enak");
                    break;
                case "Kamis":
                    Console.WriteLine("Hari cukup lah");
                    break;
                case "Jumat":
                    Console.WriteLine("Sudah saatnya makanan shalat jumat");
                    break;
                case "Sabtu":
                    Console.WriteLine("Hari paling mantap");
                    break;
                case "Minggu":
                    Console.WriteLine("Hari Terjoss");
                    break;
                default:
                    Console.WriteLine("Hari yang kamu masukkan tidak valid");
                    break;
            }

            Console.ReadKey();
        }
    }
}
