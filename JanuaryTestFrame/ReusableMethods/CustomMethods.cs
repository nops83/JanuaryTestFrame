using OpenQA.Selenium.Chrome;


namespace JanuaryTestFrame.ReusableMethods;

public class CustomMethods
{
    public ChromeOptions MaximizeChromeBrowser()
    {
        ChromeOptions opt = new ChromeOptions();
        opt.AddArguments("--start-Maximized","incognito");
        return opt;
    }
}
