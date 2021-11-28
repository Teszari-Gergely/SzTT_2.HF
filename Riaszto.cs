using System;

namespace SzTT_HF_2_UBMX0L
{
    class Riaszto
    {
        private static Riaszto instance;
        public static Riaszto GetInstance()
        {
            if (instance == null) instance = new Riaszto();
            return instance;
        }
        protected Riaszto() { }
        public void Teszt( string E )
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine(E);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
