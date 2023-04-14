using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur många heltal vill du skriva in?");
        int heltal = Convert.ToInt32(Console.ReadLine());

        string[] tal = new string[heltal];

        Console.WriteLine($"Skriv in {heltal} heltal:");
        for(int i = 0; i < tal.Length; i++)
        {
            tal[i] = Console.ReadLine();
        }
        Console.WriteLine("Här är talen du skrev in:");
        for(int i = 0; i < tal.Length; i++)
        {
            Console.WriteLine($"Tal {i+1}: {tal[i]}");
        }
    }
}