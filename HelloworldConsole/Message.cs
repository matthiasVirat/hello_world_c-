using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloworldConsole
{
    public class Message
    {
        int _t1;
        int _t2;
        int _t3;
        readonly String _bj = "Bonjour ";
        readonly String _bs = "Bonsoir ";
        readonly String _ba = "Bon après-midi ";
        readonly String _bw = "Bon week-end ";
        IUserName _name;
        IDayHour _dayHour;

        public Message(int t1, int t2, int t3) 
            : this(t1, t2, t3, new UserName(), new DayHour())
        {            
        }

        internal Message(int t1, int t2, int t3, IUserName name, IDayHour dayHour)
        {
            this._t1 = t1;
            this._t2 = t2;
            this._t3 = t3;
            this._name = name;
            this._dayHour = dayHour;
        }

        public String GetHelloMessage()
        {
            String message = "";

            switch (this._dayHour.GetDay())
            {
                case "lundi":
                case "mardi":
                case "mercredi":
                case "jeudi":
                    if (this._t1 <= this._dayHour.GetHour() && this._dayHour.GetHour() < this._t2)
                    {
                        message = this._bj;
                    } else if (this._t2 <= this._dayHour.GetHour() && this._dayHour.GetHour() < this._t3)
                    {
                        message = this._ba;
                    } else
                    {
                        message = this._bs;
                    }
                    break;
                case "Vendredi":
                    if (this._t1 <= this._dayHour.GetHour() && this._dayHour.GetHour() < this._t2)
                    {
                        message = this._bj;
                    }
                    else if (this._t2 <= this._dayHour.GetHour() && this._dayHour.GetHour() < this._t3)
                    {
                        message = this._ba;
                    }
                    else
                    {
                        message = this._bw;
                    }
                    break;
                default:
                    message = this._bw;
                    break;
            }
            return message + this._name.GetUserName();
        }
    }
}
