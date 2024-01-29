using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // SmartPhone Nokia:
            Nokia nokia = new Nokia("123456", "Nokia 3310", "123ABC", 16);
            nokia.InstalarAplicativo("JogoDaCobrinha", "Windows Store");
            nokia.Ligar(); 

            Console.WriteLine(); 

            // Smartphone Iphone:
            Iphone iphone = new Iphone("789012", "iPhone 12", "456DEF", 64);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Twitter", "Apple Store");
           
           Console.WriteLine(nokia);
           Console.WriteLine(iphone);
            

            
        }
    }
}
