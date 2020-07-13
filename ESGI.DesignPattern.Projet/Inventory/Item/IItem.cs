using System;
using System.Collections.Generic;
using System.Text;
using ESGI.DesignPattern.Projet.Discounting.ItemDiscount;

namespace ESGI.DesignPattern.Projet.Inventory.Item
{
    public interface IItem
    {
        Money.Money Price { get; }
        Money.Money ApplyStrategy(IItemDiscountStrategy itemDiscountStrategy);
        //IItemDiscountStrategy DiscountStrategy { get; }
    }
}
