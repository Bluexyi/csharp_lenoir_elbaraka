using ESGI.DesignPattern.Projet.Inventory.Item;
using ESGI.DesignPattern.Projet.Inventory.Money;

namespace ESGI.DesignPattern.Projet.Discounting.DiscountEngine
{
    public interface IDiscountEngine
    {
        Money ApplyDiscountFor(IItem item);
        Money SimulateDiscountFor(IItem item);
    }
}