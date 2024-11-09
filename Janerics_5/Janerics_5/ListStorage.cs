﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janerics_5
{
    public class ListStorage<T>: IStorage<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public T Get(int index)
        {
            return items[index];
        }

    }
}