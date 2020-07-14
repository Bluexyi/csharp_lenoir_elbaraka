using ESGI.DesignPattern.Projet.Discounting.DiscountEngine;
using ESGI.DesignPattern.Projet.Discounting.ItemDiscount;
using ESGI.DesignPattern.Projet.Inventory.Money;
using ESGI.DesignPattern.Projet.Marketing;

using NSubstitute;
using Xunit;

namespace ESGI.DesignPattern.Projet.Tests
{

    public class SpecialDiscountEngineStrategyTest
    {
        private readonly IMarketingCampaign _marketingCampaignMock = NSubstitute.Substitute.For<IMarketingCampaign>();
        private readonly IDiscountEngineStrategy _engineDiscountStrategy = new SpecialDiscountEngineStrategy();
        

        [Fact]
        public void TestSpecialDiscountEngineStrategy_CrazySalesDayFirstTier()
        {
            _marketingCampaignMock.IsCrazySalesDay().Returns(true);
            _marketingCampaignMock.IsActive().Returns(false);
            
            var itemDiscountStrategy =
                _engineDiscountStrategy.GetDiscountStrategy(Arg.Any<Money>(), _marketingCampaignMock);
            
            Assert.True(itemDiscountStrategy.GetType().Name == typeof(FirstTierDiscountStrategy).Name);
        }

        [Fact]
        public void TestSpecialDiscountEngineStrategy_OneThousandSecondTier()
        {
            _marketingCampaignMock.IsCrazySalesDay().Returns(false);
            _marketingCampaignMock.IsActive().Returns(false);
            
            var itemDiscountStrategy =
                _engineDiscountStrategy.GetDiscountStrategy(new Money(1001), _marketingCampaignMock);

            Assert.True(itemDiscountStrategy.GetType().Name == typeof(SecondTierDiscountStrategy).Name);
        }

        [Fact]
        public void TestSpecialDiscountEngineStrategy_OneHundredThirdTier()
        {
            _marketingCampaignMock.IsCrazySalesDay().Returns(false);
            _marketingCampaignMock.IsActive().Returns(true);
            
            var itemDiscountStrategy =
                _engineDiscountStrategy.GetDiscountStrategy(new Money(101), _marketingCampaignMock);

            Assert.True(itemDiscountStrategy.GetType().Name == typeof(ThirdTierDiscountStrategy).Name);
        }

        [Fact]
        public void TestSpecialDiscountEngineStrategy_NoDiscount()
        {
            _marketingCampaignMock.IsCrazySalesDay().Returns(false);
            _marketingCampaignMock.IsActive().Returns(false);
            
            var itemDiscountStrategy =
                _engineDiscountStrategy.GetDiscountStrategy(new Money(10), _marketingCampaignMock);

            Assert.True(itemDiscountStrategy.GetType().Name == typeof(NoDiscountStrategy).Name);
        }

    }
}
