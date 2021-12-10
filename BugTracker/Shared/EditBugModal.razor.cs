using Blazored.Modal;
using BugTracker.Data.Entities;
using Microsoft.AspNetCore.Components;

namespace BugTracker.Shared
{
    public partial class EditBugModal
    {
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
        [Parameter] public int BugId { get; set; }
        Bug bug { get; set; }
        protected override void OnInitialized()
        {
            System.Console.WriteLine(BugId);
        }

    }
}
