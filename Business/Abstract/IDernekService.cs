using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDernekService
    {
        IDataResult<List<Derneks>> GetAll();
        IDataResult<List<Derneks>> GetAllBySehirId(int id);
        IDataResult<List<Derneks>> GetAllByBkBolgesId(int id);
        IDataResult<List<Derneks>> GetAllByCrcmKurulusUyelikFormId(int id);
        IDataResult<List<Derneks>> GetAllByKurulusKanunId(int id);
        IDataResult<Derneks> GetById(int dernekId);
        IResult Add(Derneks dernek);
        IResult Update(Derneks dernek);

    }
}
