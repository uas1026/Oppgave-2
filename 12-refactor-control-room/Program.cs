
List<string> beacons = new List<string>();
/*
while (true)
{
    Console.WriteLine();
    Console.WriteLine("1 - Add beacon");
    Console.WriteLine("2 - Remove beacon");
    Console.WriteLine("3 - List beacons");
    Console.WriteLine("4 - Quit");
    Console.Write("Choice: ");

    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Beacon name: ");
        string? name = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(name))
        {
            beacons.Add(name);
            Console.WriteLine("Beacon added.");
        }
    }
    else if (choice == "2")
    {
        Console.Write("Beacon name: ");
        string? name = Console.ReadLine();
        if (name is not null && beacons.Remove(name))
        {
            Console.WriteLine("Beacon removed.");
        }
        else
        {
            Console.WriteLine("Beacon not found.");
        }
    }
    else if (choice == "3")
    {
        if (beacons.Count == 0)
        {
            Console.WriteLine("No beacons registered.");
        }
        else
        {
            foreach (string beacon in beacons)
            {
                Console.WriteLine($"- {beacon}");
            }
        }
    }
    else if (choice == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Unknown choice.");
    }
}
*/

// TODO: Refaktorer den fungerende koden over til flere metoder.
void PrintMenu()
{
    Console.WriteLine();
    Console.WriteLine("1 - Add beacon");
    Console.WriteLine("2 - Remove beacon");
    Console.WriteLine("3 - List beacons");
    Console.WriteLine("4 - Quit");
    Console.Write("Choice: ");
}

string AddBeacon(String input)
{
    if (!string.IsNullOrWhiteSpace(input))
    {
        beacons.Add(input);
        Console.WriteLine("Beacon added.");
        return input;
    }
    else return null;
}

void RemoveBeacon(String input)
{
    if (input is not null && beacons.Remove(input))
    {
        Console.WriteLine("Beacon removed.");
    }
    else
    {
        Console.WriteLine("Beacon not found.");
    }
}

void PrintBeacons()
{
    if (beacons.Count == 0)
    {
        Console.WriteLine("No beacons registered.");
    }
    else
    {
        foreach (string beacon in beacons)
        {
            Console.WriteLine($"- {beacon}");
        }
    }
}

bool firstrun = true;

while (true)
{
    if (firstrun)
    {
        PrintMenu();
    }
    firstrun = false;
    string? choice = Console.ReadLine();
    
    if (choice == "1")
    {
        Console.Write("Beacon name: ");
        string? name = Console.ReadLine();
        AddBeacon(name);
    }

    else if (choice == "2")
    {
        Console.Write("Beacon name: ");
        string? name = Console.ReadLine();
        RemoveBeacon(name);
    }
    else if (choice == "3")
    {
        PrintBeacons();
    }
    else if (choice == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Unknown choice.");
    }
}
