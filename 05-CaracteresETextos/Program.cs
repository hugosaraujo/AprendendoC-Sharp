using System;
class Program 
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 5 - Caracteres e Textos");
        
        char letra = 'a';
        Console.WriteLine(letra);

        char valor = (char)65;
        Console.WriteLine(valor);

        valor = (char)(valor + 1); 
        Console.WriteLine(valor);

        string frase = "o melhor horário para a prática de exercícios é as " + 06 + " da manhã.";
        Console.WriteLine(frase);

        string listaDeLinguagens = @"Lista de linguagens de programação:
- Go;
- C#;
- Ruby;
- Python;
- Java;";
        Console.WriteLine(listaDeLinguagens);
        Console.WriteLine("Fim da execução do programa. Aperte ENTER para encerrar a reprodução");
        Console.ReadLine();
    }
}