using System;
using System.Collections.Generic;
using System.Text;
using ESGI.DesignPattern.Projet.Inventory.Money;

namespace ESGI.DesignPattern.Projet.Discounting.ItemDiscount
{

    public interface IItemDiscountStrategy
    {
        Money ApplyItemDiscount(Money money);
    }

    //abstract class DiscountStrategy : IItemDiscountStrategy
    //{
    //    public abstract Money ApplyItemDiscount(Money money);
    //}
}