using Exercicio___03;

Produto produto1 = new Produto(1655, "Assim que Acaba", 55, 50, 63 );

Console.WriteLine("O código do produto é: " + produto1.Codigo);
Console.WriteLine("O nome do produto é: " + produto1.Nome);
Console.WriteLine("O preço do produto é: " + produto1.Preco);
Console.WriteLine("A quantidade em estoque é: " + produto1.Estoque);
produto1.ValorEstoque();


Produto produto2 = new Produto(8104, "Assim que Começa", 68, 20, 70);

Console.WriteLine("O código do produto é: " + produto2.Codigo);
Console.WriteLine("O nome do produto é: " + produto2.Nome);
Console.WriteLine("O preço do produto é: " + produto2.Preco);
Console.WriteLine("A quantidade em estoque é: " + produto2.Estoque);
produto2.ValorEstoque();

Produto produto3 = new Produto(4463, "Verity", 44, 80, 60);

Console.WriteLine("O código do produto é: " + produto3.Codigo);
Console.WriteLine("O nome do produto é: " + produto3.Nome);
Console.WriteLine("O preço do produto é: " + produto3.Preco);
Console.WriteLine("A quantidade em estoque é: " + produto3.Estoque);
produto3.ValorEstoque();

Console.ReadKey();