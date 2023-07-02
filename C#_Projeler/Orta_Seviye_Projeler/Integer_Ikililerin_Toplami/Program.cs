using System;
//Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, sayılar aynıysa toplamının karesini ekrana yazdıran csharp console uygulamasını yazınız.

namespace Integer_Ikililerin_Toplami;

class Program
{
    static void Main(string[] args)
    {

        do
        {
            Console.WriteLine("Sayilari giriniz. Sayilari girerken aralaria bosluk birakiniz: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(" ");
     
            if (numbers.Length % 2 != 0)
            {
                Console.WriteLine("Hatalı giriş! Çift sayıda sayı girmelisiniz.");
            }else
            {
                for (int i = 0; i < numbers.Length; i+=2)
                {
                    int firstNumber = int.Parse(numbers[i]);
                    int secondNumber = int.Parse(numbers[i+1]);
                    int sum = firstNumber +secondNumber;
                    if (firstNumber !=secondNumber)
                    {
                        Console.Write(sum+" ");
                    }
                    else
                    {
                        Console.Write(Math.Pow((double)sum,2)+" ");
                    }
                }
                Console.WriteLine();
                break;
            }
        } while (true);
       
    }
}
