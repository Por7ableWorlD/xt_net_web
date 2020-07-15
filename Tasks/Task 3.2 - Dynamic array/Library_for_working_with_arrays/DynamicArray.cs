using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_for_working_with_arrays
{
    public class DynamicArray<T> : IEnumerable<T>, ICloneable
    {
        private T[] array;

        public int Length { get; protected set; }

        public int Capacity
        {
            get => array.Length;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <exception cref="ArgumentOutOfRangeException">Thrown when the "value" is less than the Length</exception>
            /// <returns></returns>
            set
            {
                if (array == null)
                {
                    array = new T[value];
                }
                else if (Length <= value)
                {
                    T[] temporaryArray = array;
                    array = new T[value];
                    temporaryArray.CopyTo(array, 0);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Capacity can't be less than Length!");
                }
            }
        }

        public DynamicArray()
        {
            Capacity = 8;
            array = new T[Capacity];
        }

        public DynamicArray (int number)
        {
            Capacity = number;
            array = new T[Capacity];
        }

        public DynamicArray (IEnumerable<T> collection)
        {
            Capacity = collection.Count();
            array = new T[Capacity];

            foreach (var item in collection)
            {
                Add(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the "index" is outside the array!</exception>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                if (index > -Length && index < Length)
                {
                    if (index >= 0)
                    {
                        return array[index];
                    }
                    else
                    {
                        return array[Length - 1 + index];
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException("idex", "You can't go outside the array!");
                }
            }
            
            set
            {
                if (index > -Length && index < Length)
                {
                    if (index >= 0)
                    {
                        array[index] = value;
                    }
                    else
                    {
                        array[Length - 1 + index] = value;
                    }
                    return;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("idex", "You can't go outside the array!");
                }
            }
        }

        public void Add(T value)
        {
            if (Length == Capacity)
            {
                Capacity *= 2;
            }
            array[Length] = value;
            Length++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public object Clone()
        {
            T[] temporaryArray = new T[Capacity];
            for (int i = 0; i < Length; i++)
                temporaryArray[i] = array[i];

            return new DynamicArray<T>(temporaryArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the "index" is outside the array!</exception>
        /// <returns></returns>
        public bool Insert(int index, T item)
        {
            int Index = index - 1;
            if (Index < 0 || Index >= Length)
            {
                throw new ArgumentOutOfRangeException("Index go beyond the scope of the array!");
            }
            else
            {
                Add(item);

                for (int i = Length - 1; i > Index; i--)
                    array[i] = array[i - 1];

                array[Index] = item;
                return true;
            }
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return array[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public T[] ToArray()
        {
            T[] temporaryArray = new T[Length];
            for (int i = 0; i < Length; i++)
            {
                temporaryArray[i] = array[i];
            }

            return temporaryArray;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < Length; i++)
            {
                if (array[i].Equals(item))
                {
                    for (int j = i; j < Length - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    Length--;

                    return true;
                }
            }
            return false;
        }
    }
}
