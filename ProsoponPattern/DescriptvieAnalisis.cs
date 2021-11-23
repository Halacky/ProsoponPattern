using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace πρόσωπον
{
    /// <summary>
    /// Класс Фасада предоставляет простой интерфейс для сложной логики одной или
    // нескольких подсистем. Фасад делегирует запросы клиентов соответствующим
    // объектам внутри подсистемы. Фасад также отвечает за управление их
    // жизненным циклом. Все это защищает клиента от нежелательной сложности
    // подсистемы.
    /// </summary>
    public class DescriptvieAnalisis
    {

        DispersionIndicator dispersionIndicator;

        MedianValue medianValue;

        PercentileDestib percentileDestib;

        ExcelHandler excelHandler;

        public DescriptvieAnalisis(DispersionIndicator dispersionIndicator, MedianValue medianValue, PercentileDestib percentileDestib, ExcelHandler excelHandler)
        {
            this.medianValue = medianValue;
            this.dispersionIndicator = dispersionIndicator;
            this.percentileDestib = percentileDestib;
            this.excelHandler = excelHandler;
        }


        /// <summary>
        /// Метод Фасада для быстрого доступа к сложной функциональности
        // подсистемы. 
        /// </summary>
        public void GetDescriptvieAnalisis(string path)
        {

            var salary = excelHandler.GetExc(path);
            dispersionIndicator.GetRMSE();
            dispersionIndicator.GetDisper();
            medianValue.GetMedian(salary);
            medianValue.GetModa(salary);
            percentileDestib.GetQyantile();
        }
    }
}
