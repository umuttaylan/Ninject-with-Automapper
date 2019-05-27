using DataAccess.DTOs;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBusiness
    {
        List<DenemeDTO> ListDeneme(Expression<Func<Deneme, bool>> condition = null);

    }
}
