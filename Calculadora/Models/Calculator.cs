using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calculator
    {
        public List<string> HistoricList { get; private set; }

        public Calculator()
        {
            HistoricList = new List<string>();
        }

        public int getSum(int value1, int value2)
        {
            int res = value1 + value2;
            AddToHistoric(res);
            return res;
        }
        public int getSubtraction(int value1, int value2)
        {
            int res = value1 - value2;
            AddToHistoric(res);
            return res;
        }
        public int getMultiplication(int value1, int value2)
        {
            int res = value1 * value2;
            AddToHistoric(res);
            return res;
        }
        public int getDivision(int value1, int value2)
        {
            int res = value1 / value2;
            AddToHistoric(res);
            return res;
        }

        public void OperationsHistoric()
        {
            HistoricList.RemoveRange(3, HistoricList.Count - 3);
            Console.WriteLine("Last results:");
            foreach (var item in HistoricList)
            {
                Console.WriteLine(item);
            }
        }

        public int AddToHistoric(int result)
        {
            HistoricList.Insert(0,$"Result: {result}");
            return 0;
        }

    }
}