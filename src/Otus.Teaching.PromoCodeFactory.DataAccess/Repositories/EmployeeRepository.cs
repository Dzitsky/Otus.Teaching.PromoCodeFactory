using Microsoft.EntityFrameworkCore;
using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.Core.Domain;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace Otus.Teaching.PromoCodeFactory.DataAccess.Repositories
{
    public class EmployeeRepository: IRepository<Employee>
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public Task CreateAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> FindAsync(Expression<Func<Employee, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        //public async Task<IList<Employee>> GetAllAsync()
        //{
        //    List<Employee> result = _context.Set<Employee>().Include(r => r.Role).ToList();

        //    return result;

        //}

        public Task<Employee> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetRangeByIdsAsync(List<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAllAsync()
        {
            IEnumerable<Employee> result = _context.Set<Employee>().Include(r => r.Role).ToList();

            return Task.FromResult(result);
        }

        //public async Task CreateAsync(T entity)
        //{
        //    await _context.Set<T>().AddAsync(entity);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(T entity)
        //{
        //    _context.Set<T>().Remove(entity);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<T>> GetAllAsync()
        //{
        //    return await _context.Set<T>().AsNoTracking().ToListAsync();
        //}

        //public async Task<IEnumerable<T>> GetRangeByIdsAsync(List<Guid> ids)
        //{
        //    return await _context.Set<T>().Where(x => ids.Contains(x.Id)).ToListAsync();
        //}

        //public async Task<T> GetByIdAsync(Guid id)
        //{
        //    return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        //}

        //public async Task UpdateAsync(T entity)
        //{
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        //{
        //    return await _context.Set<T>().Where(predicate).ToListAsync();
        //}
    }
}
