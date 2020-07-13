using System;
using ESGI.DesignPattern.Projet.Discounting.ItemDiscount;
using ESGI.DesignPattern.Projet.Inventory.Money;
using ESGI.DesignPattern.Projet.Marketing;
using Xunit;
using NSubstitute;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class Tests
    {
        


        //15% de reduction le vendredi
        //[Fact]
        //public void DiscountNotFriday()
        //{
        //    AppDateTime.Now = new DateTime(2020, 7, 6);

        //    var discount = new Discount();

        //    var net = new Money(1002);
        //    var total = discount.DiscountFor(net);

        //    Assert.Equal(new Money(901.8m), total);
        //}

        //[Fact]
        //public void DiscountFridayWithReduc15()
        //{
        //    AppDateTime.Now = new DateTime(2020, 7, 10);

        //    var discount = new Discount();

        //    var net = new Money(100);
        //    var total = discount.DiscountFor(net);

        //    Assert.Equal(new Money(85), total);
        //}

        ////5% de reduction si milliseconds pair
        //[Fact]
        //public void IsActiveWithTotalMillisecondsIsPair()
        //{
        //    AppDateTime.Now = new DateTime(2020, 7, 9, 3, 57, 32, 12);

        //    var discount = new Discount();

        //    var net = new Money(200);
        //    var total = discount.DiscountFor(net);

        //    Assert.Equal(new Money(190), total);
        //}

        //[Fact]
        //public void IsActiveWithTotalMillisecondsIsImpair()
        //{
        //    AppDateTime.Now = new DateTime(2020, 7, 9, 3, 57, 32, 11);

        //    var discount = new Discount();

        //    var net = new Money(200);
        //    var total = discount.DiscountFor(net);

        //    Assert.Equal(new Money(200), total);
        //}

        ////10% de reduction si money > 1000
        //[Fact]
        //public void IsActiveWithTotalMoneyMoreThan1000()
        //{
        //    AppDateTime.Now = new DateTime(2020, 7, 9, 3, 57, 32, 11);

        //    var discount = new Discount();

        //    var net = new Money(1100);
        //    var total = discount.DiscountFor(net);

        //    Assert.Equal(new Money(990), total);
        //}

    }
}

