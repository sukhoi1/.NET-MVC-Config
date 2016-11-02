using System.Configuration;

namespace ConfigMvc.Configuration.NestedCollection
{
    public class Group : ConfigurationSectionGroup
    {
        public Section Section
        {
            get { return (Section)Sections["section"]; }
        }
    }
}