using Microsoft.Web.WebView2.WinForms;
using System.Globalization;
using System;

namespace ProjectCollection.MenuPlan
{
    class MenuPlanLogic
    {
        private int _week;
        private readonly WebView2 _wvPage;
        public MenuPlanLogic(WebView2 wvPage)
        {
            _wvPage = wvPage;
        }
        /// <summary>
        /// Generates and opens the URL for the menuplan
        /// </summary>
        private void OpenWebsite()
        {
            _wvPage.Source = new Uri("https://www.acherli.ch/wp-content/uploads/2019/05/KW-" + _week + ".pdf");
        }
        /// <summary>
        /// Calculates the calendar week with a given date
        /// </summary>
        /// <param name="dateTime">Either Userinput or Todays date</param>
        public void CalculateCalendarWeek(DateTime dateTime)
        {
            //var date = dateTime.Date;
            /*DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(dateTime);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                dateTime = dateTime.AddDays(3);
            }*/
            _week = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            /*_week = date.DayOfYear / 7;
            if(date.DayOfWeek == DayOfWeek.Monday)
            {
                _week += 1;
            }*/
            OpenWebsite();
        }
    }
}
