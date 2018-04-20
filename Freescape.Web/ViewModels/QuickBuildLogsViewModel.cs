using System.Collections.Generic;
using System.Linq;
using Freescape.Web.Attributes;
using Freescape.Web.Constants;
using Freescape.Web.Data;
using Freescape.Web.Data.Entities;
using Freescape.Web.ViewModels.BaseViewModels;

namespace Freescape.Web.ViewModels
{
    [RoleRequired(RoleType.Admin, RoleType.DM)]
    public class QuickBuildLogsViewModel : PaginateBaseVM
    {
        public QuickBuildLogsViewModel(DataContext db)
            : base(BuildClientData(db),
                nameof(StructureQuickBuildAudit.StructureQuickBuildID))
        {
        }

        private static IEnumerable<dynamic> BuildClientData(DataContext db)
        {
            return db.StructureQuickBuildAudit.OrderByDescending(o => o.DateBuilt);
        }
    }
}
