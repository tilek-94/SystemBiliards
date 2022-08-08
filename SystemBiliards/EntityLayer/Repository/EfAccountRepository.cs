using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBiliards.Models;

namespace SystemBiliards.Test
{
    public class EfAccountRepository : GenericRepository<Accounts>, IAccountDal
    {

    }
}
