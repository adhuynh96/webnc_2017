using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAdvance.Assignment.Core.Interfaces;

namespace WebAdvance.Assignment.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        public EfUnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            _context
               .ChangeTracker
               .Entries()
               .ToList()
               .ForEach(x => x.Reload());
        }
    }
}
