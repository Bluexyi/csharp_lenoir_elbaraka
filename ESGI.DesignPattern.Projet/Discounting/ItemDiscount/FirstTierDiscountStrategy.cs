using ESGI.DesignPattern.Projet.Inventory.Money;

namespace ESGI.DesignPattern.Projet.Discounting.ItemDiscount
{
    public class FirstTierDiscountStrategy : IItemDiscountStrategy
    {

        public Money ApplyItemDiscount(Money money)
            => money %= 15;
    }
}