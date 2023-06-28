namespace cwicz_7;
class Program
{
    static void Main(string[] args)
    {
        int czas = 300;
        string czasFormatowany = FormatujCzas(czas);
        Console.WriteLine(czasFormatowany);

        Console.ReadLine();

    }

    static string FormatujCzas(int sekundy)
    {
        int godziny = sekundy / 3600;
        int minuty = (sekundy % 3600) / 60;
        int pozostaleSekundy = (sekundy % 3600) % 60;

        string formatGodziny = godziny.ToString("00");
        string formatMinuty = minuty.ToString("00");
        string formatSekundy = pozostaleSekundy.ToString("00");

        return $"{formatGodziny}:{formatMinuty}:{formatSekundy}";
    }
}

