using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUyeService
    {
        IDataResult<List<Uyes>> GetAll();
        IDataResult<Uyes> GetById(int id);
        IResult Add(Uyes uyes);
        IResult Update(Uyes uyes);
        IResult DeleteById(int id);
    }
}
