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

        //Brings inputs from HTML to C#
        string BugTitle { get; set; }
        string BugDescription { get; set; }
        int BugHoursRemaining { get; set; }

        //Submitting the modal form will create a new bug object and add it to the database
        async Task SubmitForm()
        {
            //Create new Bug object
            Bug newbug = new Bug()
            {
                Title = BugTitle,
                Description = BugDescription,
                HoursRemaining = BugHoursRemaining,
                DateCreated = System.DateTime.Now
            };
            //Adds Bug Object to datagase
            bool success = await BService.CreateBugAsync(newbug);

            //Exits out of the modal
            await ModalInstance.CloseAsync(ModalResult.Ok($"Form was submitted successfully."));
        }

        //Pressing the cancel button will call Cancel(), exiting out of the modal
        void Cancel()
        {
            ModalInstance.CancelAsync();
        }
    }
}
