using System;
using System.Collections.Generic;
using SzTT_HF_2_UBMX0L.Gyarak;

namespace SzTT_HF_2_UBMX0L
{
    class main
    {
        public static List<Auto> autok = new List<Auto>();
        static void Main(string[] args)
        {
            Kliens k = new Kliens();
            Autogyar gyar = new Golf_Gyar();
            while (true)
            {
                k.GyarBeallit(gyar);
                autok = k.GyarFuttat(3);
                Console.WriteLine("Kész!\nÜssön be egy A betűt az újrafuttatáshoz!");
                string s = Console.ReadLine();
                if (!s.Contains("a")) break;
                Console.Clear();
            }
            ListaKiiro();
        }

        static void ListaKiiro()
        {
            foreach (Auto a in autok)
            {
                Console.WriteLine($"{a}\n\n");
            }
        }
    }
}