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


        public CustomList()
        {
            count = 0;
            originalArray = new T[count];
        }

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


        public override string ToString()
        {
            StringBuilder emptyString = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                if (i != count - 1)
                {
                    emptyString.Append(originalArray[i] + " ,");
                }
                else
                {
                    emptyString.Append(originalArray[i]);
                }
            }
            var theThing = emptyString.ToString();
            return theThing;
        }
  
        public CustomList<T> ZipperMethod(CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();

            for (int i = 0; i < Count && i < list2.Count; i++)
            {
                    newList.Add(this[i]);
                    newList.Add(list2[i]);
            }
            return newList;
        }

        public static CustomList<T> operator+(CustomList<T> list2, CustomList<T> list)
        {
            CustomList<T> newList = new CustomList<T>();

            for (int i = 0; i < list.Count; i++)
            {
                newList.Add(list[i]);
            }

            for (int i = 0; i < list2.Count; i++)
            {
                newList.Add(list2[i]);
            }
            return newList;
        }

        public static CustomList<T> operator-(CustomList<T> list2, CustomList<T> list)
        {
            CustomList<T> newList = new CustomList<T>();

            bool contains = false;
            bool contain = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(value))
                {
                    contains = true;
                    break;
                }
                if (list2[i].Equals(value))
                {
                    contain = true;
                    break;
                }
            }

            if (contains)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    newList.Remove(list.[i]);
                }
            }
            if (contain)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    newList.Remove(list2[i]);
                }
            }
            return newList;
        }
    }
}
