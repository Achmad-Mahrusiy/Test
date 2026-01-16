namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter yout age: ");
            double age = Convert.ToDouble(Console.ReadLine());


            if (age >= 0 && age <= 6)
            {
                Console.WriteLine("Nikmati masa kecilmu");
            }

            else if (age >= 7 && age <= 15)
            {
                Console.WriteLine("Maksimalkan potensimu, karena kamu masih muda");
            }

            else if (age >= 16 && age <= 24)
            {
                Console.WriteLine("Maksimalkan potensi remajamu");
            }

            else
            {
                Console.WriteLine("Jalani pekerjaanmu secara santai");
            }
            Console.ReadKey();
        }    
    }
}
