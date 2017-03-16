using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAdvance.Assignment.Core.Membership;

namespace WebAdvance.Assignment.Core.Interfaces
{
    public interface ITesterRepository
    {
        void Add(Tester tester);
        void Update(Tester tester);
        void Remove(int testerId);
        IEnumerable<Tester> GetTesters();
        Tester FindById(int TesterId);
    }
}
