using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_for_working_with_arrays
{
    class CycledDynamicArray<T> : DynamicArray<T>
    {
        public CycledDynamicArray() : base() { }
        public CycledDynamicArray(int number) : base(number) { }
        public CycledDynamicArray(IEnumerable<T> collection) : base(collection) { }

        public override IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; ; i++)
            {
                if (i == Length)
                {
                    i = 0;
                }

                yield return this[i];
            }
        }
    }
}
