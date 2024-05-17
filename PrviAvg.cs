using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.cistKod
{
    class Avg
    {
        List<double> averages(List<double[]> arraysList)
        {
            List<double> avgs = new List<double>(); //resulting list
            double s;
            foreach (double[] a in arraysList)
            {
                //compact code formating
                s = 0;
                for (int i = 0; i < a.Length; i++) s += a[i];
                avgs.Add(s / a.Length);
            }
            return avgs;
        }
    }
}
class CalculatorRJEŠENJE
{
    public double CalculateAverage(double[] array)
    {
        double brojac = 0;
        double average=0;

        for (int i = 0; i < array.Length; i++)
        { 
            average = brojac/array[i];
        }
        return average;
    }
    public List<double> CalculateAverages(List<double[]> arrays)
    {
        List<double> averages = new List<double>();

        foreach (var array in arrays)
        {
            averages.Add(CalculateAverage(array));
        }
        return averages; 
    }

   
}



