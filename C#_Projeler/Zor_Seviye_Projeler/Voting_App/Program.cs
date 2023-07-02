using System;
using System.Collections.Generic;
using System.Linq;
// Voting Uygulaması
// Uygulama çalıştığında pre-defined olarak belirlenen kategoriler oylamaya sunulmak üzere listelenmelidir. Yalnızca sisemde kayırlı olan kullanıcılar oy verebilir. Oylama sırasında öncelikle kullanıcının username'i istenmelidir. Eğer sistemde kayıtlı değilse kayıt olmasına imkan sağlanmalı ve kaldığı yerden oylamaya devam edebilmelidir. Kategoriler isteğe bağlı olarak belirlenebilir.
//Bazı Örnek Kategoriler: Film Kategorileri Tech Stack Kategorileri Spor Kategorileri
//Son olarak uygulama sonlandırılırken, Voting sonuçları hem rakamsal hem de yüzdesel olarak gösterilmelidir.

namespace Voting_App;

class Program
{
    static Dictionary<string, int> votingResults = new Dictionary<string, int>();
        
    static void Main(string[] args)
    {
        // Pre-defined kategorileri oluşturalim.
        List<string> categories = new List<string>{
            "Film Kategorileri", "Spor Kategorileri", "Muzik Kategorileri" , "Yazilim Kategorileri"};
        Console.WriteLine("Voting Uygulamasina Hosgeldiniz!");
        while (true)
        {
            Console.WriteLine("\nMevcut Kategoriler: ");
            PrintCategories(categories);
            Console.WriteLine("\nLutfen oy vermek istediginiz kategorinin adini giriniz. Oylamadn cikarak sonuclari gormek icin 'exit' yaziniz.");
            string category = Console.ReadLine();
            if (category.ToLower() == "exit")
            {
                break;
            }
            if (!categories.Contains(category))
            {
                Console.WriteLine("Gecersiz bir kategori girdiniz. Lutfen tekrar bir kategori adi yaziniz");
                continue;
            }
            Console.WriteLine("Lutfen kullanici adinizi giriniz:");
            string username = Console.ReadLine();
            int voteCount =0;
            if (votingResults.ContainsKey(category))
            {
                voteCount = votingResults[category];
            }
            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Gecersiz kullanici adi girdiniz. Lutfen tekrar kullanic adinizi giriniz: ");
                continue;
            }
            if (!votingResults.ContainsKey(category))
            {
                votingResults.Add(category,1);
            }
            else{
                votingResults[category] = voteCount+1;
            }
            Console.WriteLine("Oy verildi! Teşekkür ederiz, devam edebilirsiniz.");

        }
        Console.WriteLine("\nVoting Sonuçları:");
        PrintResults();

        Console.WriteLine("\nProgram sonlandırıldı. Çıkmak için bir tuşa basın...");
        Console.ReadKey();

    }

    static void PrintCategories(List<string> categories)
    {
        Console.WriteLine(" ");
        foreach (string category in categories)
        {
            Console.WriteLine("- "+ category);
        }
    }
    static void PrintResults()
    {
        foreach (KeyValuePair <string, int> result in votingResults)
        {
            Console.WriteLine(result.Key + ": " + result.Value + " adet oy aldi.");
        }
        Console.WriteLine("\nYüzdesel Sonuçlar:");
        foreach (KeyValuePair<string, int> result in votingResults)
        {
            double percentage = (double)result.Value / votingResults.Values.Sum() * 100;
            Console.WriteLine(result.Key + ": %" + Math.Round(percentage, 2));
        }
    }
}
