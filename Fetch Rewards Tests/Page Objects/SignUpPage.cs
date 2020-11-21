using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace AppiumTests.PageObjects
{
    public class SignUpPage
    {
        private readonly AndroidDriver<AndroidElement> _driver;
        private SignUpWithEmailPage signUpWithEmailPage;
        public SignUpPage(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
            signUpWithEmailPage = new SignUpWithEmailPage(_driver);
        }

        public IWebElement SignUpWithEmailButton => _driver.FindElementById("com.fetchrewards.fetchrewards.hop:id/email_signup_button");

        public void SignUpWithEmail(string FirstName, string LastName, string Email, string Password)
        {
            this.SignUpWithEmailButton.Click();
            signUpWithEmailPage.FirstNameField.SendKeys(FirstName);
            signUpWithEmailPage.LastNameField.SendKeys(LastName);
            signUpWithEmailPage.EmailField.SendKeys(Email);
            signUpWithEmailPage.ConfirmEmailField.SendKeys(Email);
            signUpWithEmailPage.PasswordField.SendKeys(Password);
            signUpWithEmailPage.SignUpButton.Click();
        }
    }
}
