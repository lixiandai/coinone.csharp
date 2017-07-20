using System.Collections.Generic;
using System.Threading.Tasks;

namespace XCT.BaseLib.API.CoinOne.User
{
    /// <summary>
    /// 
    /// </summary>
    public class CUserApi
    {
        private string __connect_key;
        private string __secret_key;

        /// <summary>
        /// 
        /// </summary>
        public CUserApi(string connect_key, string secret_key)
        {
            __connect_key = connect_key;
            __secret_key = secret_key;
        }

        private CoinOneClient __user_client = null;

        private CoinOneClient UserClient
        {
            get
            {
                if (__user_client == null)
                    __user_client = new CoinOneClient(__connect_key, __secret_key);
                return __user_client;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<UserBalance> Balance()
        {
            return await UserClient.CallApiPostAsync<UserBalance>("/v2/account/balance");
        }

        /// <summary>
        /// Transaction_V2 - 2-Factor Authentication
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public async Task<AuthNumber> AuthNumber(string type = "krw")
        {
            return await UserClient.CallApiPostAsync<AuthNumber>("/v2/transaction/auth_number/");
        }
    }
}