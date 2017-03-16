using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAdvance.Assignment.Core.Interfaces;
using WebAdvance.Assignment.Core.Membership;

namespace WebAdvance.Assignment.EntityFramework.Repositories
{
    public class TesterRepository : ITesterRepository
    {
        private DatabaseContext _dbContext;
        public TesterRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Tester tester)
        {
            _dbContext.Testers.Add(tester);
        }

        public void Update(Tester tester)
        {
            _dbContext.Testers.Attach(tester);
            var entry = _dbContext.Entry(tester);
            entry.State = EntityState.Modified;
        }

        public Tester FindById(int TesterId)
        {
            return _dbContext.Testers.Find(TesterId);
        }

        public IEnumerable<Tester> GetTesters()
        {
            return _dbContext.Testers.ToList();
        }

        public void Remove(int testerId)
        {
            var entry = _dbContext.Testers.Find(testerId);
            if (entry != null)_dbContext.Testers.Remove(entry);
        }
    }
}
