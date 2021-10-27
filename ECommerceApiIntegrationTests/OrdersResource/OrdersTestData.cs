using System.Collections.Generic;

namespace ECommerceApiIntegrationTests.OrdersResource
{
    public static class OrdersTestData
    {
        public static OrderRequest ValidOrder = new OrderRequest
        {
            name = "Bob Smith",
            address = "1212 Orange St",
            city = "Akron",
            state = "OH",
            zip = "44319",
            creditCardInfo = new Creditcardinfo
            {
                number = "4417-1234-5678-9113",
                expiration = "06/22",
                cvv2 = "973"
            },
            items = new List<Item>
                {
                    new Item { id="1", name="Beer", price=6.99M, qty=1}
                }
        };

        //public static OrderPostRequest ValidOrder = new OrderPostRequest
        //{
        //    Name = "Bob Smith",
        //    Address = "1212 Orange St",
        //    City = "Akron",
        //    State = "OH",
        //    PostalCode = "44319",
        //    CreditCardInfo =  new ECommerceApi.Models.Orders.Creditcardinfo
        //    {
        //        Number = "555-55-5555",
        //        Expiration = "06/22",
        //        Cvv2 = "973"
        //    },
        //    Items = new List<ECommerceApi.Models.Orders.Item>
        //            {
        //                new ECommerceApi.Models.Orders.Item { Id="1", Name="Beer", Price=6.99M, Qty=1}
        //            }
        //};
    }
}