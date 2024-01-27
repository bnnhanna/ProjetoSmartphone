namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
         
        private string Numero { get; set; }
        private string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }
       

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // tentar criar variavel receber ligação
        }

        public void Ligar()
        {
            Console.WriteLine("Acessando rede de comunicação");
            Console.WriteLine($"Ligando... Meu numero {Numero}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação... Meu numero {Numero}");
        }

        public abstract void InstalarAplicativo(string nomeApp, string nomeLoja);
    }
}
