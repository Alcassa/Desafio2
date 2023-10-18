using Desafio2.models;

namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nokia = new Nokia("213213", "mod1", "839imei", 64);
            Console.WriteLine("Smartphone Nokia: ");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Telegram");

            Console.WriteLine();

            var iphone = new Iphone("8457", "mod2", "imei", 512);
            Console.WriteLine("Smartphone Iphone: ");
            iphone.ReceberLigacao();
            iphone.Ligar();
            iphone.InstalarAplicativo("Whatsapp");
        }
    }
}