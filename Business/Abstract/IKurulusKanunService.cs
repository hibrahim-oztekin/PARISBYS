using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKurulusKanunService
    {
        IDataResult<List<KurulusKanuns>> GetAll();
        IDataResult<KurulusKanuns> GetById(int id);
        IResult Add(KurulusKanuns kurulusKanun);
        IResult Update(KurulusKanuns kurulusKanun);
        IResult DeleteById(int id);
    }
}
