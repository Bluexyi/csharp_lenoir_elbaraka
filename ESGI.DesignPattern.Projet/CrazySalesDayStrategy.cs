using System;
using System.Collections.Generic;
using System.Text;

namespace ESGI.DesignPattern.Projet
{
    public class CrazySalesDayStrategy : DiscountStrategy
    {
        public override Money ApplyDiscount(Money money)
        {
            return money.ReduceBy(15);
        }
    }
}
