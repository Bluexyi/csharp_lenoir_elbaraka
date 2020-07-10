using System;
using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public class DiscountStrategy
    {

        public virtual Money ApplyDiscount(Money money)
        {
            return money;
        }

    }
}
