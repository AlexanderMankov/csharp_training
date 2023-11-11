using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitNewGroupCreation();
            FillGroupForm(new GroupData ("testName", "testHeader", "testFooter"));
            SubmitGroupCreation();
            ReturnToGroupsPage();
            Logout();
        }                         
    }
}
