using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloworldConsole;

namespace MessageTests
{
    public class FakeUserName : IUserName
    {
        public FakeUserName()
        {
        }

        public string NameToReturn { get; set; }

        public String GetUserName()
        {
            return NameToReturn;
        }
    }
}
