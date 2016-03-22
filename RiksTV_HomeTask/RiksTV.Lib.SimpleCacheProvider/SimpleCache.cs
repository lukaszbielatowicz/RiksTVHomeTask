namespace RiksTV.Lib.SimpleCacheProvider
{
    using HomeTaskApplication.CacheProviderInterface;

    /// <summary>
    /// </summary>
    /// <seealso cref="RiksTV.HomeTaskApplication.CacheProviderInterface.ICacheOperation" />
    public class SimpleCache : ICacheOperation
    {
        /// <summary>
        ///     Determines whether the specified key is exist.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public bool IsExist(string key)
        {
            return false;
        }

        /// <summary>
        ///     Gets the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public object Get(string key)
        {
            return null;
        }

        /// <summary>
        ///     Puts the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="cacheObject">The cache object.</param>
        /// <returns></returns>
        public bool Put(string key, object cacheObject)
        {
            return false;
        }
    }
}