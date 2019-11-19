using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloworldConsole
{
    class DayHour : IDayHour
    {
        DateTime _now;

        public DayHour()
        {
            this._now = DateTime.Now;
        }

        public String GetDay()
        {
            return this._now.ToString("dddd");
        }

        public int GetHour()
        {
            return this._now.Hour;
        }
    }
}
