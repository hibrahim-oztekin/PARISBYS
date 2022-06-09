using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CrcmUyelikFormDurumManager:ICrcmUyelikFormDurumService
    {
        ICrcmUyelikFormDurumDal _crcmUyelikFormDurumDal;

        public CrcmUyelikFormDurumManager(ICrcmUyelikFormDurumDal crcmUyelikFormDurumDal)
        {
            _crcmUyelikFormDurumDal = crcmUyelikFormDurumDal;
        }

        public IResult Add(CrcmUyelikFormDurums crcmUyelikDurum)
        {
            _crcmUyelikFormDurumDal.Add(crcmUyelikDurum);
            return new SuccessResult(Messages.CrcmUyelikFormDurumAdded);
        }

        public IResult DeleteById(int id)
        {
            _crcmUyelikFormDurumDal.Delete(_crcmUyelikFormDurumDal.Get(c => c.Id == id));
            return new SuccessResult(Messages.CrcmUyelikFormDurumDeleted);
        }

        public IDataResult<List<CrcmUyelikFormDurums>> GetAll()
        {
            return new SuccessDataResult<List<CrcmUyelikFormDurums>>(_crcmUyelikFormDurumDal.GetAll(), Messages.CrcmUyelikDurumListed);
        }

        public IDataResult<CrcmUyelikFormDurums> GetById(int id)
        {
            return new SuccessDataResult<CrcmUyelikFormDurums>(_crcmUyelikFormDurumDal.Get(c => c.Id == id));
        }

        public IResult Update(CrcmUyelikFormDurums crcmUyelikDurum)
        {
            _crcmUyelikFormDurumDal.Update(crcmUyelikDurum);
            return new SuccessResult(Messages.CrcmUyelikFormUpdated);
        }
    }
}
