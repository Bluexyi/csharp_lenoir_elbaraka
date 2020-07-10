using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    public class Discount
    {
        private readonly MarketingCampaign marketingCampaign;

        public Discount()
        {
            this.marketingCampaign = new MarketingCampaign();
        }

        public Money DiscountFor(Money netPrice)
        {
            if (marketingCampaign.IsCrazySalesDay())
            {
                return new CrazySalesDayStrategy().ApplyDiscount(netPrice);
            }
            return new ClassicStrategy(marketingCampaign).ApplyDiscount(netPrice);
        }

    }
}
