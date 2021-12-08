using Blazored.Modal;
using Blazored.Modal.Services;
using BugTracker.Data;
using BugTracker.Data.Entities;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BugTracker.Shared
{
    public partial class CreateBugModal
    {
        [Inject]
        BugService BService { get; set; }
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        bool ShowForm { get; set; } = true;
        string BugTitle { get; set; }
        string BugDescription { get; set; }
        int BugHoursRemaining { get; set; }
        int FormId { get; set; }

        async Task SubmitForm()
        {
            
            await ModalInstance.CloseAsync(ModalResult.Ok($"Form was submitted successfully."));

            //Create new Bug object
            Bug newbug = new Bug()
            {
                Title = BugTitle,
                Description = BugDescription,
                HoursRemaining = BugHoursRemaining,
                DateCreated = System.DateTime.Today
            };
            bool success = await BService.CreateBugAsync(newbug);
        }

        void Cancel()
        {
            ModalInstance.CancelAsync();
        }
    }
}
