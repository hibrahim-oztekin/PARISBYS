using Business.Abstract;
using Business.Constants;
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
    public class SehirManager : ISehirService
    {
        ISehirDal _sehirDal;
        public SehirManager(ISehirDal sehirDal)
        {
            _sehirDal = sehirDal;
        }

        public IResult Add(Sehirs sehir)
        {
            _sehirDal.Add(sehir);
            return new SuccessResult(Messages.EntryAdded);
        }

        public IResult DeleteById(int id)
        {
            Sehirs result = _sehirDal.Get(s => s.Id == id);
            if (result !=null)
            {
                return new ErrorResult();
            }
            _sehirDal.Delete(result);
            return new SuccessResult(Messages.EntryDeleted);
        }

        public IDataResult<List<Sehirs>> GetAll()
        {
            return new SuccessDataResult<List<Sehirs>>(_sehirDal.GetAll(), Messages.EntrysListed);
        }

        public IDataResult<Sehirs> GetById(int id)
        {
            return new SuccessDataResult<Sehirs>(_sehirDal.Get(s => s.Id == id));
        }

        public IResult Update(Sehirs sehir)
        {
            _sehirDal.Update(sehir);
            return new SuccessResult(Messages.EntryUpdated);
        }
    }
}
