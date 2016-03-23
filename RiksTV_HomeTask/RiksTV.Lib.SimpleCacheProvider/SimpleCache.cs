namespace RiksTV.Lib.SimpleCacheProvider
{
    using RiksTV.HomeTaskApplication.CacheProviderInterface;

    /// <summary> </summary>
    /// <seealso cref="RiksTV.HomeTaskApplication.CacheProviderInterface.ICacheOperation" />
    public class SimpleCache : ICacheOperation
    {
        #region Public Methods and Operators

        /// <summary> Gets the specified key. </summary>
        /// <param name="key"> The key. </param>
        /// <returns> </returns>
        public object Get(string key)
        {
            return null;
        }

        /// <summary> Determines whether the specified key is exist. </summary>
        /// <param name="key"> The key. </param>
        /// <returns> </returns>
        public bool IsExist(string key)
        {
            return false;
        }

        /// <summary> Puts the specified key. </summary>
        /// <param name="key"> The key. </param>
        /// <param name="cacheObject"> The cache object. </param>
        /// <returns> </returns>
        public bool Put(string key, object cacheObject)
        {
            return false;
        }

        #endregion
    }
}