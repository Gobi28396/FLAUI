using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.Core.Conditions;
using System.Linq;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using System.Windows;
using System.Windows.Media;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var application = FlaUI.Core.Application.Launch("Notepad.exe");
          
            var main = application.GetMainWindow(new UIA3Automation());
            ConditionFactory c = new ConditionFactory(new UIA3PropertyLibrary());
            var a=main.FindFirstDescendant();
            a.AsTextBox().Enter("hiiii");
            /*var me=main.FindChildAt(3).AsMenu();
            me.DrawHighlight();
            me.Items[0].Invoke();
            */Keyboard.Pressing(VirtualKeyShort.CONTROL);
            Keyboard.Press(VirtualKeyShort.KEY_S);
            Keyboard.Release(VirtualKeyShort.CONTROL);
            var g=main.FindFirstDescendant(c.ByControlType(FlaUI.Core.Definitions.ControlType.Edit));
           
            Keyboard.Press(VirtualKeyShort.BACK);
            Keyboard.Press(VirtualKeyShort.KEY_H);
            Keyboard.Press(VirtualKeyShort.KEY_I);

            Keyboard.Press(VirtualKeyShort.ENTER);

            Keyboard.TypeSimultaneously(VirtualKeyShort.CONTROL, VirtualKeyShort.KEY_A);
            Keyboard.TypeSimultaneously(VirtualKeyShort.CONTROL, VirtualKeyShort.KEY_H);
          }
        [TestMethod]
        public void notepad1()
        {
            var application = FlaUI.Core.Application.Launch("Notepad.exe");

            var main = application.GetMainWindow(new UIA3Automation());
            ConditionFactory c = new ConditionFactory(new UIA3PropertyLibrary());
            main.FindFirstDescendant().AsTextBox().Enter("hloo");
            main.FindChildAt(3).AsMenu().Items[0].Click();
            main.FindFirstDescendant(c.ByAutomationId("3")).AsMenuItem().Click();
            Keyboard.Press(VirtualKeyShort.BACK);
            Keyboard.Type("myfile");
            Keyboard.Press(VirtualKeyShort.ENTER);

        }
        [TestMethod]
        public void notepad2()
        {
            var application = FlaUI.Core.Application.Launch("Notepad.exe");

            var main = application.GetMainWindow(new UIA3Automation());
            ConditionFactory c = new ConditionFactory(new UIA3PropertyLibrary());
            main.FindFirstDescendant().AsTextBox().Enter("HOW");
            Keyboard.TypeSimultaneously(VirtualKeyShort.CONTROL, VirtualKeyShort.KEY_A);
            main.FindChildAt(3).AsMenu().Items[1].Click();
            main.FindFirstDescendant(c.ByAutomationId("23")).AsMenuItem().Click();
            main.FindFirstDescendant(c.ByAutomationId("1153")).AsTextBox().Enter("gobi");
            main.FindFirstDescendant(c.ByAutomationId("1")).AsButton().Click();

            main.FindFirstDescendant(c.ByAutomationId("1024")).AsButton().Click();


        }
        [TestMethod]
        public void fonts()
        {
            var application = FlaUI.Core.Application.Launch("Notepad.exe");

            var main = application.GetMainWindow(new UIA3Automation());
            ConditionFactory c = new ConditionFactory(new UIA3PropertyLibrary());
            main.FindFirstDescendant().AsTextBox().Enter("how How ARE you");
            Keyboard.TypeSimultaneously(VirtualKeyShort.CONTROL, VirtualKeyShort.KEY_A);
            main.FindChildAt(3).AsMenu().Items[2].Click();
            main.FindFirstDescendant(c.ByAutomationId("33")).AsMenuItem().Click();
            Keyboard.Press(VirtualKeyShort.BACK);
            Keyboard.Type("times new roman");
            Keyboard.Press(VirtualKeyShort.TAB);
            Keyboard.Type("italic");
            Keyboard.Press(VirtualKeyShort.TAB);
            Keyboard.Type("14");
            Keyboard.Press(VirtualKeyShort.TAB);
            Keyboard.Press(VirtualKeyShort.ENTER);
        }

        [TestMethod]
        public void version()
        {

            var application = FlaUI.Core.Application.Launch("Notepad.exe");
            var main = application.GetMainWindow(new UIA3Automation());
            ConditionFactory c = new ConditionFactory(new UIA3PropertyLibrary());
            main.FindChildAt(3).AsMenu().Items[4].Click();
            main.FindFirstDescendant(c.ByAutomationId("65")).AsMenuItem().Click();
            var text = main.FindFirstDescendant(c.ByName("Version 1809 (OS Build 17763.1217)"));
            Console.WriteLine(text.Name);


        }



    }
}
