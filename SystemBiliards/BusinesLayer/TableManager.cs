using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using SystemBiliards.BusinesLayer.Servises;
using SystemBiliards.EntityLayer.InterfaceDal;
using SystemBiliards.Models;

namespace SystemBiliards.BusinesLayer
{
    public class TableManager : ITableService
    {
        ITableDal _tableDal;

        public TableManager(ITableDal tableDal)
        {
            _tableDal = tableDal;
        }

        public Task DeleteAsync(Tables entity)
        {
            throw new NotImplementedException();
        }

        public Task<Tables> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Tables>> GetListAllAsync()
        {
            return await _tableDal.GetListAllAsync();
        }

        public Task<List<Tables>> GetListAllAsync(Expression<Func<Tables, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Tables entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Tables entity)
        {
            throw new NotImplementedException();
        }
    }
}
