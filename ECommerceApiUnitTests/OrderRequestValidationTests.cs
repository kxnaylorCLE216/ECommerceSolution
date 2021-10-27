using ECommerceApi.Controllers;
using ECommerceApi.Filters;
using ECommerceApi.Models.Orders;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Xunit;

namespace ECommerceApiUnitTests
{
    public class OrderRequestValidationTests
    {
        [Fact()]
        public void OrderRequestHasTheCorrectValidationAttributes()
        {
            var maxLengthOnName = Helpers.GetPropertyAttributeValue<OrderPostRequest, string, MaxLengthAttribute, int>(p => p.Name, attr => attr.Length);
            Assert.Equal(100, maxLengthOnName);
        }

        [Fact]
        public void OrderPostValidatesModel()
        {
            var method = typeof(OrdersController).GetMethods()
                 .SingleOrDefault(x => x.Name == nameof(OrdersController.PlaceOrder));

            var attribute = method?.GetCustomAttributes(typeof(ValidateModelAttribute), true)
               .Single() as ValidateModelAttribute;

            Assert.NotNull(attribute);
        }
    }
}