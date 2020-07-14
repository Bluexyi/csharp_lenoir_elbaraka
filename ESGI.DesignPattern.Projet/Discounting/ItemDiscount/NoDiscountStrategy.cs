using ESGI.DesignPattern.Projet.Inventory.Money;

namespace ESGI.DesignPattern.Projet.Discounting.ItemDiscount
{
    public class NoDiscountStrategy : IItemDiscountStrategy
    {
        public static int Percentage { get; } = 0;

        public Money ApplyItemDiscount(Money money)
            => money % Percentage;
    }
}