using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloworldConsole;

namespace MessageTests
{
    public class FakeDayHour : IDayHour
    {

        public String DayToReturn { get; set; }
        public int HourToReturn { get; set; }

        public String GetDay()
        {
            return DayToReturn;
        }

        public int GetHour()
        {
            return HourToReturn;
        }

    }
}
