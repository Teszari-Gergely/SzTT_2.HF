using System;
using SzTT_HF_2_UBMX0L.Alkatreszek;

namespace SzTT_HF_2_UBMX0L.Polo_Alkatreszek
{
    public class Polo_Motor : Motor
    {
        static Random r = new Random();
        int random = r.Next(0, 100);
        public override int sikerult => random;
    }
}
