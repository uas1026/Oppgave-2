List<string> specimens = new List<string>();

while (true)
{
    Console.Write("Command (ADD/REMOVE/LIST/COUNT/QUIT): ");
    string? command = Console.ReadLine();

    // TODO: Implementer kommandoene.
    // Tips: specimens må IKKE opprettes på nytt inne i løkken.

    if (command == "ADD")
    {
        Console.Write("Specimen name: ");
        string? name = Console.ReadLine();
        AddSpecimen(name);
    }

    else if (command == "REMOVE")
    {
        Console.Write("Specimen name: ");
        string? name = Console.ReadLine();
        RemoveSpecimen(name);
    }

    else if (command == "LIST")
    {
        Console.WriteLine(string.Join(", ", specimens));
    }

    else if (command == "COUNT")
    {
        Console.WriteLine(specimens.Count);
    }

    else if (command == "QUIT")
    {
        break;
    }
}

void RemoveSpecimen(String name)
{
    if (name is not null && specimens.Remove(name))
    {
        Console.WriteLine("Specimen removed.");
    }
    else
    {
        Console.WriteLine("Specimen not found.");
    }
}

string AddSpecimen(String input)
{
    if (!string.IsNullOrWhiteSpace(input))
    {
        specimens.Add(input);
        Console.WriteLine("Specimen added.");
        return input;
    }
    else return null;
}
