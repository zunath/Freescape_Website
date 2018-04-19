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
    public class ChatLogsViewModel : PaginateBaseVM
    {
        public ChatLogsViewModel(DataContext db)
            : base(BuildClientData(db),
                nameof(ChatLog.ChatLogId))
        {

        }

        private static IEnumerable<dynamic> BuildClientData(DataContext db)
        {
            return db.ChatLog.OrderByDescending(x => x.DateSent);
        }

    }
}
