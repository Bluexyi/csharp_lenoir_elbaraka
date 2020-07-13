using System;
using System.Collections.Generic;
using System.Text;
using ESGI.DesignPattern.Projet.Marketing;
using NSubstitute;
using Xunit;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class DiscountEngineTests
    {
        [Fact]
        public void DiscountEngineTest()
        {
            var marketingCampaingMock = NSubstitute.Substitute.For<IMarketingCampaign>();

            marketingCampaingMock.IsCrazySalesDay().Returns(true);
            marketingCampaingMock.IsActive().Returns(false);

        }
    }
}
