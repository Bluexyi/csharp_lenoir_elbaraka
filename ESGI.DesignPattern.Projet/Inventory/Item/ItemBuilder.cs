using ESGI.DesignPattern.Projet.Inventory.Money;

namespace ESGI.DesignPattern.Projet.Inventory.Item
{
    public class ItemBuilder
    {
        private string _name;

        private Money.Money _price;

        public ItemBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public ItemBuilder WithPrice(decimal price)
        {
            _price = new Money.Money(price);
            return this;
        }
        public ItemBuilder WithPrice(int price)
        {
            _price = new Money.Money(price);
            return this;
        }
    }
}