using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework;
using Framework.Test;
using Framework.Services;
using Framework.Pages;
using Framework.Utils;

namespace Framework.Test
{
    [TestFixture]
    public class OrderTest : CommonConditions
    {
        [Test]
        [Category("OrderTest")]
        public void StartDateLeaseEndDate()
        {
            Logger.Log.Info("Start StartDateLeaseEndDate unit test.");

            string expectingMessage = ErrorCreater.StartDateLeaseEndDate();

            string errorMessage = (new StartPage(webDriver).OpenPage() as StartPage)
                                            .SetDateStartFromDefault(2)
                                            .SetDateEndFromDefault(-3)
                                            .ClickSubmitButton()
                                            .GetErrorMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        [Category("OrderTest")]
        public void SimilarStartDateAndEndDate()
        {
            Logger.Log.Info("Start SimilarStartDateAndEndDate unit test.");

            string expectingMessage = ErrorCreater.SimilarStartDateAndEndDate();

            string errorMessage = (new StartPage(webDriver).OpenPage() as StartPage)
                                            .SetDateStartFromDefault(1)
                                            .SetDateEndFromDefault(-2)
                                            .ClickSubmitButton()
                                            .GetErrorMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        [Category("PositiveTest")]
        public void SendOrderPositiveTest()
        {
            Logger.Log.Info("Start SendOrderPositiveTest unit test.");

            string expectingMessage = ErrorCreater.UserWithZeroExp();

            string errorMessage = (new StartPage(webDriver).OpenPage() as StartPage)
                                            .ClickSubmitButton()
                                            .TakeMoreInformationAboutFirstOrder()
                                            .SetDateStartFromDefault(1)
                                            .SetDateEndFromDefault(1)
                                            .SubmitOrderСhoice()
                                            .FillInUserData(UserCreater.UserWithZeroExperience())
                                            .SubmitOrder()
                                            .GetErrorMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        [Category("OrderTest")]
        public void SendOrderWithZeroExperience()
        {
            Logger.Log.Info("Start SendOrderWithZeroExperience unit test.");

            string expectingMessage = ErrorCreater.UserWithZeroExp();

            string errorMessage = (new OrderRegistrationPage(webDriver).OpenPage() as OrderRegistrationPage)
                                            .FillInUserData(UserCreater.UserWithZeroExperience())
                                            .SubmitOrder()
                                            .GetErrorMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        [Category("PositiveTest")]
        public void FindAllOrdersPositiveTest()
        {
            Logger.Log.Info("Start FindAllOrdersPositiveTest unit test.");

            Assert.False((new StartPage(webDriver).OpenPage() as StartPage)
                                            .ClickSubmitButton()
                                            .ResetFilters()
                                            .SubmitFilterOptions()
                                            .IsCarListEmpty());
        }
    }
}
