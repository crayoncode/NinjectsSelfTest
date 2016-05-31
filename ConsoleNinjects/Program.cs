using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace ConsoleNinjects
{
    class Program
    {
        static void Main(string[] args)
        {
            IocHelper.EnvKernel = new StandardKernel(new IocModulecs());


            IGetDifferent different = IocHelper.EnvKernel.Get<IGetDifferent>("english");
            different.ShowName();
            different.ShowContent();

            IGetDifferent different1 = IocHelper.EnvKernel.Get<IGetDifferent>("chinese");
            different1.ShowName();
            different1.ShowContent();

            IGetDifferent different2 = IocHelper.EnvKernel.Get<IGetDifferent>("english");
            different2.ShowName();
            different2.ShowContent();

            Console.ReadKey();
        }
    }
}
