using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCWorkMSTestFramework.Configuration;

namespace PCWorkMSTestFramework.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();//26. As "BrowserType" is not recognise,, go and create a class "BrowserType" in 
        //configuration folder
        string GetUsername();
        string GetPassword();
        string GetWebsite(); // you will note that what you have added here is inherited somewhere, in "AppConfig"
        int GetPageLoadtimeout();


    }
}
