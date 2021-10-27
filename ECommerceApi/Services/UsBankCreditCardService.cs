using ECommerceApi.HttpClients;
using ECommerceApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ECommerceApi.Services
{
    public class UsBankCreditCardService : IAuthorizeCreditCards
    {
        private readonly UsBankHttpClient _client;

        public UsBankCreditCardService(UsBankHttpClient client)
        {
            _client = client;
        }

        public async Task<CreditCardAuthorizationResponse> AuthorizeAsync(CreditCardAuthorizationRequest creditCardInfo)
        {
            return await _client.AuthorizeAsync(creditCardInfo);
        }
    }
}