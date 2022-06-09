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
    public class KurulusKanunManager : IKurulusKanunService
    {
        IKurulusKanunDal _kurulusKanunDal;
        public KurulusKanunManager(IKurulusKanunDal kurulusKanunDal)
        {
            _kurulusKanunDal = kurulusKanunDal;
        }
        public IResult Add(KurulusKanuns kurulusKanun)
        {
            _kurulusKanunDal.Add(kurulusKanun);

            return new SuccessResult(Messages.KurulusKanunAdded);
        }

        public IResult DeleteById(int id)
        {
            KurulusKanuns kanun = _kurulusKanunDal.Get(k => k.Id == id);
            _kurulusKanunDal.Delete(kanun);
            return new SuccessResult(Messages.EntryDeleted);
        }

        public IDataResult<List<KurulusKanuns>> GetAll()
        {
            return new SuccessDataResult<List<KurulusKanuns>>(_kurulusKanunDal.GetAll(), Messages.EntrysListed);
        }

        public IDataResult<KurulusKanuns> GetById(int id)
        {
            return new SuccessDataResult<KurulusKanuns>(_kurulusKanunDal.Get(k => k.Id == id));
        }

        public IResult Update(KurulusKanuns kurulusKanun)
        {
            _kurulusKanunDal.Update(kurulusKanun);
            return new SuccessResult(Messages.EntryUpdated);
        }
    }
}
