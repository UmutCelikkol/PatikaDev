using System;
namespace hazir_metotlar_datetime_math;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("*****************DATETIME LIBRARY********************");
        //Datetime Kutuphanesi
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);
        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);
        Console.WriteLine(DateTime.Now.TimeOfDay);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        // Su anki tarihe ve saate ekler
        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        //Datetime Format
        Console.WriteLine(DateTime.Now.ToString("dd")); // gunu getirir
        Console.WriteLine(DateTime.Now.ToString("ddd")); // saturday yerine sat getirir.
        Console.WriteLine(DateTime.Now.ToString("dddd")); // saturday getirir.
        Console.WriteLine(DateTime.Now.ToString("MM")); // 04 getirir (bulundugun ay)
        Console.WriteLine(DateTime.Now.ToString("MMM")); // April yerine Apr getirir
        Console.WriteLine(DateTime.Now.ToString("MMMM")); // April getirir.
        Console.WriteLine(DateTime.Now.ToString("ddd")); // saturday yerine sat getirir.
        Console.WriteLine(DateTime.Now.ToString("yy")); // 2023 yerine 23 getirir.
        Console.WriteLine(DateTime.Now.ToString("yyy")); // 2023 olarak getirir.

        Console.WriteLine("*****************MATH LIBRARY********************");
        //Math Kutuphanesi
        Console.WriteLine(Math.Abs(-25)); //Mutlak degeri alir 25 getirir.
        Console.WriteLine(Math.Sin(10)); //sinus hesabi yapar
        Console.WriteLine(Math.Cos(10)); //cosinus hesabi yapar
        Console.WriteLine(Math.Tan(10)); //tanjant alir.

        Console.WriteLine(Math.Ceiling(22.3)); //23'e tamamlar tavana tamamlar
        Console.WriteLine(Math.Round(22.3)); //22'ye tamamlar. hangisine daha yakinsa ona tamamlar
        Console.WriteLine(Math.Round(22.7)); //23'ye tamamlar. hangisine daha yakinsa ona tamamlar
        Console.WriteLine(Math.Floor(22.3)); //22'ye tamamlar. hangisine daha yakinsa ona tamamlar

        Console.WriteLine(Math.Pow(3,4)); //3 ussu 4u verir
        Console.WriteLine(Math.Sqrt(4)); //4"un karekoku olan 2yi verir
        Console.WriteLine(Math.Log(10)); //10"un e tabanindaki logaritmik karsiligini verir
        Console.WriteLine(Math.Exp(3)); //e uzeri 3"u verir
        Console.WriteLine(Math.Log10(10)); //10"un 10 tabanindaki logaritmik karsiligini verir



        
        
        
        







    }
}
