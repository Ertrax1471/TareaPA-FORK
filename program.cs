using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> grades = InputHandler.GetGrades();
        double average = Processing.CalculateAverage(grades);
        OutputHandler.ShowResult(average);
    }
}