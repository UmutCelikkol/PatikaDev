using System;
//Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan. Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran csharp console uygulamasını yazınız.

namespace Mutlak_Kare_Alma;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Sayilari giriniz. Sayilari girerken aralaria bosluk birakiniz: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(" ");
            int[] numbers2 = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers2[i] = Convert.ToInt32(numbers[i]); // string aldigimiz her numaraya yeni bir int diziye atadik.
            }

            int smallerTotal = 0;
            int largerTotal = 0;

            foreach (int number in numbers2)
            {
                int fark = Math.Abs(number-67); // Mutlak deger ile 67 sayisina gore farklari topluyoruz.

                if (number<67)
                {
                    smallerTotal += fark;
                }
                else
                {
                    largerTotal += fark* fark; // Farkin karesini alip buyuk sayilardaki toplame ekledik.
                }
            }
            Console.WriteLine($"Kucuk olanlarin farklarinin toplami: {smallerTotal} ");
            Console.WriteLine($"Buyuk olanlarin farklarinin mutlak karelerinin toplami: {largerTotal} ");
            break;
        } while (true);
    }
}
