namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
            
        private string ModeloIphone { get; set;}
        private string NumeroIphone { get; set; }

        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        { 
            ModeloIphone = modelo;
            NumeroIphone = numero;
        }

        public override void InstalarAplicativo(string nomeApp, string loja)
        {
            Console.WriteLine($"Abrindo loja de aplicativos {loja}");
            Console.WriteLine($"Instalando o aplicativo {nomeApp} pela loja de aplicativos {ModeloIphone}.");
        }

        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Smartphone: {ModeloIphone}");
            Console.WriteLine($"Recebendo ligação...");
            Console.WriteLine($"Instalando o Twitter");
        }
    }
}
