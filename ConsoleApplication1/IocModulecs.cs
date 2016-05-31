using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace ConsoleApplication1
{
    public class IocModulecs : NinjectModule
    {
        public override void Load()
        {
            //Bind<ICoreModuleInterface>().To<ChinesePerson>();
            Bind<ICoreModuleInterface>().To<ChinesePerson>().InSingletonScope().Named("chinese");
        }
    }
}
