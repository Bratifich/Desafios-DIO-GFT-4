using System;
using personagem_rpg.Entities;

namespace personagem_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Knight arus = new Knight("Arus", 42, "Knight");
            Ninja wedge = new Ninja("Wedge", 42, "Ninja");
            Wizard jannica = new Wizard("Jannica", 42, "White Wizard");
            Wizard topapa = new Wizard("Topapa", 42, "Black Wizard");
       
            Console.WriteLine(arus);
            Console.WriteLine(wedge);
            Console.WriteLine(jannica);
            Console.WriteLine(topapa);

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(jannica.Attack(6));
            Console.WriteLine(topapa.Attack(3));
            Console.WriteLine(topapa.Attack(7));

        }
    }
}