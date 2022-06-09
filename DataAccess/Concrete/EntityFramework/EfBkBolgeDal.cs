using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBkBolgeDal : EfEntityRepositoryBase<BkBolges, ParisDitibContext>, IBkBolgeDal
    {

    }
}
