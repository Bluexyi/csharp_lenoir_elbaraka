using ESGI.DesignPattern.Projet.Discounting.ItemDiscount;
using ESGI.DesignPattern.Projet.Inventory.Money;
using ESGI.DesignPattern.Projet.Marketing;

namespace ESGI.DesignPattern.Projet.Discounting.DiscountEngine
{
    public interface IDiscountEngineStrategy
    {
        IItemDiscountStrategy GetDiscountStrategy(Money price, IMarketingCampaign marketingCampaign);
    }
}