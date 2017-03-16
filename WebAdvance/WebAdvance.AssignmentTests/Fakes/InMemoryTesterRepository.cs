using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAdvance.Assignment.Core.Interfaces;
using WebAdvance.Assignment.Core.Membership;

namespace WebAdvance.AssignmentTests.Fakes
{
    public class InMemoryTesterRepository : ITesterRepository
    {
        private readonly List<Tester> _testers;
        public InMemoryTesterRepository()
        {
            _testers = new List<Tester>();
        }

        public void Add(Tester tester)
        {
            _testers.Add(tester);
        }

        public Tester FindById(int TesterId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tester> GetTesters()
        {
            return _testers;
        }

        public void Remove(int testerId)
        {
            throw new NotImplementedException();
        }

        public void Update(Tester tester)
        {
            throw new NotImplementedException();
        }
    }
}
