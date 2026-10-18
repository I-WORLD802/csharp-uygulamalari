// uygulama 2
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> liste = new List<string>();
        liste.Add("10");
        liste.Add("20");
        liste.Add("30");

        Console.WriteLine(NumaraVarMi(liste, "10"));
        Console.WriteLine(NumaraVarMi(liste, "30"));
        Console.WriteLine(NumaraVarMi(liste, "50"));

        List<string> bosListe = new List<string>();
        Console.WriteLine(NumaraVarMi(bosListe, "10"));
    }

    static bool NumaraVarMi(List<string> liste, string aranan)
    {
        foreach (string item in liste)
        {
            if (item == aranan)
            {
                return true;
            }
        }
        return false;
    }
}