using System;

namespace OOP_polymorphism_sealed_class;

class Program
{
    static void Main(string[] args)
    {
        // OOP-POLYMORPHISM

       //Canlilar-Hayvanlar-Bitkiler

       TohumluBitkiler tohumluBitki =new TohumluBitkiler();
       tohumluBitki.TohumlaCogalma();

       Console.WriteLine("***************");

       Kuslar marti =new Kuslar();
       marti.Ucmak();
    }
}
