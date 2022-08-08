using DataAccessLayer.Repositories;
using System.Windows.Documents;
using SystemBiliards.EntityLayer.InterfaceDal;
using SystemBiliards.Models;

namespace SystemBiliards.EntityLayer.Repository
{
    public class EfTableRepository : GenericRepository<Tables>, ITableDal
    {

    }
}
