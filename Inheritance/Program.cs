namespace Inheritance
{
    internal class Program
    {


        class Jarmu 
        {
            public Jarmu(int sebesseg)
            {
                Sebesseg = sebesseg;
            }

            public int Sebesseg { get; set; }
            public virtual void Gyorsul(int gyorsulas)
            {
                Sebesseg += gyorsulas;
            }

        }
        /*Az autó egy jármű*/
        class Auto : Jarmu
        {
            public Auto(int sebesseg, int ajtokSzama) : base(sebesseg)
            {
                AjtokSzama = ajtokSzama;
            }

            public override void Gyorsul(int gyorsulas)
            {
                base.Gyorsul(gyorsulas);
                Console.WriteLine("Az autó gyorsul");
            }

            public int AjtokSzama { get; set; }
        }

        class Repulo : Jarmu
        {
            public Repulo(int sebesseg, int szarnyFesztav) : base(sebesseg)
            {
                SzarnyFesztav = szarnyFesztav;
            }
            public int SzarnyFesztav { get; set; }
            sealed  override public  void Gyorsul(int gyorsulas)
            {
                Sebesseg += gyorsulas * 2;
                Console.WriteLine("A repülő gyorsul");
            }
            /*
            public new void Gyorsul(int gyorssulas) 
            {
                Console.WriteLine("A repülő repül");
            }*/
        }


        static void Main(string[] args)
        {
            Jarmu repulo = new Repulo(0, 20);
            Auto auto = new Auto(0, 4);

            List<Jarmu> jarmuvek = new List<Jarmu>();
            jarmuvek.Add(repulo);
            jarmuvek.Add(auto);

            foreach (Jarmu jarmu in jarmuvek)
            {
                jarmu.Gyorsul(10);
                Console.WriteLine($"Jármű sebessége: {jarmu.Sebesseg}");
            }

        }
    }
}
