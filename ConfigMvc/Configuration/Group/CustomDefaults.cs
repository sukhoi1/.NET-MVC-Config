using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using ConfigMvc.Configuration.Collection;

namespace ConfigMvc.Configuration.Group
{
    public class CustomDefaults : ConfigurationSectionGroup
    {
        public NewUserDefaultsSection NewUserDefaults
        {
            get { return (NewUserDefaultsSection)Sections["newUserDefaults"]; }
        }

        public PlaceSection Places
        {
            get { return (PlaceSection)Sections["places"]; }
        }
    }
}