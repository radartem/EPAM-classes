using Framework.Pages;
using Framework.Services;
using Framework.Utils;
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
        [Category("LoginTest")]
        public void LoginAsRegistratedUser()
        {
            Logger.Log.Info("Start LoginAsRegistratedUser unit test.");

            string expectingMessage = ErrorCreater.CorrectLoginAndPassword();


            string errorMessage = (new LoginPage(webDriver).OpenPage() as LoginPage)
                                    .FillInFields(UserCreater.RegregisteredUser())
                                    .Login()
                                    .GetErrorMessage();
            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        [Category("LoginTest")]
        public void LoginAsRegistratedUserWithIncorrectPassword()
        {
            Logger.Log.Info("Start LoginAsRegistratedUserWithIncorrectPassword unit test.");

            string expectingMessage = ErrorCreater.IncorrectLoginOrPassword();


            string errorMessage = (new LoginPage(webDriver).OpenPage() as LoginPage)
                                    .FillInFields(UserCreater.NonRegregisteredUser())
                                    .Login()
                                    .GetErrorMessage();
            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        [Category("LoginTest")]
        public void LoginAsNonRegistratedUser()
        {
            Logger.Log.Info("Start LoginAsNonRegistratedUser unit test.");

            string expectingMessage = ErrorCreater.IncorrectLoginOrPassword();


            string errorMessage = (new LoginPage(webDriver).OpenPage() as LoginPage)
                                    .FillInFields(UserCreater.NonRegregisteredUser())
                                    .Login()
                                    .GetErrorMessage();
            Assert.AreEqual(expectingMessage, errorMessage);
        }
    }
}
