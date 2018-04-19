using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class SkillCategories
    {
        public SkillCategories()
        {
        }

        public int SkillCategoryId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Sequence { get; set; }
    }
}
