using AutoMapper;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DenemeMapper<T, K> where T : class, IEntity where K : class, IEntity
    {
        public void GetMapper(T ilk, K son)
        {
            //Mapper.Initialize(config =>
            //{
            //    config.CreateMap<ilk,son>();
            //});

            //return K;

        }


    }
}
