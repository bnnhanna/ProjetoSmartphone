namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {

        private string ModeloNokia { get; set;}
        private string NumeroNokia { get; set;}
         
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            ModeloNokia = modelo; 
            NumeroNokia = numero;
            
        }

        public override void InstalarAplicativo(string nomeApp, string loja)
        {   
            Console.WriteLine($"Abrindo loja de aplicativos {loja}");                  
            Console.WriteLine($"Instalando o aplicativo {nomeApp} pela loja de aplicativos do {ModeloNokia}.");
        }
            
        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Smartphone: {ModeloNokia}");
            Console.WriteLine($"Ligando...");
            Console.WriteLine($"Instalando o JogoDaCobrinha");
        }
    }
}

