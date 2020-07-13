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

        public ItemBuilder WithPrice(Money.Money money)
        {
            _price = money;
            return this;
        }
    }
}