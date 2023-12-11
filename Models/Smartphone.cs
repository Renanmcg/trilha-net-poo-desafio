using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Atributos
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        // Construtor
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos
        public void Ligar()
        {
            Console.WriteLine($"Ligando o {Modelo}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação no {Modelo}...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}

