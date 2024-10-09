namespace Exercicio___04
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }

        public Carro(string marca, string modelo, int velocidade)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = velocidade;
        }

        public void Acelerar()
        {
            Console.WriteLine($"O carro da marca {Marca} acelera em 2.9s");
        }
        public void Desaceleracao()
        {
            Console.WriteLine($"O carro da marca {Marca} desacelera a {Velocidade}km/h");
        }

    }
}
