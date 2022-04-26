using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPR_nummer_opgave
{
    static internal class CPR
    {
        static public bool valdierCPR(string date, string nummer)
        {
            DateTime d;
            int nummer_int;
            if (DateTime.TryParseExact(date, new string[] { "dd/MM/yy" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out d)
                && nummer.Length == 4 && int.TryParse(nummer, out nummer_int))
            {
                    Console.WriteLine($"{date}-{nummer}");
                    return true;
            }
            else
            {
                Console.WriteLine($"{date}-{nummer}");
                return false;
            }
        }
    }
}
