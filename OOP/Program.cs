namespace OOP
{
    internal class Program
    {
        class Auto 
        {
            public int kerekek { get; set; }
            string rendszam;
            string szin;

            public string Szin 
            {
                get { return szin; }
                set { szin = value; }
            }

            public Auto(int kerekek, string rendszam, string szin)
            {
                this.kerekek = kerekek;
                this.rendszam = rendszam;
                this.szin = szin;
            }

            public void Indul()
            {
                Console.WriteLine($"A {szin} auto Rendszam:{rendszam} {kerekek} keréken megy");
            }
        }
        static void Main(string[] args)
        {
            Auto auto = new Auto(4,"ABC-123","Piros");
            Auto auto1 = new Auto(28, "XYZ-456","Fekete");
            //auto.kerekek = 5;
            auto.Szin = "Kék";
            auto.Indul();

        }
    }
}
