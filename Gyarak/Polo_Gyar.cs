using SzTT_HF_2_UBMX0L.Alkatreszek;
using SzTT_HF_2_UBMX0L.Polo_Alkatreszek;

namespace SzTT_HF_2_UBMX0L.Gyarak
{
    public class Polo_Gyar : Autogyar
    {
        public Karosszeria CreateKarosszeria() => new Polo_Karosszeria();

        public Kormanymu CreateKormanymu() => new Polo_Kormanymu();
        public Motor CreateMotor() => new Polo_Motor();
    }
}
