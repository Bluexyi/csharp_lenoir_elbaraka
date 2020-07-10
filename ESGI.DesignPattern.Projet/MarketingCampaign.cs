using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    public class MarketingCampaign
    {
        public bool IsActive()
        {
            return (long)AppDateTime.Now.TimeOfDay.TotalMilliseconds % 2 == 0;
        }

        public bool IsCrazySalesDay()
        {
            return AppDateTime.Now.DayOfWeek.Equals(DayOfWeek.Friday);
        }
    }
}
