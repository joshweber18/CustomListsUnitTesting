using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
    public class CustomList<T>
    {

        T[] originalArray;
        int count;

        public T this[int i]
        {
            get { return originalArray[i]; }
            set { originalArray[i] = value; }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public CustomList()
        {
            count = 0;
            originalArray = new T[count];
        }

        public void Add(T value)
        {
            if (count == 0)
            {
                count++;
                T[] tempArray = new T[count];
                tempArray[count - 1] = value;
                originalArray = tempArray;
            }
            else
            {
                count++;
                T[] tempArray = new T[count];
                for (int i = 0; i < count - 1; i++)
                {
                    tempArray[i] = originalArray[i];
                }
                tempArray[count - 1] = value;
                originalArray = tempArray;
            }
        }

        public void Remove(T value)
        {
            bool contains = false;
            for (int i = 0; i < Count; i++)
            {
                if (originalArray[i].Equals(value))
                {
                    contains = true;
                    break;
                }
            }

            if (contains)
            {
                int j = 0;
                T[] tempArray = new T[count - 1];
                for (int i = 0; i < count; i++, j++)
                {
                    if (!value.Equals(originalArray[i]))
                    {
                        tempArray[j] = originalArray[i];
                    }
                    else
                    {
                        j--;
                    }
                }
                count = count - 1;
                originalArray = new T[count];
                originalArray = tempArray;
            }
        }


        public void ToString(T value)
        {
            StringBuilder emptyString = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                emptyString.Append(originalArray[i] + " ");
            }
        }
    }
}
