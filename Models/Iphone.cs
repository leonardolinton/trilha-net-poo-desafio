namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // DONE: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp}, no celular Iphone");
        }
    }
}