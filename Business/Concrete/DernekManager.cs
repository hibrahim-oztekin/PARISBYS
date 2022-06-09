using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
    public class DernekManager : IDernekService
    {
        IDernekDal _dernekDal;
        public DernekManager(IDernekDal dernekDal)
        {
            _dernekDal = dernekDal;
        }
        [ValidationAspect(typeof(DernekValidator))]
        public IResult Add(Derneks dernek)
        {
            IResult result = BusinessRules.Run(CheckIfDernekNameExists(dernek.Ad));

            if (result!=null)
            {
                return new ErrorResult(result.Message);               
            }
            _dernekDal.Add(dernek);
            return new SuccessResult(Messages.DernekAdded);
        }

        private IResult CheckIfDernekNameExists(string ad)
        {
            var result = _dernekDal.GetAll(d => d.Ad == ad).Any();
            if (result)
            {
                return new ErrorResult(Messages.DernekNameAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<List<Derneks>> GetAll()
        {
            return new SuccessDataResult<List<Derneks>>(_dernekDal.GetAll(), Messages.DernekListed);
        }

        public IDataResult<List<Derneks>> GetAllByBkBolgesId(int id)
        {
            return new SuccessDataResult<List<Derneks>>(_dernekDal.GetAll(d => d.BkBolgesId == id));
        }

        public IDataResult<List<Derneks>> GetAllByCrcmKurulusUyelikFormId(int id)
        {
            return new SuccessDataResult<List<Derneks>>(_dernekDal.GetAll(d => d.CrcmUyelikFormDurumId == id));
        }

        public IDataResult<List<Derneks>> GetAllByKurulusKanunId(int id)
        {
            return new SuccessDataResult<List<Derneks>>(_dernekDal.GetAll(d => d.KurulusKanunId == id));
        }

        public IDataResult<List<Derneks>> GetAllBySehirId(int id)
        {
            return new SuccessDataResult<List<Derneks>>(_dernekDal.GetAll(d => d.SehirId == id));
        }

        public IDataResult<Derneks> GetById(int dernekId)
        {
            return new SuccessDataResult<Derneks>(_dernekDal.Get(d => d.Id == dernekId));
        }

        public IResult Update(Derneks dernek)
        {
            _dernekDal.Update(dernek);
            return new SuccessResult(Messages.DernekUpdated);
        }
    }
}
