using ECommerceApiIntegrationTests.Orders.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Number = "555-55-5555",
                Expiration = "06/22",
                Cvv2 = "973"
            },
            items = new List<Item>
{
new Item { Id="1", Name="Beer", Price=6.99M, Qty=1}
}




        };

    }
}
