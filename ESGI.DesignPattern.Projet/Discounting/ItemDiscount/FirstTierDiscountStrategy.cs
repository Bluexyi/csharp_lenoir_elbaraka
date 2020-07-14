using ESGI.DesignPattern.Projet.Inventory.Money;

namespace ESGI.DesignPattern.Projet.Discounting.ItemDiscount
{
    public class FirstTierDiscountStrategy : IItemDiscountStrategy
    {
        public static int Percentage { get; } = 15;

        public Money ApplyItemDiscount(Money money)
            => money %= Percentage;
    }
}