﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PCWorkMSTestFramework.ComponentHelper
{
    public class TextboxHelper
    {
        private static IWebElement element;

        public static void SendTextToTextbox(By locator, string text)
        {
            element = GenericClassHelper.GetElement(locator);
            element.SendKeys(text);
        }

        public static void ClearTextBox(By locator)
        {
            element = GenericClassHelper.GetElement(locator);
            element.Clear();

        }

        internal static void SendTextToTextbox(By _firstname, DataRow dataRow)
        {
            throw new NotImplementedException();
        }
    }
}
