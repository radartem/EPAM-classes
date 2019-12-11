using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework;
using Framework.Test;
using Framework.Services;
using Framework.Model;

namespace Framework.Test
{
    [TestFixture]
    public class ConsultationFormTest : CommonConditions
    {
        [Test]
        public void SendBlankEMail()
        {
            string expectingMessage = ErrorCreater.MessageWithEmptyFields();


            string errorMessage = (new StartPage(webDriver).OpenPage() as StartPage)
                                                .GoToContactsPage()
                                                .SendMessage()
                                                .GetMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        public void SendEMailIncorrectEMailAdr()
        {
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