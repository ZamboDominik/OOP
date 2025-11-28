namespace Polymorphism
{
    internal class Program
    {
        public class A
        {
            public int Szam = 10;
        }

        public class B : A
        {
            public new int Szam = 20; 

            public void Kiir()
            {
                Console.WriteLine(Szam);       
                Console.WriteLine(base.Szam);  
            }
        }

        public class Vektor
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Vektor(int x, int y)
            {
                X = x;
                Y = y;
            }

            public static Vektor operator + (Vektor a, Vektor b)
            {
                return new Vektor(a.X + b.X, a.Y + b.Y);
            }

            public static Vektor operator *(Vektor v, int szorzo)
            {
                return new Vektor(v.X * szorzo, v.Y * szorzo);
            }

            override public string ToString()
            {
                return $"({X}, {Y})";
            }
        }
        static void Main(string[] args)
        {
         Vektor v1 = new Vektor(2, 3);
         Vektor v2 = new Vektor(4, 5);
            Console.WriteLine(v1+v2);
           object
        }
    }
}
