using JavaScriptAlerts.JavaScriptElements;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace JavaScriptAlerts
{
    public class JavaScriptAlertOperations
    {
        public static AlertElements alert1;
        

        public void AlertMethod(IWebDriver driver)
        {
            alert1 = new AlertElements(driver);
            var expectedAlertText = "I am a JS Alert";
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            //Intializing the alert button 
            IWebElement alertbutton = alert1.alert;
            alertbutton.Click();
            var alert_pass = driver.SwitchTo().Alert();
            //Checking the expected text and actual text are equal
            Assert.AreEqual(expectedAlertText, alert_pass.Text);
            //in alert popup okay button is clicked by using accept
            alert_pass.Accept();

            var alertresult = alert1.buttonclick;

            Console.WriteLine(alertresult.Text);

            if (alertresult.Text == "You successfuly clicked an alert")
            {
                Console.WriteLine("Alert Test Successful");
            }
        }
        public void ConfirmMethod(IWebDriver driver)
        {
            alert1 = new AlertElements(driver);
            var expectedConfirmText = "I am a JS Confirm";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            //Intializing the confirm button
            IWebElement confirmButton = alert1.confirm;
            confirmButton.Click();
            var confirm_pass = driver.SwitchTo().Alert();
            //Checking the expected text and actual text are equal
            Assert.AreEqual(expectedConfirmText, confirm_pass.Text);
            //in confirm popup okay button is clicked by using accept
            confirm_pass.Accept();

            IWebElement confirmresult = alert1.buttonclick;
            Console.WriteLine(confirmresult.Text);

            if (confirmresult.Text == "You clicked: Ok")
            {
                Console.WriteLine("Confirm Test Successful");
            }
        }

        public void DismissMethodForConfirm(IWebDriver driver)
        {
            alert1 = new AlertElements(driver);
            var expectedDismissText = "I am a JS Confirm";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            //Intializing the confirm button
            IWebElement dismissButton = alert1.confirm;

            dismissButton.Click();

            var dismiss_pass = driver.SwitchTo().Alert();
            //Checking the expected text and actual text are equal
            Assert.AreEqual(expectedDismissText, dismiss_pass.Text);
            //in confirm popup cancel button is clicked by using dismiss
            dismiss_pass.Dismiss();

            IWebElement dismissresult = alert1.buttonclick;
            Console.WriteLine(dismissresult.Text);

            if (dismissresult.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successful");
            }
        }

        public void PromptMethod(IWebDriver driver)
        {
            alert1 = new AlertElements(driver);
            var expectedPromtText = "I am a JS prompt";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            //Intializing the prompt button
            IWebElement promptButton = alert1.prompt;
            promptButton.Click();

            var prompt_pass = driver.SwitchTo().Alert();
            //Checking the expected text and actual text are equal
            Assert.AreEqual(expectedPromtText, prompt_pass.Text);
            //sending the message to the prompt tex field
            prompt_pass.SendKeys("Prompt Message Is Added");
            //in prompt popup okay button is clicked by using accept
            prompt_pass.Accept();

            IWebElement promptresult = alert1.buttonclick;
            Console.WriteLine(promptresult.Text);

            if (promptresult.Text == "You entered: This is a test alert message")
            {
                Console.WriteLine("Send Text Alert Test Successful");
            }
        }

        public void DismissMethodForPrompt(IWebDriver driver)
        {
            alert1 = new AlertElements(driver);
            var expectedPromtText = "I am a JS prompt";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1000));
            //Intializing the prompt button
            IWebElement promptButton = alert1.prompt;
            promptButton.Click();

            var prompt_pass = driver.SwitchTo().Alert();
            //Checking the expected text and actual text are equal
            Assert.AreEqual(expectedPromtText, prompt_pass.Text);
            //sending the message to the prompt tex field
            prompt_pass.SendKeys("Prompt Message Is Added");
            //in prompt popup okay button is clicked by using accept
            prompt_pass.Dismiss();

            IWebElement promptresult = alert1.buttonclick;
            Console.WriteLine(promptresult.Text);

            if (promptresult.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successful");
            }
        }
    }
}
