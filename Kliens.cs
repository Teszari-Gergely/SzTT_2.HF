using System;
using System.Collections.Generic;
using SzTT_HF_2_UBMX0L.Gyarak;
using SzTT_HF_2_UBMX0L.Alkatreszek;

namespace SzTT_HF_2_UBMX0L
{
    class Kliens
    {
        private Karosszeria ka;
        private Kormanymu ko;
        private Motor mo;
        private Autogyar gyar;

        public void GyarBeallit(Autogyar gy)
        {
            gyar = gy;
        }

        public List<Auto> GyarFuttat(int times)
        {
            List<Auto> ret = new List<Auto>();
            int counter = 0;
            while (true)
            {
                var ka = gyar.CreateKarosszeria();
                var ko = gyar.CreateKormanymu();
                var mo = gyar.CreateMotor();
                try
                {
                    var temp = Osszerak(ka, ko, mo);
                    if (temp != null)
                    {
                        counter++;
                        ret.Add(temp);
                    }
                }
                catch (Exception E)
                {
                    Riaszto.GetInstance().Teszt(E.Message);
                }
                if (counter == times) break;
            }
            return ret;
        }

        public Auto Osszerak(Karosszeria ka, Kormanymu ko, Motor mo)
        {
            if (ka.sikerult < 20) {
                throw new Exception("Hibás alkatrész!");
            }
            Console.WriteLine($"Sikeres alkatrészgyártás: {ka}");
            if (ko.sikerult < 20)
            {
                throw new Exception("Hibás alkatrész!");
            }
            else
            Console.WriteLine($"Sikeres alkatrészgyártás: {ko}");
            if (mo.sikerult < 20)
            {
                throw new Exception("Hibás alkatrész!");
            }
            else
            Console.WriteLine($"Sikeres alkatrészgyártás: {mo}");

            var auto = new Auto(ka, ko, mo);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(auto);
            Console.ForegroundColor = ConsoleColor.White;
            return auto;
        }
    }
}
