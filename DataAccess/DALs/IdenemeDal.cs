using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DALs
{
    public interface IdenemeDal
    {
        List<Deneme> GetList(Expression<Func<Deneme, bool>> condition = null);
        Deneme Get(Expression<Func<Deneme, bool>> condition);
    }
}
