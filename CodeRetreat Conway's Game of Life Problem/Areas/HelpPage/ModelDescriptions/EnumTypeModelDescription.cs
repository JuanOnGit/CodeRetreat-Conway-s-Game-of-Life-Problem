using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CodeRetreat_Conway_s_Game_of_Life_Problem.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}