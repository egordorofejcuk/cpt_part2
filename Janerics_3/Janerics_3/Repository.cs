using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janerics_3
{
    public class Repository<T> where T : class
    {
        public int Count => items.Count;
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс вне диапазона.");
            }
            return items[index];
        }
    }
}
