using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAdvance.Assignment.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAdvance.Assignment.Core.Interfaces;
using WebAdvance.Assignment.Core.Membership;
using WebAdvance.AssignmentTests.Fakes;

namespace WebAdvance.Assignment.Controllers.Tests
{
    [TestClass()]
    public class TesterControllerTests
    {
        
        [TestMethod()]
        public void CreateTesterTest()
        {
            Tester tester = new Tester()
            {
                Email = "phantrithuc@gmail.com",
                FullName = "Thuc",
                Password = "12341",
                Phone = "asd",
                UserName = "thucphan"
            };

            InMemoryTesterRepository testerRepository = new InMemoryTesterRepository();
            InMemoryUnitOfWork unitOfWork = new InMemoryUnitOfWork();

            TesterController controller = new TesterController(testerRepository, unitOfWork);
            
            controller.Create(tester);
            Assert.IsTrue(testerRepository.GetTesters().Any(q=>q.UserName.Equals("thucphan")));
         }
    }
}