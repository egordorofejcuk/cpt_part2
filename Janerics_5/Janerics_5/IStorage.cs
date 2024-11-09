using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janerics_5
{
    public interface IStorage<T>
    {
        void Add(T item);
        T Get(int index);
    }
}
