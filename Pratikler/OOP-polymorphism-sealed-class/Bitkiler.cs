using System;

namespace OOP_polymorphism_sealed_class;

public class Bitkiler:Canlilar
{
    protected void Fotosentez(){
        Console.WriteLine("Bitkiler fotosentezle beslenir");
    }
    public override void UyaranlaraTepki()
    {
        Console.WriteLine("Bitkiler gunese tepki verir");
    }
}

public class TohumluBitkiler:Bitkiler
{
    public TohumluBitkiler(){
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
        base.Fotosentez(); // base ile kalitim alinan  bir ust sinifin metoduna erisiyoruz.
        base.UyaranlaraTepki();
    }
    public void TohumlaCogalma(){
        Console.WriteLine("Tohumlu bitkiler tohumla cogalır.");
    }
}


public class TohumsuzBitkiler:Bitkiler
{
    public TohumsuzBitkiler(){
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
        base.Fotosentez(); // base ile kalitim alinan  bir ust sinifin metoduna erisiyoruz.
    }
    public void SporlaCogalma(){
        Console.WriteLine("Tohumsuz bitkiler sporla cogalır.");
    }
}