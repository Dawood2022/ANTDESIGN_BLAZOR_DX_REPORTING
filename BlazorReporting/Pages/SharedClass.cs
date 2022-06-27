using DevExpress.XtraReports.UI;

namespace BlazorReporting.Pages
{
    public static class SharedClass
    {
        public static XtraReport SetReport { get; set; }
        public static void ReportPerameter(XtraReport GetReport) 
        {
             SetReport=GetReport;
        }
    public static XtraReport SetReportValues() 
        {
            return SetReport;
        }

    }
}
