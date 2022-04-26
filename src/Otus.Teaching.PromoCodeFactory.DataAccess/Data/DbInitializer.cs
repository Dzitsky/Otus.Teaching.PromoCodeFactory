using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;
using System.Linq;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Data
{
    public class DbInitializer : IDbInitializer
    {
        private ApplicationDbContext _context { get; set; }

        public DbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Init()
        {
            if (!_context.Roles.Any())
            {
                _context.Roles.AddRange(FakeDataFactory.Roles);
                _context.SaveChanges();
            }

            if (!_context.Employees.Any())
            {
                _context.Employees.AddRange(FakeDataFactory.Employees);
                _context.SaveChanges();
            }

            if (!_context.Preferences.Any())
            {
                _context.Set<Preference>().AddRange(FakeDataFactory.Preferences);
                _context.SaveChanges();
            }

            if (!_context.Customers.Any())
            {
                _context.Set<Customer>().AddRange(FakeDataFactory.Customers);
                _context.SaveChanges();
            }

            if (!_context.Partners.Any())
            {
                _context.Set<Partner>().AddRange(FakeDataFactory.Partners);
                _context.SaveChanges();
            }
        }
    }
}