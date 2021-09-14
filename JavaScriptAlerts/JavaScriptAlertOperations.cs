using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace JavaScriptAlerts
{
    public class JavaScriptAlertOperations
    {
        public void AlertMethod(IWebDriver driver)
        {
            var expectedAlertText = "I am a JS Alert";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            IWebElement alertbutton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[text()='Click for JS Alert']")));
            alertbutton.Click();
            var alert_pass = driver.SwitchTo().Alert();

            Assert.AreEqual(expectedAlertText, alert_pass.Text);
            alert_pass.Accept();

            var alertresult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("result")));

            Console.WriteLine(alertresult.Text);

            if (alertresult.Text == "You successfuly clicked an alert")
            {
                Console.WriteLine("Alert Test Successful");
            }
        }
        public void ConfirmMethod(IWebDriver driver)
        {
            var expectedConfirmText = "I am a JS Confirm";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("button[onclick='jsConfirm()']")));

            confirmButton.Click();

            var confirm_pass = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedConfirmText, confirm_pass.Text);
            confirm_pass.Accept();

            IWebElement confirmresult = driver.FindElement(By.Id("result"));
            Console.WriteLine(confirmresult.Text);

            if (confirmresult.Text == "You clicked: Ok")
            {
                Console.WriteLine("Confirm Test Successful");
            }
        }

        public void DismissMethod(IWebDriver driver)
        {
            var expectedDismissText = "I am a JS Confirm";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            IWebElement dismissButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("button[onclick='jsConfirm()']")));

            dismissButton.Click();

            var dismiss_pass = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedDismissText, dismiss_pass.Text);
            dismiss_pass.Dismiss();

            IWebElement dismissresult = driver.FindElement(By.Id("result"));
            Console.WriteLine(dismissresult.Text);

            if (dismissresult.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successful");
            }
        }

        public void PromptMethod(IWebDriver driver)
        {
            var expectedPromtText = "I am a JS prompt";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            IWebElement promptButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.TagName("button[onclick='jsPrompt()']")));
            promptButton.Click();

            var prompt_pass = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedPromtText, prompt_pass.Text);
            prompt_pass.SendKeys("Prompt Message Is Added");
            prompt_pass.Accept();

            IWebElement promptresult = driver.FindElement(By.Id("result"));
            Console.WriteLine(promptresult.Text);

            if (promptresult.Text == "You entered: This is a test alert message")
            {
                Console.WriteLine("Send Text Alert Test Successful");
            }
        }
    }
}
