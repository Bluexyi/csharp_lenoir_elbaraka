using ESGI.DesignPattern.Projet.Discounting.ItemDiscount;

namespace ESGI.DesignPattern.Projet.Inventory.Item
{
    public class Item : IItem
    {
        public Item(string name, Money.Money price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }

        public Money.Money Price { get; private set; }
        //public IItemDiscountStrategy DiscountStrategy { get; private set; }

        public Money.Money ApplyStrategy(IItemDiscountStrategy itemDiscountStrategy)
        {
            return (Price = itemDiscountStrategy.ApplyItemDiscount(Price));
        }

    }
}