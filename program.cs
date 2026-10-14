/***
 * Constructor Overloading
 * Dev: Abduli-mp
 * Version: unfinished
 * ***/

class Uhrzeit
{
    private int std;
    private int min;
    private int sec;

    public Uhrzeit()
    {
        std = 00;
        min = 00;
        sec = 00;
    }

    public void Zeit(int stunde, int minute, int sekunde)
    {
        std = stunde;
        min = minute;
        sec = sekunde;
    }

    /**
     * To get the remaining seconds , there's a certain formule i used below, anyway goodluck with that
     * And don't worry about the english, didnt have time to translate.
     * 
     * Formula: 
     *          hours = total_seconds / 3600
     *          minutes = (total_seconds % 3600) / 60
     *          seconds = total_seconds % 60
     * 
     *          The key is that 1 hour = 3,600 seconds and 1 minute = 60 seconds.
     * ***/

    public void ZeitAnzahl(int sekunde)
    {
        int stunde = sekunde / 3600;
        int minutes = (sekunde % 3600) / 60;
        int remainingSeconds = sekunde % 60;
    }

    public void ZeitConvert(string zeit)
    {
        string stunde = $"{zeit[0]}{zeit[1]}";
        string minute = $"{zeit[3]}{zeit[4]}";
        string sekunde = $"{zeit[6]}{zeit[7]}";

        std = Convert.ToInt32(stunde);
        min = Convert.ToInt32(minute);
        sec = Convert.ToInt32(sekunde);
    }

    public void Ausgabe()
    {
        Console.WriteLine($"{std}:{min}:{sec}");
    }
}

class Program
{
    public static void Main()
    {
        Uhrzeit Uhr = new Uhrzeit();

        Uhr.Ausgabe();
        Uhr.ZeitConvert("12:34:54");
        Uhr.Ausgabe();


    }
}
