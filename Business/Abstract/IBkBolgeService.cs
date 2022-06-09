using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBkBolgeService
    {
        IDataResult<List<BkBolges>> GetAll();
        IDataResult<BkBolges> GetById(int id);
        IResult Add(BkBolges bkBolge);
        IResult Update(BkBolges bkBolge);
        IResult DeleteById(int id);
    }
}
