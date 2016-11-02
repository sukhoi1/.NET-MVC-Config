using System.Configuration;
using ConfigMvc.Configuration.Collection;

namespace ConfigMvc.Configuration.Renamed
{
    public class MySection : ConfigurationSection
    {
        [ConfigurationProperty("MyCollection", Options = ConfigurationPropertyOptions.IsRequired)]
        public MyCollection MyCollection
        {
            get
            {
                return (MyCollection)this["MyCollection"];
            }
        }
    }
}