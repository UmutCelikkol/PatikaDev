using System;

namespace OOP_inheritance;

public class Hayvanlar:Canlilar
{
    protected void Adaptasyon(){
        Console.WriteLine("Hayvanlar adaptasyon kurabilir");
    }
}

public class Surungenler:Hayvanlar
{
    public Surungenler()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }
    public void Surunmek(){
        Console.WriteLine("Surungenler surunerek hareket ederler");
    }
}
public class Kuslar:Hayvanlar
{
    public Kuslar()
    {
        base.Adaptasyon();
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }
    public void Ucmak(){
        Console.WriteLine("Kuslar ucar");
    }
}