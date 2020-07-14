using ESGI.DesignPattern.Projet.Discounting.DiscountEngine;
using ESGI.DesignPattern.Projet.Inventory.Item;
using ESGI.DesignPattern.Projet.Marketing;
using NSubstitute;
using Xunit;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class DiscountEngineTests
    {
        private readonly IMarketingCampaign _marketingCampaignMock = NSubstitute.Substitute.For<IMarketingCampaign>();
        private readonly IDiscountEngineStrategy _discountEngineStrategy = NSubstitute.Substitute.For<IDiscountEngineStrategy>();
        

        [Fact]
        public void TestDiscountEngine_DiscountStrategiesCalled()
        {
            var discountEngine = new DiscountEngine(_marketingCampaignMock, _discountEngineStrategy);
            var item = NSubstitute.Substitute.For<IItem>();
            
            discountEngine.ApplyDiscountFor(item);
            
            _discountEngineStrategy.Received(1).GetDiscountStrategy(item.Price, _marketingCampaignMock);
            var itemDiscountStrategy = _discountEngineStrategy.Received(1).GetDiscountStrategy(item.Price, _marketingCampaignMock);
            item.Received(1).ApplyStrategy(itemDiscountStrategy);
        }
        
    }
}
