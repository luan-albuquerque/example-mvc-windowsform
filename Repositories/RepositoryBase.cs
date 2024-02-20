using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace examplemvcwindowsform.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public Task<int> Count(Expression<Func<T, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> FindAll(int take, int slip, Expression<Func<T, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<T?> FindBy(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}