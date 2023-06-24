using System;

namespace metotlar;

class Program
{
    static void Main(string[] args)
    {
        //Metotlar
        //erisim_belirteci geri_donus_tipi metot_adi(parametreler/argumanlar)
        //{
        //   Komutlar...
        //}
        int a =2;
        int b =3;



      int sonuc = Topla(a,b);
      Metotlar ornek = new Metotlar(); // instance olusturduk
      ornek.EkranaYazdir(sonuc.ToString());
      int sonuc2 =ornek.ArttirveTopla(ref a,ref b); // referans ile a ve b'yi bellekte de degistirdi
      ornek.EkranaYazdir(sonuc2.ToString());
      ornek.EkranaYazdir((a+b).ToString());
    }
    static int Topla(int deger1, int deger2){ //call by value degeri aslinda.
        return (deger1+deger2);
    }
}

class Metotlar
{
    public void EkranaYazdir(string veri){
        Console.WriteLine(veri);
    }
    public int ArttirveTopla(ref int deger1,ref int deger2){ // call by reference demek
        deger1 +=1;
        deger2 +=2;
        return deger1 + deger2;
    }
}
