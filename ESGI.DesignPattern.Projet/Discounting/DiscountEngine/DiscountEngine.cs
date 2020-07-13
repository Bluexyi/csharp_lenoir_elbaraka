using System;
using ESGI.DesignPattern.Projet.Discounting.ItemDiscount;
using ESGI.DesignPattern.Projet.Inventory.Item;
using ESGI.DesignPattern.Projet.Inventory.Money;
using ESGI.DesignPattern.Projet.Marketing;

namespace ESGI.DesignPattern.Projet.Discounting.DiscountEngine
{
    public class DiscountEngine : IDiscountEngine
    {

        private readonly IMarketingCampaign _marketingCampaign;


        public DiscountEngine(IMarketingCampaign marketingCampaign)
        {
            _marketingCampaign = marketingCampaign;
        }

        public Money ApplyDiscountFor(IItem item)
        {
            IItemDiscountStrategy discountStrategy = new NoDiscountStrategy();

            if (_marketingCampaign.IsCrazySalesDay())
                discountStrategy = new FirstTierDiscountStrategy();

            if (item.Price > Money.OneThousand)
                discountStrategy = new SecondTierDiscountStrategy();

            if (item.Price > Money.OneHundred && _marketingCampaign.IsActive())
                discountStrategy = new ThirdTierDiscountStrategy();

            return item.ApplyStrategy(discountStrategy);
        }

        /// <summary>
        /// Only gets discount for simulation of discount 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int CalculateDiscount(int amount)
        {
            throw new NotImplementedException();
        }

    }
}