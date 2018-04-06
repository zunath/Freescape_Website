using System.Collections.Generic;
using System.Linq;
using DotNetify;
using Freescape.Web.Data;
using Freescape.Web.Data.Entities;

namespace Freescape.Web.ViewModels
{
    public class DownloadsViewModel: BaseVM
    {
        public IEnumerable<Downloads> DownloadList { get; set; }

        public DownloadsViewModel(DataContext db)
        {
            DownloadList = db.Downloads
                .Where(x => x.IsActive)
                .ToList();
        }
    }
}
