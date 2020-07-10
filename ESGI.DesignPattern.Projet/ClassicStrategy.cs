using System;
using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public class ClassicStrategy : DiscountStrategy
    {
        public readonly MarketingCampaign marketingCampaign;

        public ClassicStrategy(MarketingCampaign marketingCampaign)
        {
            this.marketingCampaign = marketingCampaign;
        }

        public override Money ApplyDiscount(Money money)
        {
            if (money.MoreThan(Money.OneThousand))
            {
                return money.ReduceBy(10);
            }
            if (money.MoreThan(Money.OneHundred) && marketingCampaign.IsActive())
            {
                return money.ReduceBy(5);
            }
            return base.ApplyDiscount(money);
        }
    }
}
