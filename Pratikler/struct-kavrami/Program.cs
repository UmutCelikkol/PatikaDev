using System;

namespace struct_kavrami;

class Program
{
    static void Main(string[] args)
    {
        // Class"lar referans tipindedir.
        // Struct"lar ancak deger tipindedir.
        //Yapıların özellikleri:
       // Class lar referans tipli özellikler gösterir,        Yapılar ise değer tipli özellikler gösterirler. En        temel fark budur.
       // Diğer struct ya da sınıflardan kalıtım almazlar.
       // Interface'lerden kalıtım alabilirler.
       // new anahtar sözcüğü ile nesneleri yaratılabilir.
       // Sınıflar gibi metot, property ve field'lardan        oluşurlar.
       // Sınıf içerisinde struct, struct içerisinde de        sınıf oluşturulabilir.
       // Static üye barındırabilirler.
        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.KisaKenar =3;
        dikdortgen.UzunKenar =4;
        Console.WriteLine("Class alan hesabi :{90}",dikdortgen.AlanHesapla());

        Dikdortgen_Struct dikdortgen_struct; // = new Dikdortgen_Struct(); // Goruldugu uzere instance yaratmadan ilgili metodlari cagirabiliyoruz

        dikdortgen_struct.KisaKenar =3;
        dikdortgen_struct.UzunKenar =4;
        Console.WriteLine("Class alan hesabi :{90}", dikdortgen_struct.AlanHesapla());    

    }
}
class Dikdortgen
{
    public int KisaKenar;
    public int UzunKenar;

    public Dikdortgen()
    {
        KisaKenar =3;
        UzunKenar =4;
    }
    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}
struct Dikdortgen_Struct
{
    public int KisaKenar;
    public int UzunKenar;
    public Dikdortgen_Struct()
    {
        KisaKenar =3;
        UzunKenar =4;
    }
    public long AlanHesapla()
    {
        return this.KisaKenar * this.UzunKenar;
    }
}