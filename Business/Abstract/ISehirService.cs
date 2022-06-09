using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISehirService
    {
        IDataResult<List<Sehirs>> GetAll();
        IDataResult<Sehirs> GetById(int id);
        IResult Add(Sehirs sehir);
        IResult Update(Sehirs sehir);
        IResult DeleteById(int id);
    }
}
