using System;
class Dados
{
    public static void Main(string[] args)
    {
        // Tipos de dados 
        // Tipos Numericos

        int n1 = 12; // tipo inteiros 
        double n2 =  3.4; // tipo ponto flutuante
        string s1 = " Santiago"; // Tipo texto
        char c1 = '@'; // tipo de valor unitario na memoria
        bool ehPar = (n1 % 2 == 0);

        if(ehPar == true)
        {
            Console.WriteLine("O número é par");
        } else
        {
            Console.WriteLine("O número é impar");
        }
        
        //Console.WriteLine("Tipos de dados inteiros " +n1+ " Tipo INT");
        //Console.WriteLine("Tipos de dados de ponto flutuante " +n2+ " Tipo DOUBLE");
        //Console.WriteLine("Tipos de dados texto " +s1+ " Tipo STRING");
        //Console.WriteLine("Tipos de dados com valor unitario por memoria " +c1+ " Tipo CHAR");
        
        // Formatando saida de variaveis
        //Console.WriteLine($"{n1},{n2},{s1},{c1}");
        Console.WriteLine(ehPar);
    }
}
