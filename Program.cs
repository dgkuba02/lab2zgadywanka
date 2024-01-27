    Random rnd = new Random();
    int x = 0;
    int tries = 0;
    bool found = false;

    Console.WriteLine("Witaj w zgadywance liczby od 1 do 100.\nGra wylosowała liczbę, zgadnij ją w max. 10 próbach, powodzenia!");

    x = rnd.Next(1, 100);

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Wpisz liczbę");
        int z = Convert.ToInt32(Console.ReadLine());
        if (z == x)
        {
            tries++;
            found = true;
            break;
        }
        else
        {
            tries++;
            if(z > x)
            {
                Console.WriteLine("Podana liczba jest większa od wylosowanej.");
            }
            else
            {
                Console.WriteLine("Podana liczba jest mniejsza od wylosowanej.");
            }
        }
    }

    if(found)
    {
        Console.WriteLine("Brawo! Wylosowana liczba to " + Convert.ToString(x) + ". Liczba została odgadnięta w " + Convert.ToString(tries) + " próbach.");
    }
    else
    {
        Console.WriteLine("Niestety nie udało Ci się odgadnąć wylosowanej liczby.");
    }
