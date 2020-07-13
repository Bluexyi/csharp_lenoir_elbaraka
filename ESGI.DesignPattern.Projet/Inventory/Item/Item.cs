using ESGI.DesignPattern.Projet.Discounting.ItemDiscount;

namespace ESGI.DesignPattern.Projet.Inventory.Item
{
    public class Item : IItem
    {
        //public string Name { get; private set; }

        public Money.Money Price { get; private set; }
        //public IItemDiscountStrategy DiscountStrategy { get; private set; }

        public Money.Money ApplyStrategy(IItemDiscountStrategy itemDiscountStrategy)
        {
            return (Price = itemDiscountStrategy.ApplyItemDiscount(Price));
        }

    }
}