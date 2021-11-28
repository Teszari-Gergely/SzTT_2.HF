using System;
using SzTT_HF_2_UBMX0L.Alkatreszek;

namespace SzTT_HF_2_UBMX0L.Golf_Alkatreszek
{
    public class Golf_Kormanymu : Kormanymu
    {
        static Random r = new Random();
        int random = r.Next(0, 100);
        public override int sikerult => random;
    }
}
