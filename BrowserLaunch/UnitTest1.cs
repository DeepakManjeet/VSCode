


namespace BrowserLaunch;
[TestFixture]
public class Tests
{

    public static ExtentReports extntReport1;
    public static ExtentTest test;
    [SetUp]
    public void Setup()
    {
     extntReport1 =  ExtentReportGenerator.ExtentTestDemo(); 
    }

    [Test]
    public void Test1()

    {
       test = extntReport1.CreateTest("Test1").Info("Test1 Started");
        test.Log(Status.Pass,"Test1 passed");
    }
     [Test]
      public void Test2()

    {
       test = extntReport1.CreateTest("Test2").Info("Test2 Started");
        test.Log(Status.Fail,"Test2 Failed");
    }

     [TearDown]
    public void TearDown()
    {
     extntReport1.Flush();
    }
}