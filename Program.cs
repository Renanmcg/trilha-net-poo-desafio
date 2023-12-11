using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Criar instância de Nokia
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI123", 16);

            // Testar métodos da classe Nokia
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Criar instância de Iphone
            Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI456", 128);

            // Testar métodos da classe Iphone
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine(); // Aguardar pressionamento de tecla para fechar a aplicação
        }
    }
}
