using System;

namespace encapsulation;

class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Ayse";
        ogrenci.Soyisim = "Yilmaz";
        ogrenci.OgrenciNo = 293;
        ogrenci.Sinif =3;
        ogrenci.OgrenciBilgleriniGetir();
        ogrenci.SinifAtlat();
        ogrenci.OgrenciBilgleriniGetir();
        Ogrenci ogrenci2 = new Ogrenci("Deniz","Arda",242,1);
        ogrenci2.SinifDusur();
        ogrenci2.SinifDusur();
        ogrenci2.OgrenciBilgleriniGetir();

    }
}

class Ogrenci{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;
    //Property'ler
    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif 
    { 
        get => sinif; 
        set{
            if (value<1)
            {
                Console.WriteLine("Sinif en az 1 olabilir!");
                sinif =1;
            }else{
                sinif=value;
            }
    
        } 
    }

    public Ogrenci (string isim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci(){}

    public void OgrenciBilgleriniGetir(){
       Console.WriteLine("********** Ogrenci Bilgileri ***********");
       Console.WriteLine("Ogrenci Adi     :{0}", this.Isim);
       Console.WriteLine("Ogrenci Soyadi  :{0}", this.Soyisim); 
       Console.WriteLine("Ogrenci No      :{0}", this.OgrenciNo); 
       Console.WriteLine("Ogrenci Sinifi  :{0}", this.Sinif); 
    }
    public void SinifAtlat(){
        this.Sinif +=1;
    }
    public void SinifDusur(){
        this.Sinif -=1;
    }
}