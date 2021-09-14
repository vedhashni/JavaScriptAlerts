using NUnit.Framework;

namespace JavaScriptAlerts
{
    public class Tests:Base.BaseClass
    {
        JavaScriptAlertOperations operations = new JavaScriptAlertOperations();

        [Test, Order(0)]
        public void TestAlertMethod()
        {
            operations.AlertMethod(driver);
        }

        [Test, Order(1)]
        public void TestConfirmMethod()
        {
            operations.ConfirmMethod(driver);
        }

        [Test, Order(2)]
        public void TestDismissMethod()
        {
            operations.DismissMethod(driver);
        }

        [Test, Order(3)]
        public void TestPromptMethod()
        {
            operations.PromptMethod(driver);
        }
    }
}