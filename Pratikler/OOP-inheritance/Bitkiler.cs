using System;

namespace OOP_inheritance;

public class Bitkiler:Canlilar
{
    protected void Fotosentez(){
        Console.WriteLine("Bitkiler fotosentezle beslenir");
    }
}

public class TohumluBitkiler:Bitkiler
{
    public TohumluBitkiler(){
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
        base.Fotosentez(); // base ile kalitim alinan  bir ust sinifin metoduna erisiyoruz.
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