using Exercicio___04;

Carro carro1 = new Carro("McLaren", "McLaren 720s Coupé", 341);

Console.WriteLine("A marca do carro é: " + carro1.Marca);
Console.WriteLine("O modelo do carro é: " + carro1.Modelo);
Console.WriteLine("A velocidade do carro é: " + carro1.Velocidade + "km/h");
carro1.Acelerar();
carro1.Desaceleracao();

Carro carro2 = new Carro("Mercedes", "Mercedes AMG GT", 316);

Console.WriteLine("A marca do carro é: " + carro2.Marca);
Console.WriteLine("O modelo do carro é: " + carro2.Modelo);
Console.WriteLine("A velocidade do carro é: " + carro2.Velocidade + "km/h");
carro2.Acelerar();
carro2.Desaceleracao();

Carro carro3 = new Carro("Ferrari", "Ferrari 812", 340);

Console.WriteLine("A marca do carro é: " + carro3.Marca);
Console.WriteLine("O modelo do carro é: " + carro3.Modelo);
Console.WriteLine("A velocidade do carro é: " + carro3.Velocidade + "km/h");
carro3.Acelerar();
carro3.Desaceleracao();

Console.ReadKey();