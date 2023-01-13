namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        /*===== PROPRIEDADES =====*/
        public string Numero { get; set; }
        // DONE: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;

        /*===== CONSTRUTOR =====*/
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // DONE: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ExibirModelo()
        {
            Console.WriteLine($"Modelo: {Modelo}");
        }

        public void ExibirMemoriaROM()
        {
            Console.WriteLine($"Memoria: {Memoria}GB");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}