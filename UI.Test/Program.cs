using Business.Abstract;
using Business.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Test
{
    class Program
    {
        private static IBusiness _business;

        static void Main(string[] args)
        {
            _business = InstanceFactory.GetInstance<IBusiness>();

            var asd = _business.ListDeneme();
        }
    }
}
