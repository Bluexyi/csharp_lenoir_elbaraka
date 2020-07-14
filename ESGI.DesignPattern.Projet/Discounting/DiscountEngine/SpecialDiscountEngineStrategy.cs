using ESGI.DesignPattern.Projet.Discounting.ItemDiscount;
using ESGI.DesignPattern.Projet.Inventory.Money;
using ESGI.DesignPattern.Projet.Marketing;

namespace ESGI.DesignPattern.Projet.Discounting.DiscountEngine
{
    public class SpecialDiscountEngineStrategy : IDiscountEngineStrategy
    {
        public IItemDiscountStrategy GetDiscountStrategy(Money price, IMarketingCampaign marketingCampaign)
        {
            if (marketingCampaign.IsCrazySalesDay())
                return new FirstTierDiscountStrategy();

            if (price > Money.OneThousand)
                return new SecondTierDiscountStrategy();

            if (price > Money.OneHundred && marketingCampaign.IsActive())
                return new ThirdTierDiscountStrategy();

            return new NoDiscountStrategy();
        }
    }
}