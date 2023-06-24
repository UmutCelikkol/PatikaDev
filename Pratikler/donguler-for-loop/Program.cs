using System;

namespace donguler_for_loop;

class Program
{
    static void Main(string[] args)
    {
        // Ekrandan girilen sayiya kadar olan tek sayilari ekrana yazdir.
        Console.WriteLine("Lutfen bir sayi giriniz!: ");
        int sayac = int.Parse(Console.ReadLine());
        for (int i = 1; i < sayac; i++)
        {
            if (i%2==1)
            {
                Console.WriteLine(i);
            }
        }
        // 1 ile 1000 arasindaki tek ve cift sayilarin toplamini ekrana yazdir.
        int tekToplam =0;
        int ciftToplam = 0;
        
        for (int i = 0; i < 1000; i++)
        {
            if (i%2 ==1)
            {
                tekToplam += i;
            }else{
                ciftToplam += i;
            }
        }
        Console.WriteLine(tekToplam +"----"+ ciftToplam);

        //break, continue
        for (int i = 0; i < 10; i++)
        {
            if (i==4)
            {
                //break;
                continue;
            }
            Console.WriteLine(i);

        }
    }
}
