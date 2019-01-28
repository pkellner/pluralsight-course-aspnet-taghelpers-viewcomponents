using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTagHelper
{
    
    public class TimeSinceService : ITimeSinceService
    {
        public string TimeSince(DateTime dateTime)
        {
            var tspan = DateTime.Now.Subtract(dateTime);
            return PeriodOfTimeOutput(tspan);
        }

        /// <summary>
        /// // from: http://stackoverflow.com/questions/3383464/is-there-a-smarter-way-to-generate-time-since-with-a-datetime-objects
        /// </summary>
        /// <param name="tspan"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        private string PeriodOfTimeOutput(TimeSpan tspan, int level = 0)
        {
            string how_long_ago = "ago";
            if (level >= 2) return how_long_ago;
            if (tspan.Days > 1)
                how_long_ago = string.Format("{0} Days ago", tspan.Days);
            else if (tspan.Days == 1)
                how_long_ago = string.Format("1 Day {0}", PeriodOfTimeOutput(new TimeSpan(tspan.Hours, tspan.Minutes, tspan.Seconds), level + 1));
            else if (tspan.Hours >= 1)
                how_long_ago = string.Format("{0} {1} {2}", tspan.Hours, (tspan.Hours > 1) ? "Hours" : "Hour", PeriodOfTimeOutput(new TimeSpan(0, tspan.Minutes, tspan.Seconds), level + 1));
            else if (tspan.Minutes >= 1)
                how_long_ago = string.Format("{0} {1} {2}", tspan.Minutes, (tspan.Minutes > 1) ? "Minutes" : "Minute", PeriodOfTimeOutput(new TimeSpan(0, 0, tspan.Seconds), level + 1));
            else if (tspan.Seconds >= 1)
                how_long_ago = string.Format("{0} {1} ago", tspan.Seconds, (tspan.Seconds > 1) ? "Seconds" : "Second");
            return how_long_ago;
        }
    }

    //public interface ITimeSinceService
    //{
    //    string TimeSince(DateTime dateTime);
    //}

    

}
