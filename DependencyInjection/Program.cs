namespace DependencyInjection
{
    internal class Program
    {

        //webshop példa
        public interface IFizetes
        {
            void Fizetes(int osszeg);
        }

        public class BankKartya : IFizetes
        {
            public void Fizetes(int osszeg) => Console.WriteLine($"Bankkártyáról levonva: {osszeg} Ft");
        }

        public class PayPal : IFizetes
        {
            public void Fizetes(int osszeg) => Console.WriteLine($"PayPal-ról utalva: {osszeg} Ft");
        }

        public class Kartya 
        {
            int osszeg;
            public Kartya(int osszeg) 
            {
                this.osszeg = osszeg;
            }

            public void Fizetes(int mennyi) 
            {
                Console.WriteLine($"Bankkártyáról levonva: {mennyi} Ft");
                osszeg -= mennyi;

            }
        }


        public class WebshopRendeles
        {
            private readonly IFizetes _fizetesiMod;

            Kartya _kartya;

            public WebshopRendeles(IFizetes fizetesiMod)
            {
                _fizetesiMod = fizetesiMod;
            }

            public WebshopRendeles(Kartya kartya)
            {
                _kartya = kartya;
            }

            public void VasarlasBefejezese(int osszeg)
            {
                Console.WriteLine("Fizetés");
                _fizetesiMod.Fizetes(osszeg);
            }
        }


        static void Main(string[] args)
        {
            // A vevő Bankkártyát választ
            IFizetes kartya = new BankKartya();
           //hibás gondolatmenet
            WebshopRendeles rendeles = new WebshopRendeles(new Kartya(20000));


            WebshopRendeles rendeles1 = new WebshopRendeles(kartya);
            rendeles1.VasarlasBefejezese(5000);

            Console.WriteLine("---");

            // "B" eset: A vevő PayPalt választ
            IFizetes paypal = new PayPal();
            WebshopRendeles rendeles2 = new WebshopRendeles(paypal);
            rendeles2.VasarlasBefejezese(10000);
        }
    }
}
