using System;
using System.Linq;
using WellBeings.Data;
using Xunit;

namespace WellBeings.DataAccess.Tests
{
    public class ProductsDataAccessTests
    {
        [Fact]
        public void Test_GetProducts()
        {
            // arrange
            var dataAcces = new ProductsDataAccess();

            // act
            var products = dataAcces.GetProducts();

            // assert
            Assert.NotNull(products);
            Assert.True(products.Any());
        }
    }
}
