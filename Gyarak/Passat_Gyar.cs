using SzTT_HF_2_UBMX0L.Alkatreszek;
using SzTT_HF_2_UBMX0L.Passat_Alkatreszek;

namespace SzTT_HF_2_UBMX0L.Gyarak
{
    public class Passat_Gyar :  Autogyar
    {
        public Karosszeria CreateKarosszeria() => new Passat_Karosszeria();

        public Kormanymu CreateKormanymu() => new Passat_Kormanymu();
        public Motor CreateMotor() => new Passat_Motor();
    }
}
