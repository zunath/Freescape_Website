using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class Attributes
    {
        public Attributes()
        {
            SkillsPrimaryNavigation = new HashSet<Skills>();
            SkillsSecondaryNavigation = new HashSet<Skills>();
            SkillsTertiaryNavigation = new HashSet<Skills>();
        }

        public int AttributeId { get; set; }
        public int Nwnvalue { get; set; }
        public string Name { get; set; }

        public ICollection<Skills> SkillsPrimaryNavigation { get; set; }
        public ICollection<Skills> SkillsSecondaryNavigation { get; set; }
        public ICollection<Skills> SkillsTertiaryNavigation { get; set; }
    }
}
