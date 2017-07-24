using System.Collections.Generic;

namespace XCT.BaseLib.API.CoinOne.User
{
    public class UserSendCoin : CApiResult
    {
        /// <summary>
        /// 
        /// </summary>
        public string txid
        {
            get;
            set;
        }
    }
}