using Business.Abstract;
using DataAccess.DALs;
using DataAccess.DTOs;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Ninject;
using AutoMapper;

namespace Business.Concrete
{
    public class DenemeManager : IBusiness
    {
        private readonly IdenemeDal _denemeDal;


        public DenemeManager()
        {
            _denemeDal = InstanceFactory.GetInstance<IdenemeDal>();
        }


        public List<DenemeDTO> ListDeneme(Expression<Func<Deneme, bool>> condition = null)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Deneme, DenemeDTO>();
            });

            var Deneme = _denemeDal.GetList(condition);

            var asd = Mapper.Map<List<DenemeDTO>>(Deneme);


            return null;
        }
    }
}
