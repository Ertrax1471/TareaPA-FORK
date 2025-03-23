using System;
using System.Collections.Generic;

public class InputHandler
{
    public static List<double> GetGrades()
    {
        List<double> grades = new List<double>();
        Console.WriteLine("Ingrese las calificaciones (escriba 'fin' para terminar):");
        string input;
        while ((input = Console.ReadLine()) != "fin")
        {
            if (double.TryParse(input, out double grade))
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }
        return grades;
    }
}