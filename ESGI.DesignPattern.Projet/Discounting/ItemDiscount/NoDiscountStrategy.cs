using ESGI.DesignPattern.Projet.Inventory.Money;

namespace ESGI.DesignPattern.Projet.Discounting.ItemDiscount
{
    public class NoDiscountStrategy : IItemDiscountStrategy
    {
        public Money ApplyItemDiscount(Money money)
            => money;
    }
}