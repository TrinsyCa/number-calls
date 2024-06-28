using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-> Proje 1\n\n");
        project1();
        Console.WriteLine("\n\n-> Proje 2\n\n");
        project2();
        Console.ReadKey();
    }

    static void project1()
    {
        int[] numbers = new int[10];

        Console.WriteLine("Lütfen 10 tane sayı giriniz\n");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int min = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        Console.WriteLine($"Girilen sayılar içerisindeki en küçük sayı: " + min);
    }

    static void project2()
    {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

        Console.Write("Aranacak sayıyı giriniz: ");
        int search = Convert.ToInt32(Console.ReadLine());

        int index = Array.IndexOf(numbers, search);

        if (index != -1)
        {
            Console.WriteLine($"Sayı {search} bulundu. İndeksi: {index}");
        }
        else
        {
            Console.WriteLine($"Sayı {search} dizide bulunamadı.");
        }
    }
}
