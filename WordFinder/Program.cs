using System;
using System.Collections.Generic;

class Program
{
    static int score = 0;

    static void Main()
    {
        List<string> WordList = new List<string>()
        {
             "açık",
    "beyaz",
    "çiçek",
    "dolap",
    "elma",
    "fare",
    "güzel",
    "havlu",
    "ıslak",
    "jandarma",
    "kapı",
    "lamba",
    "meyve",
    "nefes",
    "oğul",
    "pencere",
    "rahat",
    "saat",
    "tavuk",
    "uçak",
    "üzgün",
    "vapur",
    "yaprak",
    "zaman",
    "ağaç",
    "bina",
    "çatı",
    "düğün",
    "eğitim",
    "futbol",
    "gökyüzü",
    "hava",
    "içecek",
    "judo",
    "kedi",
    "lale",
    "meydan",
    "nohut",
    "öğrenci",
    "pasta",
    "radyo",
    "sabun",
    "tavla",
    "uçurtma",
    "üzüm",
    "vazo",
    "yağmur",
    "zil",
    "akşam",
    "balık",
    "çamaşır",
    "düğme",
    "eğlence",
    "fil",
    "gitar",
    "hamburger",
    "ipek",
    "jilet",
    "kutu",
    "lamba",
    "meyve",
    "nane",
    "ölçüm",
    "pantolon",
    "radyatör",
    "saç",
    "takvim",
    "üçgen",
    "vazo",
    "yatak",
    "zaman",
    "alman",
    "bıçak",
    "çanta",
    "dünya",
    "eldiven",
    "fasulye",
    "gitar",
    "halı",
    "ıslak",
    "jaket",
    "kadeh",
    "lamba",
    "mutfak",
    "nar",
    "okul",
    "patates",
    "rahat",
    "sandalye",
    "taksi",
    "üst",
    "veranda",
    "yakın",
    "zayıf",
    "aile",
    "büyük",
    "çalışma",
    "davul",
    "elma",
    "fırın",
    "gözlük",
    "havlu",
    "ıslak",
    "jöle",
    "kale",
    "limon",
    "meyve",
    "nohut",
    "otomobil",
    "paten",
    "radyo",
    "sardalya",
    "televizyon",
    "üzüm",
    "viyolonsel",
    "yağmur",
    "zaman",
    "ahşap",
    "buz",
    "çamur",
    "davranış",
    "elma",
    "fırça",
    "gökyüzü",
    "hasta",
    "ıspanak",
    "jokey",
    "kalem",
    "lamba",
    "mücevher",
    "nokta",
    "otobüs",
    "pasta",
    "radyo",
    "sarma",
    "tencere",
    "üzüm",
    "vapur",
    "yaban",
    "zeytin",
    "akrep",
    "buzdolabı",
    "çanta",
    "damla",
    "eğlence",
    "fener",
    "gazete",
    "harita",
    "ıslak",
    "jambon",
    "karpuz",
    "lokomotif",
    "meyve",
    "nakış",
    "oyuncak",
    "pastane",
    "radyatör",
    "sarı",
    "tarak",
    "üzüm",
    "vanilya",
    "yakıt",
    "zaman",
    "akvaryum",
    "balina",
    "çanta",
    "dondurma",
    "eşarp",
    "fırça",
    "gazete",
    "harita",
    "ıslak",
    "jant",
    "kaza",
    "labirent",
    "meyhane",
    "nakit",
    "oyuncak",
    "pasta",
    "rakı",
    "saat",
    "tavşan",




        };

           StartGame(WordList);
    }

    static void StartGame(List<string> WordList)
    {
        string randomWord = GetRandomWord(WordList);

        string displayWord = GetDisplayWord(randomWord);

        while (true)
        {
            Console.WriteLine("Try to find correct word \n \n \n" +displayWord +"\n");

            string guess = Console.ReadLine();

       
            if (guess.ToLower() == randomWord.ToLower())
            {
                score++; 
                Console.WriteLine($"\nWell done!! Your currently game score is {score}");
              
                break;
            }
            else
            {
                score--;
                Console.WriteLine($"\nUnfortunately your answer is not corrent your currently score is {score}.");
                
            }
        }

        StartGame(WordList);
    }

    static string GetRandomWord(List<string> WordList)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, WordList.Count);

        
        return WordList[randomIndex];
    }

    static string GetDisplayWord(string word)
    {
        if (word.Length == 5)
        {
            return word.Substring(0, 1) + new string('*', word.Length - 1);
        }
        else if (word.Length == 8)
        {
            return word.Substring(0, 1) + new string('*', word.Length - 2) + word.Substring(word.Length - 1);
        }
        else
        {
            string displayWord = "";
            if (word.Length % 2 == 0)
            {
                displayWord += word.Substring(0, 1);
                displayWord += new string('*', word.Length - 2);
                displayWord += word.Substring(word.Length - 1);
            }
            else
            {
                int middleIndex = word.Length / 2;
                displayWord += word.Substring(0, 1);
                displayWord += new string('*', middleIndex - 1);
                displayWord += word.Substring(middleIndex, 1);
                displayWord += word.Substring(word.Length - 1);
            }
            return displayWord;
        }
    }

}
