using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janerics_1
{
    public class Pair<T, U>
    {
        private T firstValue;
        private U secondValue;
        public Pair(T firstValue, U secondValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
        }
        public T FirstValue
        {
            get { return firstValue; }
            set { firstValue = value; }
        }
        public U SecondValue
        {
            get { return secondValue; }
            set { secondValue = value; }
        }
        public void PrintPair()
        {
            Console.WriteLine($"First value: {firstValue}, Second value: {secondValue}");
        }
    }
}
