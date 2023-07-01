using System;
//Kullanıcıdan alınan boyut bilgisine göre console'a Üçgen çizen uygulamayı yazınız.


namespace Ucgen_Cizme;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ucgen cizme uygulamasina hosgeldiniz!");
        Console.WriteLine("Ucgenin boyutunu giriniz: ");
        int boyut = int.Parse(Console.ReadLine());
        Ucgen ucgen = new Ucgen(boyut);
        ucgen.Ciz();
        Console.WriteLine("Cizim tamamlandi. Cikmak icin bir tusa basiniz.");
        Console.ReadLine();

    }
}
 class Ucgen 
 {
    private int boyut;

    public Ucgen(int boyut)
    {
        this.boyut = boyut;
    }

    public void Ciz()
    {
        for (int i = 0; i < boyut; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
 }
