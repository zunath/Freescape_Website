using System.Collections.Generic;
using System.Linq;
using DotNetify;
using Freescape.Web.Data;
using Freescape.Web.Data.Entities;

namespace Freescape.Web.ViewModels
{
    public class PerksViewModel: BaseVM
    {
        private readonly DataContext _db;

        public string PerkList_itemkey => nameof(Perk.PerkCategoryID);
        public IEnumerable<Perk> PerkList
        {
            get => Get<IEnumerable<Perk>>();
            set => Set(value);
        }

        public string PerkCategoryList_itemkey => nameof(PerkCategory.PerkCategoryID);
        public IEnumerable<PerkCategory> PerkCategoryList
        {
            get => Get<IEnumerable<PerkCategory>>();
            set => Set(value);
        }

        public int SelectedCategoryID
        {
            get => Get<int>();
            set
            {
                Set(value);
                LoadPerkList();
            }
        }

        public int SelectedPerkID
        {
            get => Get<int>();
            set
            {
                Set(value);
                LoadPerk();
            }
        }

        public Perk SelectedPerk
        {
            get => Get<Perk>();
            set => Set(value);
        }

        public PerksViewModel(DataContext db)
        {
            _db = db;

            PerkCategoryList = db.PerkCategories
                .Where(x => x.IsActive)
                .OrderBy(o => o.Sequence)
                .ToList();

            SelectedCategoryID = PerkCategoryList.First().PerkCategoryID;
            SelectedPerkID = PerkList.First().PerkID;
        }

        private void LoadPerkList()
        {
            PerkList = _db.Perks
                .Where(x => x.IsActive &&
                            x.PerkCategoryID == SelectedCategoryID)
                .OrderBy(o => o.PerkID)
                .ToList();

            SelectedPerkID = PerkList.First().PerkID;
        }

        private void LoadPerk()
        {
            SelectedPerk = PerkList.Single(x => x.PerkID == SelectedPerkID);
        }
    }
}
