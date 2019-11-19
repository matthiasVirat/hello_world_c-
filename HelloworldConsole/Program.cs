using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloworldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime now = DateTime.Now;
            DateTime now = new DateTime(2019, 11, 22, 19, 01, 00);
            Message message = new Message(9, 13, 19);
            String saisie = "";
            

            while (saisie != "exit")
            {
                Console.WriteLine(message.GetHelloMessage());
                saisie = Console.ReadLine();
            }
            


        }
    }
}
