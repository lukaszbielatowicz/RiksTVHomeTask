using System;
using System.Configuration;

namespace RiksTV.Lib.GooglePlacesProvider.Configuration {

    public class PlacesConfigurationModel : ConfigurationSection {

        [ConfigurationProperty("apiKey", DefaultValue = "", IsRequired = true)]
        public String ApiKey {
            get {
                return (String)this["apiKey"];
            }
            set {
                this["apiKey"] = value;
            }
        }

    }
}
