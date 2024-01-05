using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // SmartPhone Nokia:
            Nokia nokia = new Nokia("123456", "Nokia 3310", "123ABC", 16);
            Console.WriteLine($"Nokia");
            nokia.Ligar();
            nokia.InstalarAplicativo("JogoDaCobrinha");

            Console.WriteLine(); 

            // Smartphone Iphone:
            Iphone iphone = new Iphone("789012", "iPhone 12", "456DEF", 64);
            Console.WriteLine($"Iphone:");
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Twitter");
        }
    }
}
