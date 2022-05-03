
using System.Net;

class Cviceni1

{
    static void Main(string[] args)
    {
        Adresa();
        Console.WriteLine("-----------------------------");
        Abeceda();
        Console.WriteLine("-----------------------------");
        RodneCislo();
        Console.WriteLine("-----------------------------");
        HadaniCisla();
        //Console.WriteLine("-----------------------------");
        //PocasiAPI();
        Console.WriteLine("-----------------------------");
        Console.WriteLine("KONEC");
    }

    private static void Adresa()
    {
        String jmeno, prijmeni, Adresa, mesto, PSC;
        jmeno = "Josef";
        prijmeni = "Novák";
        Adresa = "Jindřišská 16";
        mesto = "Praha 1";
        PSC = "111 50";

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("{0} {1}\n{2}\n{3}, {4}", jmeno, prijmeni, Adresa, PSC, mesto);




    }
    private static void Abeceda()
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        for (int i = 0; i < alpha.Length; i++)
        {
            Console.WriteLine(alpha[i]);
        }

    }
    private static void RodneCislo()
    {
        Console.WriteLine("Zadejte rodne cislo, u ktereho se zjisti pohlavi: ");
        String rodneCislo = Console.ReadLine();
        String sub = rodneCislo.Substring(2, 2);
        int number = int.TryParse(sub, out int result) ? result : 0;
        if (number > 50)
        {
            Console.WriteLine("Jedná se o ženu.");
        }
        else if (result == 0)
        {
            Console.WriteLine("Zadané rodné číslo neodpovídá standartnímu formátu.");
        }
        else
        {
            Console.WriteLine("Jedná se o muže.");
        }
    }
    private static void HadaniCisla()
    {
        Random rnd = new Random();
NovaHra:
        int hadaneCislo = rnd.Next(0, 101);
        int tip = 102;
        int pocetPokusu = 0;
        while (tip != hadaneCislo && pocetPokusu < 11)
        {
            Console.WriteLine("Tipněte číslo: (od 0 do 100)");
            tip = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
            pocetPokusu++;
            if (tip < hadaneCislo)
            {
                Console.WriteLine("Hadejte výše.");
            }
            else if (tip == hadaneCislo)
            {
                continue;
            }
            else
            {
                Console.WriteLine("Hadejte níže.");
            }
        }
        if (pocetPokusu < 11)
        {
            Console.WriteLine("Uhodli jste číslo!!! (" + tip + ")");
        }
        else
        {
            Console.WriteLine("Bohužel jste nestihl uhodnout číslo ani v 10 pokusu.");
        }
        Console.WriteLine("Chcete hrát znovu? Y / N");
        if (Console.ReadLine().ToLower().Equals("y"))
        {
            goto NovaHra;
        }
    }

    private static void PocasiAPI()
    {
        
        WebClient wc = new WebClient();
        String urlData = wc.DownloadString("http://api.met.no/weatherapi/locationforecast/2.0/compact?altitude=237&lat=50&lon=16");
        Console.WriteLine(urlData);

    }

}