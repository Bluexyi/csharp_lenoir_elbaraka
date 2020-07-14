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
        private readonly IDiscountEngineStrategy _discountEngineStrategy;

        public DiscountEngine(IMarketingCampaign marketingCampaign)
            : this(marketingCampaign, new SpecialDiscountEngineStrategy()) { }

        public DiscountEngine(IMarketingCampaign marketingCampaign, 
            IDiscountEngineStrategy discountEngineStrategy)
        {
            _marketingCampaign = marketingCampaign;
            _discountEngineStrategy = discountEngineStrategy;
        }

        //public Money ApplyDiscountFor(IItem item) => item.ApplyStrategy(
        //    _discountEngineStrategy.GetDiscountStrategy(item.Price, _marketingCampaign));

        public Money ApplyDiscountFor(IItem item)
        {
            IItemDiscountStrategy discountStrategy =
                _discountEngineStrategy.GetDiscountStrategy(item.Price, _marketingCampaign);

            return item.ApplyStrategy(discountStrategy);
        }

        public Money SimulateDiscountFor(IItem item)
        {
            //gets amount but does not apply it
            throw new NotImplementedException();
        }

    }
}