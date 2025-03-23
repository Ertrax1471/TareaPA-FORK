using System;

public class OutputHandler
{
    public static void ShowResult(double average)
    {
        Console.WriteLine($"El promedio de calificaciones es: {average:F2}");
    }
}