namespace RiksTV.HomeTaskApplication.CacheProviderInterface
{
    /// <summary> </summary>
    public interface ICacheOperation
    {
        #region Public Methods and Operators

        /// <summary> Gets the specified key. </summary>
        /// <param name="key"> The key. </param>
        /// <returns> </returns>
        object Get(string key);

        /// <summary> Determines whether the specified key is exist. </summary>
        /// <param name="key"> The key. </param>
        /// <returns> </returns>
        bool IsExist(string key);

        /// <summary> Puts the specified key. </summary>
        /// <param name="key"> The key. </param>
        /// <param name="cacheObject"> The cache object. </param>
        /// <returns> </returns>
        bool Put(string key, object cacheObject);

        #endregion
    }
}