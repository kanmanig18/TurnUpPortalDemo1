//open Chrome/firefox browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//Launch TurnUP Portal and aNvigate to website login
driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

//Identify username textbox and enter valid name
IWebElement loginUsernameTxtbox = driver.FindElement(By.Id("UserName"));
loginUsernameTxtbox.SendKeys("Hari");

//Identify password textbox and enter valid name
IWebElement loginPasswordTxtbox = driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
loginPasswordTxtbox.SendKeys("123123");

//Identify Login button and Click on Login button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

//Verify if the user has logged in successfully
IWebElement VerifyLogin = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (VerifyLogin.Text == "Hello hari!")
{
    Console.WriteLine("User Logged in Successfully");
}
else
{
    Console.WriteLine("User did not log in Successfully");
}

driver.Quit();


