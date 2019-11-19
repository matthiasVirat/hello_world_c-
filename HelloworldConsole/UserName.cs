using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloworldConsole
{
    class UserName : IUserName
    {
        public String GetUserName()
        {
            return System.Environment.UserName.Replace(".", " ");
        }
    }
}
