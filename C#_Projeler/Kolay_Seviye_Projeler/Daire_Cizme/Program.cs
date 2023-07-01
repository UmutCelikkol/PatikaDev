using System;
//Kullanıcıdan alınan yarıçapa göre console'a Daire çizen uygulamayı yazınız.

namespace Daire_Cizme;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Daire cizme uygulamasina hosgeldiniz!");
        double yaricap;
        //yaricap girilene kadar tekrar et:
        do
        {
            Console.WriteLine("Dairenin yaricapini giriniz: ");
        } while (!double.TryParse(Console.ReadLine(),out yaricap) || yaricap <= 0);
        Daire daire = new Daire();
        daire.Ciz(yaricap);
        Console.WriteLine("Cizim tamamlandi. Cikmak icin bir tusa basiniz.");
        Console.ReadLine();
    }
}

class Daire
{
    public void Ciz(double yaricap){
        int cevre = (int)(2 * Math.PI * yaricap);
        int alan = (int)(Math.PI* yaricap *yaricap);
        int yaricapRounded = (int)yaricap;

        Console.WriteLine($"Yaricapi {yaricapRounded} olan dairenin cevresi: {cevre}");
        Console.WriteLine($"Yaricapi {yaricapRounded} olan dairenin alani: {alan}");

            int genislik = yaricapRounded * 2;
            int yukseklik = yaricapRounded;

            double oran = (double)genislik / (double)yukseklik;

            for (int y = -yaricapRounded; y <= yaricapRounded; y++)
            {
                for (int x = -yaricapRounded; x <= yaricapRounded; x++)
                {
                    double mesafe = (x * x) + (y * y * oran * oran);

                    if (Math.Abs(mesafe - (yaricap * yaricap)) <= yaricap)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
        }
    }
}