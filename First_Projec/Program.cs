using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


//Open the Chrome browser
IWebDriver driver = new ChromeDriver();

//Maximize the browser
driver.Manage().Window.Maximize();

//Launch TurnUp Portal and navigate to website login page 
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//Identify username textbook and enter valid username
IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
usernameTextBox.SendKeys("hari");

//Identify password textbook and enter valid password
IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
passwordTextBox.SendKeys("123123");


//Identify the login button and click on the button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

Thread.Sleep(5000);

//Check if the user has logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));


if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully");
}
else
{
    Console.WriteLine("User hasn't been logged in.");
}

//Test Case - Create a new Time record

//Navigate to Time & Material module (Click on Administration -> Time & Material link)
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();

IWebElement tmOption = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));
tmOption.Click();

Thread.Sleep(1000);

//Click on Create New button
IWebElement createNewButton = driver.FindElement(By.LinkText("Create New"));
createNewButton.Click();

Thread.Sleep(1000);

//Select Time from dropdown
IWebElement typeCodeMainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typeCodeMainDropdown.Click();

Thread.Sleep(1000);

IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
typeCodeDropdown.Click();

Thread.Sleep(1000);

//Enter Code

IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("Deekshitha");

Thread.Sleep(1000);

// Enter Description
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("Desc January 2024");

Thread.Sleep(1000);

//Enter price
IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("123123.34");

Thread.Sleep(1000);

//Click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();

Thread.Sleep(1000);

//Check if a new time record has been created successfully
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();

Thread.Sleep(1000);

IWebElement newRecordData = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[1]"));
if (newRecordData.Text == "Deekshitha")
{
    Console.WriteLine("New Time record has been created successfully");
}
else
{
    Console.WriteLine("Time record has not created");
}

//Code for Edit Time Record

//Click on Edit Button
IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[9]/td[5]/a[1]"));
editButton.Click();
Thread.Sleep(3000);

//Edit Code in Code Textbox
IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
editCodeTextbox.Clear();
editCodeTextbox.SendKeys("Deekshitha Nagaraj");

//Edit Description in Description Textbox
IWebElement editDescriptionTextBox = driver.FindElement(By.Id("Description"));
editDescriptionTextBox.Clear();
editDescriptionTextBox.SendKeys("Automation Testing");

//Edit Price in Price Textbox
IWebElement editPriceOverlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
IWebElement editPriceTextBox = driver.FindElement(By.Id("Price"));
editPriceOverlappingTag.Click();
editPriceTextBox.Clear();
editPriceOverlappingTag.Click();
editPriceTextBox.SendKeys("15000");

//Click on save button
IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
editSaveButton.Click();
Thread.Sleep(7000);

// Clock on goToLastPage Button
IWebElement editGoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
editGoToLastPageButton.Click();

IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
IWebElement EditedDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
//Assert.That(newRecordData.Text.Equals("Deekshitha"), "Time record has not been created");
if (editedCode.Text == "Deekshitha Nagaraj" && EditedDescription.Text == "Automation Testing")
{
    Console.WriteLine("Time Record has been updated successfully");
}
else
{
    Console.WriteLine("Time Record has not been updated");
}

//Code for Delete Time Record

//Click on delete button
IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deleteButton.Click();

IAlert simpleAlert = driver.SwitchTo().Alert();
simpleAlert.Accept();

IWebElement lastCodeInTable = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (lastCodeInTable.Text == "Deekshitha Nagaraj")
{
    Console.WriteLine("Time Record has not been deleted");
}
else
{
    Console.WriteLine("Time Record has been deleted successfully");
}
