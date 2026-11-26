string transmission = "AX?19??Q";
int markerCount = 0;

// TODO: Bruk for og transmission[i].
for(int i = 0; i < transmission.Length; i++)
{
    if (transmission[i] == '?')
    {
        markerCount++;
        Console.WriteLine("Marker at index " + i);
    }
}

Console.WriteLine($"Marker count: {markerCount}");
