using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace JavaScriptAlerts.JavaScriptElements
{
    public class AlertElements
    {
        //Used to intialize elements of a page class
        public AlertElements(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //Used to find the element by specifying its locator
        [FindsBy(How = How.XPath, Using = "//button[text()='Click for JS Alert']")]
        [CacheLookup]
        public IWebElement alert;

        //Used to find the element by specifying its cssselector locator
        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsConfirm()']")]
        [CacheLookup]
        public IWebElement confirm;

        //Used to find the element by specifying its cssselector locator for prompt button
        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsPrompt()']")]
        [CacheLookup]
        public IWebElement prompt;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement buttonclick;
    }
}
