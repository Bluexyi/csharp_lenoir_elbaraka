using System;
using System.Collections.Generic;
using System.Text;
using ESGI.DesignPattern.Projet.Discounting.ItemDiscount;
using ESGI.DesignPattern.Projet.Inventory.Money;

namespace ESGI.DesignPattern.Projet.Inventory.Item
{
    public interface IItem
    {
        string Name { get; }
        Money.Money Price { get; }
        Money.Money ApplyStrategy(IItemDiscountStrategy itemDiscountStrategy);
        //IItemDiscountStrategy DiscountStrategy { get; }
    }
}
