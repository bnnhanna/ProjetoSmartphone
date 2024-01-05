namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} pela loja de aplicativos do {Modelo}.");
        }

        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Smartphone: {Modelo}");
            Console.WriteLine($"Ligando...");
            Console.WriteLine($"Instalando o JogoDaCobrinha");
        }
    }
}

