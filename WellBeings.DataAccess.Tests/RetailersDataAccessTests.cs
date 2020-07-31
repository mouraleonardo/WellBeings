using System;
using System.Linq;
using WellBeings.Data;
using Xunit;

namespace WellBeings.DataAccess.Tests
{
    public class RetailersDataAccessTests
    {
        [Fact]
        public void Test_GetRetailers()
        {
            // arrange
            var dataAcces = new RetailersDataAccess();

            // act
            var retailers = dataAcces.GetRetailers();

            // assert
            Assert.NotNull(retailers);
            Assert.True(retailers.Any());
        }
    }
}
