using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2905lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfTheWeek coursedays = DaysOfTheWeek.Sunday | DaysOfTheWeek.Wednesday;

            if (DaysAppear(coursedays, DaysOfTheWeek.Thursday))
            {
                Console.WriteLine($"coursedays contains {DaysOfTheWeek.Thursday}");
            }
            else
            {
                Console.WriteLine($"coursedays does not contain {DaysOfTheWeek.Thursday}");
            }

            Console.WriteLine(AddDay(coursedays, DaysOfTheWeek.Saturday));
            Console.WriteLine(coursedays);
            Console.WriteLine(RemoveDay(coursedays,DaysOfTheWeek.Sunday));

            daysdoesnotexist(coursedays);
        }

        private static bool DaysAppear(DaysOfTheWeek listofdays, DaysOfTheWeek singleday)
        {
            return listofdays.HasFlag(singleday);
        }

        private static DaysOfTheWeek AddDay(DaysOfTheWeek listofdays, DaysOfTheWeek singleday)
        {
            if(!listofdays.HasFlag(singleday))
            {
               return listofdays | singleday;
            }
            return listofdays;
        }

        private static DaysOfTheWeek RemoveDay(DaysOfTheWeek listofdays, DaysOfTheWeek singleday)
        {
            if (listofdays.HasFlag(singleday))
            {
                return listofdays & ~singleday;
            }
            else
                return listofdays;
        }

        private static void daysdoesnotexist(DaysOfTheWeek listofdays)
        {
            foreach(var day in (DaysOfTheWeek[])Enum.GetValues(typeof(DaysOfTheWeek)))
            {
                if(!listofdays.HasFlag(day))
                {
                    Console.WriteLine(day);
                }
            }
        }
    }
}