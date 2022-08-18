using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Threading;


namespace LabExcersie
{
    [TestClass]
    public class SeleniumTest
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("Firefox","https://www.demoblaze.com/","sai@gmail.com","sai","im dev")]
        [DataRow("Chrome","https://www.demoblaze.com/","kiran@gmail.com","kiran","im tester")]
         [DataRow("Edge","https://www.demoblaze.com/","sachin@gmail.com","sachin","im player")]
        
        public void TestMethod1(string BrowserName, string url,string email,string name,string msg)
        {    
            IWebDriver driver;
            if(BrowserName=="Firefox")
            {
                 driver=new FirefoxDriver(@"C:\Users\E009146\RootFolder\WebDriver");
                
            }
            
            else if(BrowserName=="Chrome")
            {
             driver=new ChromeDriver(@"C:\Users\E009146\RootFolder\ChromeDriver");
            }
            else
            {
                driver=new EdgeDriver(@"C:\Users\E009146\RootFolder\EdgeDriver");
            }

                 driver.Navigate().GoToUrl(url);
                 IWebElement SearchText=driver.FindElement(By.LinkText("Contact"));
                  SearchText.Click();
                 
                  Thread.Sleep(4000);
                  IWebElement SearchText1=driver.FindElement(By.Id("recipient-email"));
                  SearchText1.SendKeys(email);
                  Thread.Sleep(4000);

                  IWebElement SearchText2=driver.FindElement(By.Id("recipient-name"));
                  SearchText2.SendKeys(name);
                  Thread.Sleep(4000);

                  IWebElement SearchText3=driver.FindElement(By.Id("message-text"));
                  SearchText3.SendKeys(msg);
                  Thread.Sleep(4000);

                //   IWebElement SearchText4=driver.FindElement(By.LinkText("Send Message"));
                //   SearchText4.Click();

                 // Thread.Sleep(000);
                   driver.Quit();
                   //Thread.Sleep(4000);
        
          
            }
        }
    }

