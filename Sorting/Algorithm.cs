using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public abstract class Algorithm<T>
    {
        protected List<T> array;

        public abstract List<T> Sort();

        public abstract List<T> GetArray();

    }
}
