namespace XCT.BaseLib.API.CoinOne
{
    /// <summary>
    /// 
    /// </summary>
    public class CApiResult
    {
        /// <summary>
        /// Request's result
        /// </summary>
        public string result;

        /// <summary>
        /// Error code
        /// </summary>
        public int errorCode;

        /// <summary>
        /// Timestamp
        /// </summary>
        public long timestamp;
    }

    public class ApiResult<T> : CApiResult
    {
        /// <summary>
        /// data
        /// </summary>
        public T data
        {
            get;
            set;
        }
    }
}