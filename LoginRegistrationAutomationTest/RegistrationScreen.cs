using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;

namespace LoginRegistrationAutomationTest
{
    [TestClass]
    public class RegistrationScreen
    {
        [TestMethod]
        public void RegisterUser_NewUser_RegistrationSuccess()
        {
            var application = Application.Launch(@"E:\Uni\UniDocs\Year3\Case Studies in SoftwareDesign\Assessment\L&R\LoginAndRegistration\LoginAndRegistration\bin\Debug\LoginAndRegistration.exe");

            var mainWindow = application.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtUsername")).AsTextBox().Enter("AUTO_USERNAME");

            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtPassword")).AsTextBox().Enter("AUTO_PASSWORD");

            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtConPassword")).AsTextBox().Enter("AUTO_PASSWORD");

            mainWindow.FindFirstDescendant(cf.ByAutomationId("CheckboxShowPas")).AsButton().Click();

            mainWindow.FindFirstDescendant(cf.ByAutomationId("RegisterButton")).AsButton().Click();

        }

        [TestMethod]
        public void ClearFields_FieldsFilledUp_ClearedFields()
        {
            var application = Application.Launch(@"E:\Uni\UniDocs\Year3\Case Studies in SoftwareDesign\Assessment\L&R\LoginAndRegistration\LoginAndRegistration\bin\Debug\LoginAndRegistration.exe");

            var mainWindow = application.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtUsername")).AsTextBox().Enter("CLEAR_TEST");

            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtPassword")).AsTextBox().Enter("CLEAR_TEST");

            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtConPassword")).AsTextBox().Enter("CLEAR_TEST");

            mainWindow.FindFirstDescendant(cf.ByAutomationId("CheckboxShowPas")).AsButton().Click();

            mainWindow.FindFirstDescendant(cf.ByAutomationId("ClearButton")).AsButton().Click();
        }

        /*[TestMethod]
        public void LoginExistingUser_ExistingUser_LoginSuccess()
        {
            var application = Application.Launch(@"E:\Uni\UniDocs\Year3\Case Studies in SoftwareDesign\Assessment\L&R\LoginAndRegistration\LoginAndRegistration\bin\Debug\LoginAndRegistration.exe");

            var mainWindow = application.GetMainWindow(new UIA3Automation());
            ConditionFactory conditionFactory = new ConditionFactory(new UIA3PropertyLibrary());

            mainWindow.FindFirstDescendant(conditionFactory.ByAutomationId("BackToLoginButton")).AsLabel().Click();

            mainWindow.FindFirstDescendant(conditionFactory.ByAutomationId("LoginTxtUsername")).AsTextBox().Enter("Marcus");

            mainWindow.FindFirstDescendant(conditionFactory.ByAutomationId("LoginTxtPassword")).AsTextBox().Enter("12345");

            mainWindow.FindFirstDescendant(conditionFactory.ByAutomationId("CheckboxShowPas")).AsButton().Click();

            mainWindow.FindFirstDescendant(conditionFactory.ByAutomationId("Login")).AsButton().Click();

        }*/
    }

   


}
