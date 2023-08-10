using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace TestingProject.KeyBord_Actions
{
    /// <summary>
    /// purpose  of ths class is to perform actions on keyboard
    /// </summary>
    [TestClass ]
    public class keyboardClass
    {
       
        [TestMethod]
        [TestCategory("keyboard action")]
        public void Keyboard_Test()
        {
            IWebDriver driver =new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            Actions action=new Actions(driver);
          IWebElement searchBox= driver.FindElement(By.Id("twotabsearchtextbox"));
            action.MoveToElement(searchBox).DoubleClick().Build().Perform();
            InputSimulator inputSimulator = new InputSimulator();
            KeyboardSimulator keyboard = new KeyboardSimulator(inputSimulator);
            keyboard.KeyDown(VirtualKeyCode.SHIFT);
            keyboard.KeyPress(VirtualKeyCode.VK_P);
            keyboard.KeyPress(VirtualKeyCode.VK_U);
            keyboard.KeyPress(VirtualKeyCode.VK_M);
            keyboard.KeyPress(VirtualKeyCode.VK_A);
            keyboard.KeyUp(VirtualKeyCode.SHIFT);     

            keyboard.KeyPress(VirtualKeyCode.SPACE);

            keyboard.KeyPress(VirtualKeyCode.CAPITAL);
            keyboard.KeyPress(VirtualKeyCode.VK_T);
            keyboard.KeyPress(VirtualKeyCode.CAPITAL);

            keyboard.KeyPress(VirtualKeyCode.SPACE);

            keyboard.KeyPress(VirtualKeyCode.VK_S);
            keyboard.KeyPress(VirtualKeyCode.VK_H);
            keyboard.KeyPress(VirtualKeyCode.VK_I);
            keyboard.KeyPress(VirtualKeyCode.VK_R);
            keyboard.KeyPress(VirtualKeyCode.VK_T);

            keyboard.KeyPress(VirtualKeyCode.RETURN); //Enter

            //output =PUMA T shiirt
        }
    }
}
