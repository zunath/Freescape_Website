using System.Collections.Generic;
using System.Linq;
using DotNetify;
using Freescape.Web.Data;
using Freescape.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Freescape.Web.ViewModels
{
    public class SkillsViewModel: BaseVM
    {
        private readonly DataContext _db;

        public string SkillList_itemkey => nameof(Skills.SkillCategoryId);
        public IEnumerable<Skills> SkillList
        {
            get => Get<IEnumerable<Skills>>();
            set => Set(value);
        }

        public string SkillCategoryList_itemkey => nameof(SkillCategories.SkillCategoryId);
        public IEnumerable<SkillCategories> SkillCategoryList
        {
            get => Get<IEnumerable<SkillCategories>>();
            set => Set(value);
        }

        public int SelectedCategoryID
        {
            get => Get<int>();
            set
            {
                Set(value);
                LoadSkillList();
            }
        }

        public int SelectedSkillID
        {
            get => Get<int>();
            set
            {
                Set(value); 
                LoadSkill();
            }
        }

        public Skills SelectedSkill
        {
            get => Get<Skills>();
            set => Set(value);
        }

        public SkillsViewModel(DataContext db)
        {
            _db = db;

            SkillCategoryList = db.SkillCategories
                .Where(x => x.IsActive)
                .OrderBy(o => o.Sequence)
                .ToList();

            SelectedCategoryID = SkillCategoryList.First().SkillCategoryId;
            SelectedSkillID = SkillList.First().SkillId;
        }

        private void LoadSkillList()
        {
            SkillList = _db.Skills
                .Include(i => i.Primary)
                .Include(i => i.Secondary)
                .Include(i => i.Tertiary)
                .Where(x => x.IsActive &&
                            x.SkillCategoryId == SelectedCategoryID)
                .OrderBy(o => o.SkillId)
                .ToList();

            SelectedSkillID = SkillList.First().SkillId;
        }

        private void LoadSkill()
        {
            SelectedSkill = SkillList.Single(x => x.SkillId == SelectedSkillID);
        }
    }
}
