namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Construtor
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Construtor da classe base é chamado para inicializar as propriedades
        }

        // Implementação do método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone {Modelo}...");
        }
    }
}
