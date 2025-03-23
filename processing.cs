using System;
using System.Collections.Generic;
using System.Linq;

public class Processing
{
    public static double CalculateAverage(List<double> grades)
    {
        if (grades.Count == 0) return 0;
        return grades.Average();
    }
}