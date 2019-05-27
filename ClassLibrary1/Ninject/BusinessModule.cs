using Business.Abstract;
using Business.Concrete;
using DataAccess.DALs;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IdenemeDal>().To<DenemeDal>().InSingletonScope();
            Bind<IBusiness>().To<DenemeManager>().InSingletonScope();
        }
    }
}
