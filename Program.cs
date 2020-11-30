using System;

namespace Est_Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" - Pilha\n");

            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(1000);
            s.Empilha(321654987);
            s.Empilha("asdf");
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());


        }
    }
}
