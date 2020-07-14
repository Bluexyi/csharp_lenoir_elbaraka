using ESGI.DesignPattern.Projet.Inventory.Money;

namespace ESGI.DesignPattern.Projet.Discounting.ItemDiscount
{
    public class SecondTierDiscountStrategy : IItemDiscountStrategy
    {
        public static int Percentage { get; } = 10;

        public Money ApplyItemDiscount(Money money)
            => money %= Percentage;

    }
}