﻿using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string Url) 
        {

            ObjectRepository.Driver.Navigate().GoToUrl(Url);
        }
    }
}
