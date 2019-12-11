using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework;
using Framework.Test;
using Framework.Services;

namespace Framework.Test
{
    [TestFixture]
    public class OrderTest : CommonConditions
    {
        [Test]
        public void StartDateLeaseEndDate()
        {
            string expectingMessage = ErrorCreater.StartDateLeaseEndDate();

            string errorMessage = (new StartPage(webDriver).OpenPage() as StartPage)
                                            .SetDateStartFromDefault(2)
                                            .SetDateEndFromDefault(-3)
                                            .ClickSubmitButton()
                                            .GetErrorMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        public void SimilarStartDateAndEndDate()
        {
            string expectingMessage = ErrorCreater.SimilarStartDateAndEndDate();

            string errorMessage = (new StartPage(webDriver).OpenPage() as StartPage)
                                            .SetDateStartFromDefault(1)
                                            .SetDateEndFromDefault(-2)
                                            .ClickSubmitButton()
                                            .GetErrorMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }
    }
}
