using Exercicio___01;

Livro livro1 = new Livro("Eu e Esse Meu Coração", "C. C. Hunter", "Jangada", 2018 );

Console.WriteLine("O nome do seu livro é: " + livro1.Titulo);
Console.WriteLine("A autora do livro é: " + livro1.Autor);
Console.WriteLine("A editora do livro é: " + livro1.Editora);
Console.WriteLine("O ano de lançamento é: " + livro1.Ano);

Livro livro2 = new Livro("O Ladrão de Raios - Percy Jackson e os Olimpianos", "Rick Riordan", "Miramax Books", 2005);

Console.WriteLine("O nome do seu livro é: " + livro2.Titulo);
Console.WriteLine("A autora do livro é: " + livro2.Autor);
Console.WriteLine("A editora do livro é: " + livro2.Editora);
Console.WriteLine("O ano de lançamento é: " + livro2.Ano);

Livro livro3 = new Livro("A Biblioteca da Meia-Noite", "Matt Haig", "Bertrand Brasil", 2020);

Console.WriteLine("O nome do seu livro é: " + livro3.Titulo);
Console.WriteLine("A autora do livro é: " + livro3.Autor);
Console.WriteLine("A editora do livro é: " + livro3.Editora);
Console.WriteLine("O ano de lançamento é: " + livro3.Ano);

Console.ReadKey();