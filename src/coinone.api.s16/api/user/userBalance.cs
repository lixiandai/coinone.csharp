using System.Collections.Generic;

namespace XCT.BaseLib.API.CoinOne.User
{
    public class BalanceData
    {
        /// <summary>
        /// Available
        /// </summary>
        public decimal avail
        {
            get;
            set;
        }

        /// <summary>
        /// Total 
        /// </summary>
        public decimal balance
        {
            get;
            set;
        }
    }

    public class WalletData
    {
        /// <summary>
        /// Total BTC. 
        /// </summary>
        public decimal balance
        {
            get;
            set;
        }

        /// <summary>
        /// Normal Wallet Label.
        /// </summary>
        public string label
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class UserBalance : CApiResult
    {
        /// <summary>
        /// BTC information.
        /// </summary>
        public BalanceData btc
        {
            get;
            set;
        }

        /// <summary>
        /// ETH information.
        /// </summary>
        public BalanceData eth
        {
            get;
            set;
        }

        /// <summary>
        /// ETC information.
        /// </summary>
        public BalanceData etc
        {
            get;
            set;
        }

        /// <summary>
        /// KRW information.
        /// </summary>
        public BalanceData krw
        {
            get;
            set;
        }

        /// <summary>
        /// BTC normal wallet information.
        /// </summary>
        public List<WalletData> normalWallets
        {
            get;
            set;
        }

        /// <summary>
        /// 사용 가능 QTY
        /// </summary>
        public decimal available_qty(string coin_name)
        {
            var _result = 0.0m;

            switch (coin_name.ToUpper())
            {
                case "BTC":
                    _result = this.btc.avail;
                    break;
                case "ETH":
                    _result = this.eth.avail;
                    break;
                case "ETC":
                    _result = this.etc.avail;
                    break;
                case "KRW":
                    _result = this.krw.avail;
                    break;
            }

            return _result;
        }
    }
}