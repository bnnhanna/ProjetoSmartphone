namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
         // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Numero { get; set; }
        private string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }
       
        // TODO: Passar os parâmetros do construtor para as propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        
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
