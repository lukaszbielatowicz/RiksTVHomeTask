using System;
using System.Configuration;

namespace RiksTV.Lib.GooglePlacesProvider.Configuration {

    public class PlacesConfigurationModel : ConfigurationSection {

        [ConfigurationProperty("apiKey", DefaultValue = "", IsRequired = true)]
        public string ApiKey {
            get {
                return (string)this["apiKey"];
            }
            set {
                this["apiKey"] = value;
            }
        }

    }
}
