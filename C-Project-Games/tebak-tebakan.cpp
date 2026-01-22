#include <iostream>
#include <ctime>

int main()
{

    int num;
    int guess;
    int tries;

    srand(time(0));
    num = (rand() % 100) + 1;

    std::cout << "========= Tebak Angka =========\n";

    do
    {
        std::cout << "Masukkan angka antara (1 - 100): ";
        std::cin >> guess;
        tries++;

        if (guess > num)
        {
            std::cout << "Terlalu tinggi!\n";
        }
        else if (guess < num)
        {
            std::cout << "Terlalu kecil!\n";
        }

        else
        {
            std::cout << "Mantap, kamu lulus! # Coba lagi?: " << tries << '\n';
        }
    } while (guess != num);

    std::cout << "========= Mantap =========\n";
    return 0;
}
