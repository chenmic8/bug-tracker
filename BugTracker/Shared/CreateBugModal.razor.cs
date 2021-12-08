using Blazored.Modal;
using Blazored.Modal.Services;
using BugTracker.Data.Entities;
using Microsoft.AspNetCore.Components;

namespace BugTracker.Shared
{
    public partial class CreateBugModal
    {
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        bool ShowForm { get; set; } = true;
        string BugTitle { get; set; }
        string BugDescription { get; set; }
        int BugHoursRemaining { get; set; }
        int FormId { get; set; }

        void SubmitForm()
        {
            ModalInstance.CloseAsync(ModalResult.Ok($"Form was submitted successfully."));
            
            //Assign Bug parameters to some variables
            var Title = BugTitle;
            var Description = BugDescription;
            var HoursLeft = BugHoursRemaining;

            //Create new Bug object
            Bug newbug = new Bug()
            {
                Title = BugTitle,
                Description = BugDescription,
                HoursRemaining = BugHoursRemaining,
                DateCreated = System.DateTime.Today
            };
        }

        void Cancel()
        {
            ModalInstance.CancelAsync();
        }
    }
}
