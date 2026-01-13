using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Name: ");
            String firstName = Console.ReadLine();

            Console.WriteLine("Enter Your last name ");
            String lastName = Console.ReadLine();

            String fullName = firstName + " " + lastName;
            String userName = fullName.Insert(0, "Tuan atau nyonya. ");

            Console.WriteLine("Masukkan Tahun kelahiran anda");
            String tahun = Console.ReadLine();

            Console.WriteLine("Masukkan Bulan kelahiran anda");
            String bulan = Console.ReadLine();

            Console.WriteLine("Masukkan Hari kelahiran anda");
            String hari = Console.ReadLine();

            Console.WriteLine("Selamat Datang " + userName);

            Console.WriteLine("Data kelahiran anda pada tahun " + tahun + " bulan "+ bulan + " tanggal "+ hari );

            Console.ReadKey();
        }
    }
}
