using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICrcmUyelikFormDurumService
    {
        IDataResult<List<CrcmUyelikFormDurums>> GetAll();
        IDataResult<CrcmUyelikFormDurums> GetById(int id);
        IResult Add(CrcmUyelikFormDurums crcmUyelikDurum);
        IResult Update(CrcmUyelikFormDurums crcmUyelikDurum);
        IResult DeleteById(int id);
    }
}
