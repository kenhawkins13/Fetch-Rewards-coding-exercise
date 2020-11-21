using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTests.PageObjects
{
    public class SignUpWithEmailPage
    {
        private readonly AndroidDriver<AndroidElement> _driver;
        public SignUpWithEmailPage(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
        }
        public IWebElement FirstNameField => _driver.FindElementById("com.fetchrewards.fetchrewards.hop:id/tiet_signup_name");
        public IWebElement LastNameField => _driver.FindElementById("com.fetchrewards.fetchrewards.hop:id/tiet_signup_last_name");
        public IWebElement EmailField => _driver.FindElementById("com.fetchrewards.fetchrewards.hop:id/tiet_signup_email");
        public IWebElement ConfirmEmailField => _driver.FindElementById("com.fetchrewards.fetchrewards.hop:id/tiet_signup_email_confirm");
        public IWebElement PasswordField => _driver.FindElementById("com.fetchrewards.fetchrewards.hop:id/tiet_signup_password");
        public IWebElement SignUpButton => _driver.FindElementById("com.fetchrewards.fetchrewards.hop:id/sign_up_button");
        public IWebElement MessageDialog => _driver.FindElementById("android:id/message");
    }
}
