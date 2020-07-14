using System;

namespace ESGI.DesignPattern.Projet.Marketing
{
    public class MarketingCampaign : IMarketingCampaign
    {
        private readonly AppDateTime _appDateTime;

        public MarketingCampaign() : this(new AppDateTime())
        { }

        public MarketingCampaign(AppDateTime appDateTime)
        {
            _appDateTime = appDateTime;
        }


        public bool IsActive()
        {
            return (long)_appDateTime.Now.TimeOfDay.TotalMilliseconds % 2 == 0;
        }

        public bool IsCrazySalesDay()
        {
            return _appDateTime.Now.DayOfWeek.Equals(DayOfWeek.Friday);
        }

        
    }
}