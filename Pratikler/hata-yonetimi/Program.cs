using System;

namespace hata_yonetimi;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmis oldugunuz sayi:"+sayi);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata:"+ex.Message.ToString());
        }
        // finally{
        //     Console.WriteLine("Islem tamamlandi");
        // }
        try
        {
            //int a = int.Parse(null);
            //int a = int.Parse("test");
            int a = int.Parse("-200000000000000");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Bos deger girdiniz.");
            Console.WriteLine(ex);
        }
        catch(FormatException ex){
            
            Console.WriteLine("Veri tipine uygun degil");
            Console.WriteLine(ex);
        }
        catch(OverflowException ex){
            Console.WriteLine("Cok kucuk veya cok buyuk bir sayi girdiniz");
            Console.WriteLine(ex);

        }
    }
}
