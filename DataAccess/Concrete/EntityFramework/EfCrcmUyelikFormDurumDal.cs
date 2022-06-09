using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCrcmUyelikFormDurumDal : EfEntityRepositoryBase<CrcmUyelikFormDurums, ParisDitibContext>, ICrcmUyelikFormDurumDal
    {
    }
}
