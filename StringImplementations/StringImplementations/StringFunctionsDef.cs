using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringImplementations
{
    public class StringFunctionsDef : StringFunctions
    {
        
        private int space;
        private String[] total;
        public int count;
        public int numberComp { get; private set; }
        public int numberMoves { get; private set; }

        public int Counter
        {
            get { return count; }
        }

        public StringFunctionsDef(int initialCapacity)
        {
            space = initialCapacity;
            total = new String[space];
        }

        public string[] Insert_String(int index, String element)
        {
            int i;
            for (i = Counter; i >= index; i--)
            {
                total[i] = total[i - 1];

            }
            total[i] = element;
            return total;
        }

        public String RemoveAt_Index(int index)
        {
            if (index < 0 || index > Counter)
            {
                return "Invalid.";
            }
            else
            {
                int i;
                for (i = index; i < Counter; i++)
                {
                    total[i] = total[i + 1];
                }
                return "Deleted Successfully.";
            }
        }

        public String ElementAt_Index(int index)
        {
            if (index < count)
            {
                return total[index];
            }

            return default(String);
        }


        public void Set_String(int index, String element)
        {
            total[index] = element;
        }

        public void Add_String(String element)
        {
            total[count] = element;
            count++;
            BubbleSort();
        }

        public bool Remove_String(String element)
        {
            int i;
            for (i = 0; i < Counter; i++)
            {
                if (total[i].Equals(element))
                {
                    for (; i < Counter; i++)
                        total[i] = total[i + 1];
                    return true;
                }
            }


            return false;
        }

        public bool Contains_String(String element)
        {
            int i;
            for (i = 0; i < Counter; i++)
            {
                if (total[i].Equals(element))
                    return true;
            }

            return false;
        }

        public int IndexOf_String(String target)
        {

            int loc = -1;
            for (int i = 0; i < Counter; i++)
            {
                if (target.Equals(total[i]))
                {
                    loc = i;

                    i = Counter;

                    
                }
            }
            return loc;
        }

        public bool IsEmpty_String()
        {
            return (count == 0);
        }

        public string[] Clear_String()
        {
            for (int i = 0; i < Counter; i++)
                total[i] = "";
            return total;
        }

        public int BinarySearch(String target)
        {
            int min = 0;
            int max = Counter - 1;
            bool found = false;
            int middle = 0;

            while (!found && min <= max)
            {
                middle = (min + max) / 2;

                int relationship = ((IComparable)target).CompareTo(total[middle]);
                if (relationship < 0)
                    max = middle - 1;
                else if (relationship > 0)
                    min = middle + 1;
                else
                    found = true;
            }

            if (!found)
            {
                middle = -1;
            }

            return middle;
        }

        public void BubbleSort()
        {
            int lastSwap = Counter - 1;
            while (lastSwap != 0)
            {
                int comparisonsToMake = lastSwap;
                lastSwap = 0;
                for (int j = 0; j < comparisonsToMake; j++)
                {
                    numberComp++;
                    if (((IComparable)total[j]).CompareTo(total[j + 1]) > 0)
                    {
                        String tmp = total[j];
                        total[j] = total[j + 1];
                        total[j + 1] = tmp;
                        lastSwap = j;
                        numberMoves += 2;
                    }
                }
            }
        }

    }
}
