using System;
class Dados
{
    public static void Main(string[] args)
    {
        // Atributos, Propriedades e Escopo de Visibilidade
        Produto p1 = new Produto();
        p1.Nome = "banana";
        p1.Preco = 3.7;
        
        Console.WriteLine($"{p1.Nome} = R$ {p1.Preco:F2}");
    }

}
