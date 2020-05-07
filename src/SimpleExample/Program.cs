using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Nextmethod.Cex;
using SimpleExample.LocalArbitrage;

namespace SimpleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // new Program().RunExample().Wait();

            new ArbitrageCalculator(new CexApi()).GetAllCurrencyPairs(true);
        }

        const string CexUsername = ""; // Your username on Cex.io
        const string CexApiKey = ""; // Your API key
        const string CexApiSecret = ""; // Your API secret

        private CexApi CexClient { get; set; }

        private GhashApi GhashClient { get; set; }

        private async Task RunExample()
        {

            // Using the ApiCredentials Class
            // Client = new Api(new ApiCredentials(CexUsername, CexApiKey, CexApiSecret));
            // Or not
            // CexClient = new CexApi(CexUsername, CexApiKey, CexApiSecret);
            // ApiCredentials/(Username, ApiKey, ApiSecret) not needed for public functions
            CexClient = new CexApi();

            // Get Ticker Data
            Ticker tickerData = await CexClient.Ticker(SymbolPair.BTC_USD);

            // Get Order Book
            OrderBook orderBook = await CexClient.OrderBook(SymbolPair.BTC_USD);

            // Get Trade history
            IEnumerable<Trade> tradeHistory = await CexClient.TradeHistory(SymbolPair.BTC_USD);

            // ApiCredentials required for user specific calls or "Private Functions"
            CexClient = new CexApi(CexUsername, CexApiKey, CexApiSecret);

            // Get Account Balance
            Balance accountBalance = await CexClient.AccountBalance();

            // Get Open Orders
            IEnumerable<OpenOrder> openOrders = await CexClient.OpenOrders(SymbolPair.LTC_BTC);

            // Place an order
            OpenOrder openOrder = await CexClient.PlaceOrder(
                SymbolPair.BTC_USD,
                new Order
                {
                    Amount = 1.00m,
                    Price = 0.04644000m,
                    Type = OrderType.Buy
                });

            // Cancel an order
            bool didSucceed = await CexClient.CancelOrder(openOrder.Id);

            // GHash.IO Example
            GhashClient = new GhashApi(new ApiCredentials(CexUsername, CexApiKey, CexApiSecret));

            // Get Hash Rate
            Hashrate hashrate = await GhashClient.Hashrate();

            // Get Workers Hash Rate
            IEnumerable<KeyValuePair<string, WorkerHashrate>> workerHashRate = await GhashClient.WorkersHashRate();
        }
    }
}
