using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNinjects
{
    class ChineseShow:IGetDifferent
    {
        public void ShowName()
        {
            Console.WriteLine("张三");
        }

        public void ShowContent()
        {
           Console.WriteLine("我是中国人");
        }
    }
}
