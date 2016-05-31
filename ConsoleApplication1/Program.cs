using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IocHelper.EnvKernel = new StandardKernel(new IocModulecs());


            //ICoreModuleInterface chinese = IocHelper.EnvKernel.Get<ChinesePerson>();
            //chinese.Name = "666";
            //chinese.Age = "12";

            //ICoreModuleInterface chinese2 = IocHelper.EnvKernel.Get<ChinesePerson>();

            ICoreModuleInterface different = IocHelper.EnvKernel.Get<ICoreModuleInterface>("chinese");
            different.Name = "哈哈哈";
            different.Age = "1111";

            ICoreModuleInterface different2 = IocHelper.EnvKernel.Get<ICoreModuleInterface>("chinese");
            Console.WriteLine(different2.Age);
            Console.ReadKey();
        }
    }
}
