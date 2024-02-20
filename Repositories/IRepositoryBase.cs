using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace examplemvcwindowsform.Repositories
{
    public interface IRepositoryBase<T> 
    {

        Task<T> Create(T entity);
        Task<T?> FindBy(string id);
        Task<T> Update(T entity);
        Task Delete(string id);
        Task<List<T>> FindAll(int take, int slip, Expression<Func<T, bool>>? filter = null);
        Task<int> Count(Expression<Func<T, bool>>? filter = null);
        Task<List<T>> FindAll();

        
    }
}