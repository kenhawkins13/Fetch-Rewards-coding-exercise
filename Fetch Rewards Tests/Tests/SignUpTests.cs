using AppiumTests.HelperMethods;
using AppiumTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace FetchRewardsTests.Tests
{
    [TestFixture]
    public class SignUpTests
    {
        private AndroidDriver<AndroidElement> _driver;
        private SignUpPage signUpPage;
        private SignUpWithEmailPage signUpWithEmailPage;

        [OneTimeSetUp]
        public void Setup()
        {
            _driver = Driver.GetDriver();
            signUpPage = new SignUpPage(_driver);
            signUpWithEmailPage = new SignUpWithEmailPage(_driver);
        }

        // I did not want to constantly create new accounts with random GUIDs on your server
        // So I changed the test to assert that the dialog appears, "Oops! An acount with this email address alread exists."
        [Test]
        public void SignUpWithEmail_EnterExistingEmail_GetWarning()
        {
            // Arrange
            WebDriverWait wait = new WebDriverWait(_driver, System.TimeSpan.FromSeconds(10));

            // Act
            signUpPage.SignUpWithEmail("Bob", "Smith", "bsmith@email.com", "password1");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("android:id/message")));

            // Assert
            Assert.IsTrue(signUpWithEmailPage.MessageDialog.Displayed);
            Assert.AreEqual("An account with this email address already exists.", signUpWithEmailPage.MessageDialog.Text);
        }
    }
}