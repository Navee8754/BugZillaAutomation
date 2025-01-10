using SeliniumWebDriver.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetUsername();
        string GetPassword();

        string GetWebsite();
        int GetPageLoadTimeOut();
        int GetElementLoadTimeOut();
    }
}
