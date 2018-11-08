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
        int Count;

        public CustomList()
        {
            Count = 0;
            originalArray = new T[Count];
        }

        public void Add(T itemToAdd)
        {
            if (Count == 0)
            {
                Count++;
                T[] tempArray = new T[Count];
                tempArray[Count - 1] = itemToAdd;
                originalArray = tempArray;
            }
            else
            {
                Count++;
                T[] tempArray = new T[Count];
                for (int i = 0; i < Count - 1; i++)
                {
                    tempArray[i] = originalArray[i];
                }
                tempArray[Count - 1] = itemToAdd;
                originalArray = tempArray;
            }
        }

        public void Remove(T itemToCheck)
        {
            bool contains = false;
            for (int i = 0; i < Count; i++)
            {
                if (originalArray[i].Equals(itemToCheck))
                {
                    contains = true;
                    break;
                }
            }

            if (contains)
            {
                int j = 0;
                T[] tempArray = new T[Count - 1];
                for (int i = 0; i < Count; i++, j++)
                {
                    if (!itemToCheck.Equals(originalArray[i]))
                    {
                        tempArray[j] = originalArray[i];
                    }
                    else
                    {
                        j--;
                    }
                }
                Count = Count - 1;
                originalArray = new T[Count];
                originalArray = tempArray;
            }
        }


        public void ConvertMethod(T objectsInList)
        {
            StringBuilder emptyString = new StringBuilder();

            for (int i = 0; i < Count; i++)
            {
                emptyString.Append(originalArray[i] + " ");
            }   

        }
    }
}
