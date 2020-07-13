using System;
using System.Collections.Generic;
using System.Text;
using ESGI.DesignPattern.Projet.Discounting.ItemDiscount;
using ESGI.DesignPattern.Projet.Inventory.Money;
using ESGI.DesignPattern.Projet.Marketing;
using NSubstitute;
using Xunit;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class StrategiesTest
    {
        [Fact]
        public void TestFirstTierStrategy_15pReduction()
        {
            var checkMoney = new Money(100);
            var expectedMoney = new Money(100);

            var firstTierMock = Substitute.For<IItemDiscountStrategy>();
            firstTierMock.ApplyItemDiscount(expectedMoney).Returns(expectedMoney %= 15);

            checkMoney = new FirstTierDiscountStrategy().ApplyItemDiscount(checkMoney);
            expectedMoney = firstTierMock.ApplyItemDiscount(new Money(100));

            Assert.True(expectedMoney.Equals(checkMoney));

        }

        [Fact]
        public void TestSecondTierStrategy_10pReduction()
        {
            var checkMoney = new Money(100);
            var expectedMoney = new Money(100);

            var secondTierMock = Substitute.For<IItemDiscountStrategy>();
            secondTierMock.ApplyItemDiscount(expectedMoney).Returns(expectedMoney %= 10);

            checkMoney = new SecondTierDiscountStrategy().ApplyItemDiscount(checkMoney);
            expectedMoney = secondTierMock.ApplyItemDiscount(new Money(100));

            Assert.True(expectedMoney.Equals(checkMoney));

        }

        [Fact]
        public void TestThirdTierStrategy_5pReduction()
        {
            var checkMoney = new Money(100);
            var expectedMoney = new Money(100);

            var thirdTierMock = Substitute.For<IItemDiscountStrategy>();
            thirdTierMock.ApplyItemDiscount(expectedMoney).Returns(expectedMoney %= 5);

            checkMoney = new ThirdTierDiscountStrategy().ApplyItemDiscount(checkMoney);
            expectedMoney = thirdTierMock.ApplyItemDiscount(new Money(100));

            Assert.True(expectedMoney.Equals(checkMoney));

        }

        [Fact]
        public void TestNoDiscountStrategy_0pReduction()
        {
            var expectedMoney = new Money(100);
            var checkMoney = new Money(100);

            expectedMoney = new NoDiscountStrategy().ApplyItemDiscount(expectedMoney);
            checkMoney %= 0;

            Assert.True(expectedMoney.Equals(checkMoney));

        }


        
    }
}
