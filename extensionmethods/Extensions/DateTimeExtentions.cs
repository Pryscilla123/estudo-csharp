using System.Globalization;

namespace extensionmethods.Extentions;

static class DateTimeExtention
{
    public static string ElapsedTime(this DateTime thisObj)
    {
       TimeSpan duration = DateTime.Now.Subtract(thisObj);

       if(duration.TotalHours < 24)
       {
        return $"{(duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture))} hours";
       }
       
       return $"{(duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture))} days";
    }
}