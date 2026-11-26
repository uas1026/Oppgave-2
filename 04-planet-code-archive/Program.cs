string[] planetCodes = { "ORION-4", "KAPPA-9", "LYRA-2", "NOVA-7", "VEGA-3" };
bool found = false;

// TODO: Skriv Length, første og siste element.
// TODO: Finn KAPPA-9 med en løkke.
Console.WriteLine("Found " + planetCodes.Length + " planets.");
Console.WriteLine("The first and the last planets found are: " + planetCodes[0] + " and " + planetCodes[planetCodes.Length - 1]);

if (planetCodes.Contains("KAPPA-9"))
{
    found = true;
}

Console.WriteLine($"Found KAPPA-9: {found}");
