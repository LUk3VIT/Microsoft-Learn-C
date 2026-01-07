string[] IDsFraudulentos = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

string auth = "B";
int bin = 0;

foreach (string IDs in IDsFraudulentos)
{
    if (IDsFraudulentos[bin].StartsWith(auth))
    {
        Console.WriteLine($"{IDsFraudulentos[bin]}");
    }

    bin++;
}