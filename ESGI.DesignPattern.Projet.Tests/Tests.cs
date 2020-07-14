using System;
using ESGI.DesignPattern.Projet.Discounting.DiscountEngine;
using ESGI.DesignPattern.Projet.Discounting.ItemDiscount;
using ESGI.DesignPattern.Projet.Inventory.Item;
using ESGI.DesignPattern.Projet.Inventory.Money;
using ESGI.DesignPattern.Projet.Marketing;
using Xunit;
using NSubstitute;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class MultiLevelTests
    {
        [Fact]
        public void TestForItem_15pReduction()
        {
            var item = new ItemBuilder()
                .WithName("les pattes")
                .WithPrice(100)
                .Build();

            var aFriday = new AppDateTime
            {
                Now = new DateTime(2020, 7, 10)
            };

            var discountEngine = new DiscountEngine(new MarketingCampaign(aFriday));
            discountEngine.ApplyDiscountFor(item);

            Assert.True(item.Price.Equals(new Money(100) % FirstTierDiscountStrategy.Percentage));
            
        }

        [Fact]
        public void TestForItem_10pReduction()
        {
            var item = new ItemBuilder()
                .WithName("spaghetti")
                .WithPrice(1500)
                .Build();

            var aMonday = new AppDateTime
            {
                Now = new DateTime(2020, 7, 13)
            };

            var discountEngine = new DiscountEngine(new MarketingCampaign(aMonday));
            discountEngine.ApplyDiscountFor(item);

            Assert.True(item.Price.Equals(new Money(1500) % SecondTierDiscountStrategy.Percentage));

        }

        [Fact]
        public void TestForItem_5pReduction()
        {
            var item = new ItemBuilder()
                .WithName("sauce tomate")
                .WithPrice(210)
                .Build();

            var pairDateTime = new AppDateTime
            {
                Now = new DateTime(2020, 7, 9, 3, 57, 32, 12)
            };

            var discountEngine = new DiscountEngine(new MarketingCampaign(pairDateTime));
            discountEngine.ApplyDiscountFor(item);

            Assert.True(item.Price.Equals(new Money(210) % ThirdTierDiscountStrategy.Percentage));

        }

        [Fact]
        public void TestForItem_NoReduction()
        {
            var item = new ItemBuilder()
                .WithName("supplement d3")
                .WithPrice(80)
                .Build();

            var pairDateTime = new AppDateTime
            {
                Now = new DateTime(2020, 7, 13)
            };

            var discountEngine = new DiscountEngine(new MarketingCampaign(pairDateTime));
            discountEngine.ApplyDiscountFor(item);

            Assert.True(item.Price.Equals(new Money(80) % NoDiscountStrategy.Percentage));

        }
    }
}

