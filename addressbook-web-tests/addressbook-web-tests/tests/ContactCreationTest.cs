using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.InitNewContactCreation();
            app.Contacts.FillContactForm(new ContactData ("testFirstName", "testLastName"));
            app.Contacts.SubmitContactCreation();
            app.Contacts.ReturnToHomePage();
            app.Auth.Logout();
        }       
    }
}
