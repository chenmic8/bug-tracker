using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;

namespace BugTracker.Shared
{
    public partial class CreateBugModal
    {
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        bool ShowForm { get; set; } = true;
        string BugTitle { get; set; }
        string BugDescription { get; set; }
        string BugHoursLeft { get; set; }
        int FormId { get; set; }

        void SubmitForm()
        {
            ModalInstance.CloseAsync(ModalResult.Ok($"Form was submitted successfully."));
            var Title = BugTitle;
            var Description = BugDescription;
            var HoursLeft = BugHoursLeft;
        }

        void Cancel()
        {
            ModalInstance.CancelAsync();
        }
    }
}
