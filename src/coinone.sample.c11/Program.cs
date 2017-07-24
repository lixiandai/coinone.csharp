using System;
using System.Text;
using XCT.BaseLib.API.CoinOne.Public;
using XCT.BaseLib.API.CoinOne.Trading;
using XCT.BaseLib.API.CoinOne.User;

namespace Coinone.Sample.Core
{
    class Program
    {
        /// <summary>
        /// 1. Public API
        /// </summary>
        public static async void XPublicApi(int debug_step = 1)
        {
            var _public_api = new CPublicApi();

            if (debug_step == 1)
            {
                var _currency = await _public_api.Currency("KRW");
                if (_currency.errorCode == 0)
                    Console.WriteLine(_currency.currencyType);
            }

            if (debug_step == 2)
            {
                var _ticker = await _public_api.Ticker("ETH");
                if (_ticker.errorCode == 0)
                    Console.WriteLine(_ticker.last);
            }

            if (debug_step == 3)
            {
                var _orderbook = await _public_api.OrderBook("ETH");
                if (_orderbook.errorCode == 0)
                    Console.WriteLine(_orderbook.timestamp);
            }

            if (debug_step == 4)
            {
                var _trades = await _public_api.Trades("ETH", "day");
                if (_trades.errorCode == 0)
                    Console.WriteLine(_trades.completeOrders.Count);
            }
        }

        /// <summary>
        /// 2. User API
        /// </summary>
        public static async void XUserApi(int debug_step = 5)
        {
            var _c_user_api = new CUserApi("", "");

            if (debug_step == 1)
            {
                var _balance = await _c_user_api.Balance();
                Console.WriteLine(_balance.eth.avail);
            }

            if (debug_step == 2)
            {
                var _daily_balance = await _c_user_api.DailyBalance();
                Console.WriteLine(_daily_balance.result);
            }

            if (debug_step == 3)
            {
                var _user_info = await _c_user_api.UserInfor();
                Console.WriteLine(_user_info.userInfo.mobileInfo.userName);
            }

            if (debug_step == 4)
            {
                var _auth_number = await _c_user_api.AuthNumber("eth");
                Console.WriteLine(_auth_number);
            }

            if (debug_step == 5)
            {
                var _auth_number = await _c_user_api.SendCoin("eth", "", 123456, 1.0m);
                Console.WriteLine(_auth_number);
            }

            if (debug_step == 6)
            {
                var _history = await _c_user_api.History("eth");
                if (_history.errorCode == 0)
                    Console.WriteLine(_history.transactions.Count);
            }
        }

        /// <summary>
        /// 3. Trade API
        /// </summary>
        public static async void XTradeApi(int debug_step = 1)
        {
            var _c_trade_api = new CTradeApi("", "");

        }

        static void Main(string[] args)
        {
            var provider = CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(provider);

            var _debug_step = 2;

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