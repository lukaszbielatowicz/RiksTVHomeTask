namespace RiksTV.Lib.GooglePlacesProvider.Configuration
{
    using System.Configuration;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Configuration.ConfigurationSection" />
    public class PlacesConfigurationModel : ConfigurationSection
    {
        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        /// <value>
        /// The API key.
        /// </value>
        [ConfigurationProperty("apiKey", DefaultValue = "", IsRequired = true)]
        public string ApiKey
        {
            get { return (string) this["apiKey"]; }
            set { this["apiKey"] = value; }
        }
    }
}