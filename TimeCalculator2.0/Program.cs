using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TimeCalculator2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-EN");
            DateTimeStyles styles = DateTimeStyles.AssumeLocal;
            DateTime dateResult;

            do
            {
                try
                {
                    //input 1 time
                    Console.WriteLine("---------------------------------------------");
                    Console.Write(" Please input start time (eg.3:00pm): ");
                    string Date1 = Console.ReadLine();
                    if (DateTime.TryParse(Date1, culture, styles, out dateResult)) ;
                    //Console.WriteLine("{0} converted to {1} {2}.", Date1, dateResult, dateResult.Kind);
                    else
                        Console.WriteLine(" Unable to convert {0} to a date and time.", Date1);

                    //input 2 time
                    Console.Write(" Please input end time (eg.4:00pm): ");
                    string Date2 = Console.ReadLine();
                    if (DateTime.TryParse(Date2, culture, styles, out dateResult)) ;
                    //Console.WriteLine("{0} converted to {1} {2}.", Date2, dateResult, dateResult.Kind);
                    else
                        Console.WriteLine(" Unable to convert {0} to a date and time.", Date2);

                    Console.WriteLine(" Work time today (hh:mm:ss): {0}", Convert.ToDateTime(Date2) - Convert.ToDateTime(Date1));
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n Please, try again");
                }
            } while (true);
        }
    }
}
