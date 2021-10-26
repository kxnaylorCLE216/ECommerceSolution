using ECommerceApi;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ECommerceApiIntegrationTests.Orders.Resource
{
    public class PlacingAnOrderTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private readonly HttpClient _client;

        public PlacingAnOrderTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();
        }

        [Fact]
        public async Task Gets201StatusCode()
        {
            var response = await _client.PostAsync("/orders", null);

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }

        [Fact(Skip ="Wait until after I add the other resource")]
        public async Task HasLocationHeader()
        {
            // response should have a location header with the 
        }

        [Fact]
        public async Task HasCorrectContectTypeOnResponse()
        {
            var sampleData = new OrderRequest
            {
                name = "Bob Smith",
                address = "1212 Orange St",
                city = "Akron",
                state = "OH",
                zip = "44319",
                creditCardInfo = new Creditcardinfo
                {
                    number = "555-55-5555",
                    expiration = "06/22",
                    cvv2 = "973"
                },
                items = new List<Item>
                {
                    new Item { id="1", name="Beer", price=6.99M, qty=1}
                }
            };

            var reponse = await _client.PostAsJsonAsync("/orders", sampleData);

            Assert.Equal("application/json", reponse.Content.Headers.ContentType.MediaType);
        }
    }

    public class OrderRequest
    {
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public Creditcardinfo creditCardInfo { get; set; }
        public List<Item> items { get; set; }
    }

    public class Creditcardinfo
    {
        public string number { get; set; }
        public string expiration { get; set; }
        public string cvv2 { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string name { get; set; }
        public int qty { get; set; }
        public decimal price { get; set; }
    }
}