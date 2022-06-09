using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UyeManager : IUyeService
    {
        IUyeDal _uyeDal;
        public UyeManager(IUyeDal uyeDal)
        {
            _uyeDal = uyeDal;
        }
        public IResult Add(Uyes uyes)
        {
            _uyeDal.Add(uyes);
            return new SuccessResult(Messages.EntryAdded);
        }

        public IResult DeleteById(int id)
        {
            var result= _uyeDal.Get(u => u.Id == id);
            if (result !=null)
            {
                return new ErrorResult();
            }
            _uyeDal.Delete(result);
            return new SuccessResult(Messages.EntryDeleted);
        }

        public IDataResult<List<Uyes>> GetAll()
        {
            return new SuccessDataResult<List<Uyes>>(_uyeDal.GetAll(), Messages.EntrysListed);
        }

        public IDataResult<Uyes> GetById(int id)
        {
            return new SuccessDataResult<Uyes>(_uyeDal.Get(u => u.Id == id));
        }

        public IResult Update(Uyes uyes)
        {
            _uyeDal.Update(uyes);
            return new SuccessResult(Messages.EntryUpdated);
        }
    }
}
