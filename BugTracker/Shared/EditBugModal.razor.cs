using Blazored.Modal;
using BugTracker.Data;
using BugTracker.Data.Entities;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BugTracker.Shared
{
    public partial class EditBugModal
    {
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
        [Inject]
        BugService BService { get; set; }
        [Parameter] public Bug bug { get; set; }
        public string BugTitle { get; private set; }
        public string BugDescription { get; private set; }
        public int BugHoursRemaining { get; private set; }

        protected override void OnInitialized()
        {
            System.Console.WriteLine(bug);
        }
        async Task UpdateForm(Bug bug)
        {
            Bug renewedbug = new Bug()
            {
                Id = bug.Id,
                Title = BugTitle,
                Description = BugDescription,
                HoursRemaining = BugHoursRemaining,
                DateCreated = bug.DateCreated
            };
            bool success = await BService.UpdateBugAsync(renewedbug);
        }
    }
}
