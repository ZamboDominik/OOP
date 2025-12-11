using System.Runtime.CompilerServices;

namespace Abstraction
{
    internal class Program
    {
        public interface IAlakzat
        {
            //string Name//{get;set;}
            double Terulet();
            double Kerulet();

            virtual void PrintInfo()
            {
                Console.WriteLine("Alakzat info");
            }

        }
        public abstract class Alakzat
        {
            public abstract double Terulet();
            public abstract double Kerulet();

            public string Name;
            protected Alakzat(string name)
            {
                Name = name;
            }
        }
        public class Kor : Alakzat,IAlakzat
        {
            public double Sugar { get; set; }
            public Kor(double sugar):base("Kor")
            {
                Sugar = sugar;
            }
            public override double Terulet()
            {
                return Math.PI * Sugar * Sugar;
            }
            public override double Kerulet()
            {
                return 2 * Math.PI * Sugar;
            }
        }
        public class Negyzet : Alakzat
        {
            public double Oldal { get; set; }
            public Negyzet(double oldal):base("Negyzet")
            {
                Oldal = oldal;
            }
            public override double Terulet()
            {
                return Oldal * Oldal;
            }
            public override double Kerulet()
            {
                return 4 * Oldal;
            }
        }



        static void Main(string[] args)
        {
            Kor kor = new Kor(5);
            Negyzet negyzet = new Negyzet(4);
            Alakzat[] alakzatok = new Alakzat[] { kor, negyzet };
            foreach (Alakzat alakzat in alakzatok)
            {
                Console.WriteLine(alakzat.Name);
                
                Console.WriteLine($"Terulet: {alakzat.Terulet()}");
                Console.WriteLine($"Kerulet: {alakzat.Kerulet()}");
            }
        }
    }
}
