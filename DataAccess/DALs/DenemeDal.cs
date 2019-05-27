using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.DALs
{
   public  class DenemeDal : IdenemeDal
    {
        private readonly AppDbContext _dbContext;

        public DenemeDal(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Deneme Get(Expression<Func<Deneme, bool>> condition)
        {
            return new Deneme() {Id = 1, Ad = "tuncay" , Soyad = "özarslan"};
        }

        public List<Deneme> GetList(Expression<Func<Deneme, bool>> condition = null)
        {
            return new List<Deneme>() { new Deneme() { Id = 1, Ad = "tuncay", Soyad = "özarslan" } };
        }
    }
}
