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
        private string[] months = ["January", "February", "March", "Aprile", "May", "June", "July", "August", "September", "October", "Novemver", "December"];
        string this[int value]
        {
            get
            {
                return months[value - 1];
            }
        }
        int this[string month]
        {
            get
            {
                if (months.Contains(month))
                {
                    return month.IndexOf(month) + 1;
                }
                else
                {
                    throw new ArgumentException("Attempt to get number of month that doesn't exist");
                }
            }
        }

        public string[] GetMonthsWithSuchNumberOfDays(int numberOfDays)
        {
            if (numberOfDays == 28 || numberOfDays == 30 || numberOfDays == 31)
            {
                var months = new List<string>();
                foreach (var item in months)
                {
                    if (numberOfDays == DateTime.DaysInMonth(2023, this[item]))//for instance take 2023 year because it not a leap year
                    {
                        months.Add(item);
                    }
                }
                return months.ToArray();
            }
            else
            {
                throw new ArgumentException("No months with such number of days");
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
