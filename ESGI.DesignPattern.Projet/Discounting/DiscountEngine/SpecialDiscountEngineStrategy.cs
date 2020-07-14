using ESGI.DesignPattern.Projet.Discounting.ItemDiscount;
using ESGI.DesignPattern.Projet.Inventory.Money;
using ESGI.DesignPattern.Projet.Marketing;

namespace ESGI.DesignPattern.Projet.Discounting.DiscountEngine
{
    public class SpecialDiscountEngineStrategy : IDiscountEngineStrategy
    {
        public IItemDiscountStrategy GetDiscountStrategy(Money price, IMarketingCampaign marketingCampaign)
        {
            IItemDiscountStrategy discountStrategy = new NoDiscountStrategy();

            if (marketingCampaign.IsCrazySalesDay())
                discountStrategy = new FirstTierDiscountStrategy();

            if (price > Money.OneThousand)
                discountStrategy = new SecondTierDiscountStrategy();

            if (price > Money.OneHundred && marketingCampaign.IsActive())
                discountStrategy = new ThirdTierDiscountStrategy();

            return discountStrategy;
        }
    }
}