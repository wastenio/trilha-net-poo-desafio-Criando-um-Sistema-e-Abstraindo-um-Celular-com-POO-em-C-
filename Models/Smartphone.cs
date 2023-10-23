namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Marca { get; set; } // Propriedade adicionada
        public string Modelo { get; set; } // Propriedade adicionada

        public Smartphone(string numero, string marca, string modelo)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}