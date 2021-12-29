using System;

namespace _02Métodos
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Instanciando objeto

            Pessoa obj = new Pessoa();
            obj.apresentar("Pedro", 32);
            obj.somar(5, 9);
             int a = 7;
             int b = 3;
            
            if(a>= b)
                {
                    Console.WriteLine("A é maior do que B");
                }else
                {
                
                    Console.WriteLine("A não é maior do que B");
                }

                

        }
    }
}
