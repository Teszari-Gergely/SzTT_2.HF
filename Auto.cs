using SzTT_HF_2_UBMX0L.Alkatreszek;

namespace SzTT_HF_2_UBMX0L
{
    public class Auto
    {
        protected Karosszeria ka;
        protected Kormanymu ko;
        protected Motor mo;
        public Auto(Karosszeria ka, Kormanymu ko, Motor mo)
        {
            this.ka = ka;
            this.ko = ko;
            this.mo = mo;
        }

        public override string ToString()
        {
            return $"Autó: {this.ka}, {this.ko}, {this.mo}";
        }
    }
}
