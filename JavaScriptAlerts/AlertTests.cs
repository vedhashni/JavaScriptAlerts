/*summary :JavaScripts alert automation
  Author: Vedhashni V
  Date  : 13-09-21
*/

using NUnit.Framework;


namespace JavaScriptAlerts
{
    public class AlertTests:Base.BaseClass
    { 

        //object is created for invoking the methods for alert opearations
        JavaScriptAlertOperations operations = new JavaScriptAlertOperations();

        //Order is used to run the test method in priority wise

        //Test method is created for alert button 
        [Test, Order(0)]
        public void TestAlertMethod()
        {
            operations.AlertMethod(driver);
            
        }

        //Test method is created for confirm button
        [Test, Order(1)]
        public void TestConfirmMethod()
        {
            operations.ConfirmMethod(driver);
        }

        //Test method is created for dismiss button
        [Test, Order(2)]
        public void TestDismissMethodForConfirm()
        {
            operations.DismissMethodForConfirm(driver);
        }

        //Test method for prompt button
        [Test, Order(3)]
        public void TestPromptMethod()
        {
            operations.PromptMethod(driver);
        }

        //Test method is created for dismiss button
        [Test, Order(4)]
        public void TestPromptForDismissMethod()
        {
            operations.DismissMethodForPrompt(driver);
        }
    }
}