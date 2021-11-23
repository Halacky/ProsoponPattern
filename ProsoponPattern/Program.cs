using System;
using System.Collections.Generic;

namespace πρόσωπον
{
    class Program
    {
        static void Main(string[] args)
        {

            PercentileDestib percentile = new PercentileDestib();
            DispersionIndicator dispersion = new DispersionIndicator();
            MedianValue median = new MedianValue();
            ExcelHandler excelHandler = new ExcelHandler();


            DescriptvieAnalisis descriptvieAnalisis = new DescriptvieAnalisis(dispersion, median, percentile, excelHandler);

            Client.CalculateStatistics(descriptvieAnalisis);

        }
    }
}
