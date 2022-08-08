using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SystemBiliards.Models;

namespace SystemBiliards.Test.Bisnes
{
    public class AccountManager : IAccountService
    {
        IAccountDal _accountDal;

        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public Task DeleteAsync(Accounts entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Accounts> GetByIdAsync(int id)
        {
            return await _accountDal.GetByIdAsync(id);
        }

        public async Task<List<Accounts>> GetListAllAsync()
        {
            return await _accountDal.GetListAllAsync();
        }

        public Task<List<Accounts>> GetListAllAsync(Expression<Func<Accounts, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Accounts entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Accounts entity)
        {
            throw new NotImplementedException();
        }
    }
}
