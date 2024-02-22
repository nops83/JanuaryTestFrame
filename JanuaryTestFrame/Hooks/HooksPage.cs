using JanuaryTestFrame.Config;
using JanuaryTestFrame.ObjectRespository;
using JanuaryTestFrame.ReusableMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using static JanuaryTestFrame.Hooks.BrowserType;



namespace JanuaryTestFrame.Hooks
{
    public class HooksPage : MyObjects
    {
        ReadFromJs js = new ReadFromJs();   

        [SetUp]

        public void Setup()
        {
            // Create  object of driver
            string url = (string)Mydata().First().Arguments[0]!;
            driver = ChooseBrowser(browserType.Chrome);
            driver.Navigate().GoToUrl(url);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(double.Parse(Environment.timeout));
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(double.Parse(Environment.timeout));
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(double.Parse(Environment.timeout));
        }

        //Tanery statement
        public IWebDriver ChooseBrowser(browserType browserType)
        {
            var browser = browserType == browserType.Chrome
           ? driver = new ChromeDriver(new CustomMethods().MaximizeChromeBrowser())
           : browserType == browserType.FireFox
           ? driver = new FirefoxDriver()
           : browserType == browserType.Edge
           ? driver = new EdgeDriver()
           : throw new Exception("NO such browser exist");
            return browser;
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
            driver = null;
        }

        public static IEnumerable<TestCaseData> Mydata()
        {
            string[] datas = {
            "https://automationexercise.com/login",
            "Test010@test.com",
            "Password01!" };

            yield return new TestCaseData(datas);
        }
    }
}       

