using System;

namespace WebAppTagHelper
{
    public interface ITimeSinceService
    {
        string TimeSince(DateTime dateTime);
    }
}

