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


        public CustomList<T> Zipper(CustomList<T> list2)
        {

            CustomList<T> newList = new CustomList<T>();
            CustomList<T> longerCount = new CustomList<T>();
            CustomList<T> shorterCount = new CustomList<T>();
            bool outOfValue = false;
​
            if (Count > list2.Count)
            {
                longerCount = this;
                shorterCount = list2;
            }
            else if (Count < list2.Count)
            {
                longerCount = list2;
                shorterCount = this;
            }
                for (int i = 0; i < longerCount.Count; i++)
                {
                while (i < shorterCount.Count)
                {
                    newList.Add(shorterCount[i]);
                    newList.Add(longerCount[i]);
                }
                    if (i > shorterCount.Count - 1)
                    {
                        outOfValue = true;
                    }
​
                if (outOfValue)
                {
                    newList.Add(longerCount[i]);
                }
            }
            return newList;
        }
    }
}
