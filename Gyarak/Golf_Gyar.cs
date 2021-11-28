using SzTT_HF_2_UBMX0L.Alkatreszek;
using SzTT_HF_2_UBMX0L.Golf_Alkatreszek;

namespace SzTT_HF_2_UBMX0L.Gyarak
{
    public class Golf_Gyar : Autogyar
    {
        public Karosszeria CreateKarosszeria() => new Golf_Karosszeria();

        public Kormanymu CreateKormanymu() => new Golf_Kormanymu();
        public Motor CreateMotor() => new Golf_Motor();
    }
}
