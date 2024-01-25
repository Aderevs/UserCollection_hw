using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MonthCollection
{
    internal class MonthsCollection : ICollection
    {
        private static string[] months = ["January", "February", "March", "Aprile", "May", "June", "July", "August", "September", "October", "Novemver", "December"];
        private int[] numberOfMonth = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
        private int[] numberOfDaysInMonth = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
        public string this[int value]
        {
            get
            {
                return months[value - 1];
            }
        }
        public int this[string month]
        {
            get
            {
                if (months.Contains(month))
                {
                    int index = -1;
                    for (int i = 0; i < months.Length; i++)
                    {
                        if (months[i] == month)
                        {
                            index = i;
                        }
                    }
                    return index + 1;
                }
                else
                {
                    throw new ArgumentException("Attempt to get number of month that doesn't exist");
                }
            }
        }

        public string[] GetMonthsWithSuchNumberOfDays(int numberOfDays)
        {
            if (numberOfDaysInMonth.Contains(numberOfDays))
            {
                List<int> indexesOfWantedMonths = new List<int>();
                for (int i = 0; i < numberOfDaysInMonth.Length; i++)
                {
                    if (numberOfDaysInMonth[i] == numberOfDays)
                    {
                        indexesOfWantedMonths.Add(i);
                    }
                }
                List<string> nameOfMonths = new List<string>();
                foreach (var index in indexesOfWantedMonths)
                {
                    nameOfMonths.Add(months[index]);
                }
                return nameOfMonths.ToArray();
            }
            else
            {
                throw new ArgumentException("No months with such number of days");
            }

        }

        public int GetNumberOfDaysInMonth(string nameOfMonth)
        {
            if (months.Contains(nameOfMonth))
            {
                return numberOfDaysInMonth[this[nameOfMonth] - 1];
            }
            else
            {
                throw new ArgumentException("Such month does not exist (method requires the month name to be capitalized)");
            }
        }

        public int Count => 12;

        public bool IsSynchronized => months.IsSynchronized;

        public object SyncRoot => months.SyncRoot;

        public void CopyTo(Array array, int index)
        {
            months.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return months.GetEnumerator();
        }
    }
}
