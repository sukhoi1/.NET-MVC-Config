using System.Configuration;

namespace ConfigMvc.Configuration.NestedCollection
{
    public class Section : ConfigurationSection
    {
        [ConfigurationProperty("collectionOne", Options = ConfigurationPropertyOptions.IsRequired)]
        //[ConfigurationCollection(typeof(CollectionOne))] //must be removed, otherwise "Unknown element 'entity' exception"!
        public CollectionOne CollectionOne
        {
            get { return (CollectionOne)base["collectionOne"]; }
        }

        [ConfigurationProperty("attr")]
        public string Attr
        {
            get { return (string)base["attr"]; }
            set { base["attr"] = value; }
        }
    }
}