using System;

namespace OOP_interface;

class Program
{
    static void Main(string[] args)
    {
        //Interface (Arayüzler)
        // Interface yani arayüzler nesneye dayalı programlamanın önemli özelliklerinden biridir. Sınıfların içermesi gereken metotların imzalarının yer aldığı, özelliklerin tanımlandığı bir taslak gibi düşünebiliriz.
        // Kesin belirlenmiş bir kural olmamasıyla beraber interface isimleri "I" ile başlar. I ile başlayan bir isim gördüğümüzde kolaylıkla bunun bir arayüz olduğunu anlarız. Dolayısıyla standartlara bağlı kalmakta fayda var.
        // Interface içerisindeki property'lere bir değer ataması yapılmaz, metotların ise gövdesi yazılmaz. Sadece implemente eden sınıfın ne iş yaptığının bir arayüzüdür interface'ler. Ve bir sınıf aynı anda birden fazla arayüzden kalıtım alabilir.
        // Peki interface'lere neden ihtiyaç duyarız? Kalıtım alan sınıfın sorumluluğunun çerçevesinin çizilmesine yardımcı olur diyebilir. Aynı sorumluluğu başka bir yoğurt yiyiş tarzıyla yapması gereken bir sınıf geldiğinde aynı interface den kalıtım alır ama yapacağı işi farklı şekilde yapar.

        FileLogger fileLogger = new FileLogger();
        fileLogger.WriteLog();
        DatabaseLogger databaseLogger= new DatabaseLogger();
        databaseLogger.WriteLog();
        SmsLogger smsLogger= new SmsLogger();
        smsLogger.WriteLog();

        ///bunun yerine:

        LogManager logManager = new LogManager(new FileLogger());
        logManager.WriteLog();
        LogManager logManager2 = new LogManager(new DatabaseLogger());
        logManager2.WriteLog();
         LogManager logManager3 = new LogManager(new SmsLogger());
        logManager3.WriteLog();


        //Bir diger Otomobil ornegi:
        Focus focus = new Focus();

        Console.WriteLine(focus.HangiMarkaninAraci().ToString());
        Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
        Console.WriteLine(focus.StandartRengiNe().ToString());
        
        Civic civic = new Civic();

        Console.WriteLine(civic.HangiMarkaninAraci().ToString());
        Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
        Console.WriteLine(civic.StandartRengiNe().ToString());

        Corolla corolla = new Corolla();

        Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
        Console.WriteLine(corolla.KacTekerlektenOlusur().ToString());
        Console.WriteLine(corolla.StandartRengiNe().ToString());

        //Bir diger Abstraction ile Otomobil Ornegi
        NewFocus newFocus = new NewFocus();

        Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
        Console.WriteLine(newFocus.KacTekerlektenOlusur().ToString());
        Console.WriteLine(newFocus.StandartRengiNe().ToString());
        
        NewCivic newCivic = new NewCivic();

        Console.WriteLine(newCivic.HangiMarkaninAraci().ToString());
        Console.WriteLine(newCivic.KacTekerlektenOlusur().ToString());
        Console.WriteLine(newCivic.StandartRengiNe().ToString());

        NewCorolla newCorolla = new NewCorolla();

        Console.WriteLine(newCorolla.HangiMarkaninAraci().ToString());
        Console.WriteLine(newCorolla.KacTekerlektenOlusur().ToString());
        Console.WriteLine(newCorolla.StandartRengiNe().ToString());

    }
}
