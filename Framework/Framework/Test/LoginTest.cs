using Framework.Pages;
using Framework.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Test
{
    [TestFixture]
    public class LoginTest : CommonConditions
    {
        [Test]
        public void LoginAsRegistratedUser()
        {
            string expectingMessage = ErrorCreater.CorrectLoginAndPassword();


            string errorMessage = (new LoginPage(webDriver).OpenPage() as LoginPage)
                                    .FillInFields(UserCreater.RegregisteredUser())
                                    .Login()
                                    .GetErrorMessage();
            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        public void LoginAsRegistratedUserWithIncorrectPassword()
        {
            string expectingMessage = ErrorCreater.IncorrectLoginOrPassword();


            string errorMessage = (new LoginPage(webDriver).OpenPage() as LoginPage)
                                    .FillInFields(UserCreater.NonRegregisteredUser())
                                    .Login()
                                    .GetErrorMessage();
            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        public void LoginAsNonRegistratedUser()
        {
            string expectingMessage = ErrorCreater.IncorrectLoginOrPassword();


            string errorMessage = (new LoginPage(webDriver).OpenPage() as LoginPage)
                                    .FillInFields(UserCreater.NonRegregisteredUser())
                                    .Login()
                                    .GetErrorMessage();
            Assert.AreEqual(expectingMessage, errorMessage);
        }
    }
}
