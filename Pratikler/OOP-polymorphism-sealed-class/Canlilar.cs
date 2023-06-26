using System;

namespace OOP_polymorphism_sealed_class;

//sealed yazilir Canlilar sinifi kalitim veremez
// virtual bir alt sinifta override ile degistirilebilir
public class Canlilar
{
    protected void Beslenme(){
        Console.WriteLine("Canlilar beslenir");
    }
    protected void Solunum(){
        Console.WriteLine("Canlilar solunum yapar");
    }
    protected void Bosaltim(){
        Console.WriteLine("Canlilar bosaltim yapar");
    }
    public virtual void UyaranlaraTepki(){
        Console.WriteLine("Canlilar uyaranlara tepki verir");
    }
}