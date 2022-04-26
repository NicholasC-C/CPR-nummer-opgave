using CPR_nummer_opgave;
do
{
    Console.WriteLine("Indtast CPR nummer");
    Console.WriteLine("Indtast dagen du var født");
    string dag = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Indtast måned du var født");
    string moened = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Indtast år du var født");
    string aar = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Indtast 4 sidste nummer i CPR");
    string nummer = Console.ReadLine();
    Console.Clear();

    if (aar.Length > 2)
    {
        aar = aar.Substring(2, 2);
    }

    string date = $"{dag}/{moened}/{aar}";



    if (!CPR.valdierCPR(date, nummer))
    {
        Console.WriteLine("Ugyldigt, Prøv igen");
    }

    Console.WriteLine("Press 'x' to exit");

    string input = Console.ReadLine();
    if (input.ToLower() == "x")
        break;

    Console.Clear();
} while (true);