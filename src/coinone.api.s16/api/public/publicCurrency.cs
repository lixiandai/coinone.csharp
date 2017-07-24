using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace XCT.BaseLib.API.CoinOne.Public
{
    /// <summary>
    /// 
    /// </summary>
    public class PublicCurrency : CApiResult
    {
        /// <summary>
        /// Currency Rate.
        /// </summary>
        public decimal currency;

        /// <summary>
        /// Currency Type. Ex) USD, KRW..
        /// </summary>
        public string currencyType;
    }
}