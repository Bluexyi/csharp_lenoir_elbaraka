﻿using ESGI.DesignPattern.Projet.Inventory.Money;

namespace ESGI.DesignPattern.Projet.Discounting.ItemDiscount
{
    public class ThirdTierDiscountStrategy : IItemDiscountStrategy
    {
        //todo maybe a ctor with percentage and call to base to not duplicate code

        public Money ApplyItemDiscount(Money money)
            => money %= 5;

    }
}