
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Model;


namespace BrowserLaunch;

public static  class ExtentReportGenerator
{
    public static ExtentReports extntReport;
    public static  ExtentSparkReporter HTMLreport;
    public static string reportPath = Path.GetFullPath(Path.Combine(System.IO.Directory.GetCurrentDirectory(),@"..\..\..\")+ "\\report" +".html");
  
    public static ExtentReports ExtentTestDemo()
    {
        if (HTMLreport==null)
        {
        HTMLreport = new ExtentSparkReporter(reportPath );
        extntReport = new ExtentReports();
        extntReport.AttachReporter(HTMLreport);

        }
   
        
        return extntReport;

    }

}