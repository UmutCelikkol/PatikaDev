using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args){
            Console.WriteLine("İsminizi Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Hoşgeldin "+name+" "+surname);
        }
    }
}
