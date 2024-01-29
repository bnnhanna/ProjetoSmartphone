namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        //encapsulamento
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }
       
        //construtor
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            
         }

        //método       
        public void Ligar()
        {
            Console.WriteLine("Acessando rede de comunicação");
            Console.WriteLine($"Ligando... Meu numero {Numero}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação... Meu numero {Numero}");
        }

        //polimorfismo
        public abstract void InstalarAplicativo(string nomeApp, string nomeLoja);
        
    }
    
}
