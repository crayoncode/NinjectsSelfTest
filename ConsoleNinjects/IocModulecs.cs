using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace ConsoleNinjects
{
    public class IocModulecs:NinjectModule
    {
        public override void Load()
        {
            Bind<IGetDifferent>().To<ChineseShow>().InSingletonScope().Named("chinese");
            Bind<IGetDifferent>().To<EnglisShow>().InSingletonScope().Named("english");
        }
    }
}
