using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bonjour Plamedie !");
        Console.WriteLine("Ceci est un test simple en C#.");

        // Exemple de fonction
        int resultat = Addition(5, 7);
        Console.WriteLine("Résultat de 5 + 7 = " + resultat);
    }

    static int Addition(int a, int b)
    {
        return a + b;
    }
}
