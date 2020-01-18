using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework;
using Framework.Test;
using Framework.Services;
using Framework.Model;
using Framework.Utils;

namespace Framework.Test
{
    [TestFixture]
    public class ConsultationFormTest : CommonConditions
    {
        [Test]
        [Category("FormTest")]
        public void SendBlankEMail()
        {
            Logger.Log.Info("Start SendBlankEMail unit test.");
            string expectingMessage = ErrorCreater.MessageWithEmptyFields();


            string errorMessage = (new StartPage(webDriver).OpenPage() as StartPage)
                                                .GoToContactsPage()
                                                .SendMessage()
                                                .GetMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        [Category("FormTest")]
        public void SendEMailIncorrectEMailAdr()
        {
            Logger.Log.Info("Start SendEMailIncorrectEMailAdr unit test.");

            string expectingMessage = ErrorCreater.MessageWithInvalidEMail();

            Message message = MessageCreater.WithAllProperties();

            string errorMessage = (new StartPage(webDriver).OpenPage() as StartPage)
                                                .GoToContactsPage()
                                                .FillInFields(message)
                                                .SendMessage()
                                                .GetMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }

    }
}