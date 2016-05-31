using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNinjects
{
    class EnglisShow:IGetDifferent
    {
        public void ShowName()
        {
            Console.WriteLine("jackie");
        }

        public void ShowContent()
        {
            Console.WriteLine("I am an American");
        }
    }
}
