using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BkBolgeManager : IBkBolgeService
    {
        IBkBolgeDal _bkBolgeDal;

        public BkBolgeManager(IBkBolgeDal bkBolgeDal)
        {
            _bkBolgeDal = bkBolgeDal;
        }
        public IResult Add(BkBolges bkBolges)
        {
            _bkBolgeDal.Add(bkBolges);

            return new SuccessResult(Messages.BkBolgeAdded);
        }

        public IResult DeleteById(int id)
        {
            var result = _bkBolgeDal.Get(b => b.Id == id);
            if (result != null)
            {
                return new ErrorResult();
            }

            _bkBolgeDal.Delete(result);

            return new SuccessResult(Messages.BkBolgeDeleted);
        }

        public IDataResult<List<BkBolges>> GetAll()
        {
            return new SuccessDataResult<List<BkBolges>>(_bkBolgeDal.GetAll(), Messages.BkBolgeListed);
        }

        public IDataResult<BkBolges> GetById(int id)
        {
            return new SuccessDataResult<BkBolges>(_bkBolgeDal.Get(b => b.Id == id));
        }

        public IResult Update(BkBolges bkBolges)
        {
            _bkBolgeDal.Update(bkBolges);
            return new SuccessResult(Messages.BkBolgeUpdated); 
        }
    }
}
