using System; 

class Program
{
    static void Main(string[] args)
    {
        int resultat;
        
        if(!int.TryParse(Console.ReadLine(), out resultat))
        Console.WriteLine("Skriv in en Siffra");
        else 
        {
            Console.WriteLine(resultat);
        }

        bool TryParse(string s, out int resultat)
        {
            resultat = int.Parse(s);
            
        }

    }
}