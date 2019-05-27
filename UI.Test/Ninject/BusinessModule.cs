
using Business.Abstract;
using Business.Concrete;
using DataAccess.DALs;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Test.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IdenemeDal>().To<DenemeDal>().InTransientScope();
            Bind<IBusiness>().To<DenemeManager>();
        }
    }
}
