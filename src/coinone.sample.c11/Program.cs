using System;
using XCT.BaseLib.API.CoinOne.Public;
using XCT.BaseLib.API.CoinOne.User;

namespace Coinone.Sample.Core
{
    class Program
    {
        /// <summary>
        /// 1. Public API
        /// </summary>
        public static async void XPublicApi()
        {
            var _public_api = new CPublicApi();

            var _ticker = await _public_api.Ticker("ETH");
            if (_ticker.errorCode == 0)
                Console.WriteLine(_ticker.last);

            var _orderbook = await _public_api.OrderBook("ETH");
            if (_orderbook.errorCode == 0)
                Console.WriteLine(_orderbook.timestamp);

            var _trades = await _public_api.Trades("ETH", "hour");
            if (_trades.errorCode == 0)
                Console.WriteLine(_trades.result);
        }

        /// <summary>
        /// 2. User API
        /// </summary>
        public static async void XUserApi()
        {
            var __user_api = new CUserApi("connect-key", "secret-key");

            var _account = await __user_api.Balance();
            if (_account.errorCode == 0)
                Console.WriteLine(_account.result);
        }

        /// <summary>
        /// 3. Trade API
        /// </summary>
        public static async void XTradeApi()
        {
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var _debug_step = 1;

            // 1. Public API
            if (_debug_step == 1)
                XPublicApi();

            // 2. Private API
            if (_debug_step == 2)
                XUserApi();

            // 3. Trade API
            if (_debug_step == 3)
                XTradeApi();

            Console.WriteLine("hit any key to quit...");
            Console.ReadKey();
        }
    }
}