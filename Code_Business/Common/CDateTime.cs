using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharma
{
    class CDateTime
    {
        public static DateTime DateFromString(string date)
        {
            DateTime ValidDate;

            if (DateTime.TryParseExact(date, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                return ValidDate;
            else
                return DateTime.MinValue;
        }

        public static DateTime DateFromStringForSQLMin(string date)
        {
            DateTime ValidDate;

            if (DateTime.TryParseExact(date, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                return ValidDate;
            else
                return CSettings.SQLServerMinDate;
        }

        public static DateTime DateFromStringForSQLMax(string date)
        {
            DateTime ValidDate;

            if (DateTime.TryParseExact(date, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                return ValidDate;
            else
                return DateTime.MaxValue;
        }
    }
}
