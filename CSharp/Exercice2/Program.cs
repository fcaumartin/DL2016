using System;



namespace Exercice2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            //Console.CursorTop = 10;
            //Console.CursorLeft = 10;
            Console.WriteLine("────────────────────────────");
            Console.WriteLine("│ Exercie1 by frc (c) 2017 │");
            Console.WriteLine("└──────────────────────────┘");


            int age;
            string nom, saisie;

            Console.WriteLine("Veuillez entrer votre nom");
            nom = Console.ReadLine();

            Console.WriteLine("Entrez votre age");
            saisie = Console.ReadLine();
            age = Convert.ToInt32(saisie);

            //age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bonjour {1}, vous avez {0} ans", age, nom);



        }
    }

}
