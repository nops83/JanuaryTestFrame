using FluentAssertions;
using JanuaryTestFrame.Hooks;
using OpenQA.Selenium;



namespace JanuaryTestFrame;


public class Automation101A : HooksPage
{
    //Globalization is where you declare the project globalize
    //Inheritance
    // MyObjects myObjects = new MyObjects();          

    [Test, TestCaseSource(nameof(Mydata))]
    public void TestExample01(string url, string username, string password)
    {
        


        // Fill my login detail
        driverMethods.FindMyElement(driver, "name", "email", username);
        driverMethods.FindMyElement(driver, "name", "password", password);

        //Click on login buttom
        driverMethods.FindMyElementAndClick(driver, "[data-qa='login-button']").Click();
        var loggedInName = driver.FindElement(By.XPath("//li//i[@class='fa fa-user']//parent::a/b"));
        
        // Fluent Assertion
        var name = loggedInName.Text;
        Assert.That(name.Equals("Test010")); //NUnit Assertion
        name.Should().Be("Test010");
        IWebElement logout = driver.FindElement(By.LinkText("Logout"));
        logout.Click();


       

    }
    [Test]
    public void POMBasics()
    {
        //Git respitory -Code or project is stored - Code
        //Different types -1. Git 2.Azure Devops 3. Jenkins 4. Sauce Lab 5. Git Lab

    }
}


