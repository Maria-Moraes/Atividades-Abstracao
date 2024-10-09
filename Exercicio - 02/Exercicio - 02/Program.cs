using Exercicio___02;

Aluno aluno1 = new(1994, "Maria Luiza Pereira de Moraes", (new DateTime(2007, 8, 13)), "maria.moraes14@portalsesisp.org.br");

Console.WriteLine("O RM do aluno é: " + aluno1.RM);
Console.WriteLine("O nome do aluno é: " + aluno1.Nome);
Console.WriteLine("A data de nascimento do aluno é: " + aluno1.Nascimento);
Console.WriteLine("O Emaildo aluno é: " + aluno1.Email);

Aluno aluno2 = new(2021, "Natalia Buzaranho", (new DateTime(2007, 9, 11)),"natalia.buzaranho@portalsesisp.org.br");

Console.WriteLine("O RM do aluno é: " + aluno2.RM);
Console.WriteLine("O nome do aluno é: " + aluno2.Nome);
Console.WriteLine("A data de nascimento do aluno é: " + aluno2.Nascimento);
Console.WriteLine("O Emaildo aluno é: " + aluno2.Email);

Aluno aluno3 = new(2782, "Bia dos Santos Fonseca", (new DateTime(2007, 10, 28)), "bia.fonseca@portalsesisp.org.br");

Console.WriteLine("O RM do aluno é: " + aluno3.RM);
Console.WriteLine("O nome do aluno é: " + aluno3.Nome);
Console.WriteLine("A data de nascimento do aluno é: " + aluno3.Nascimento);
Console.WriteLine("O Emaildo aluno é: " + aluno3.Email);

Console.ReadKey();