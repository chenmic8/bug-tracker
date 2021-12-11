using Blazored.Modal;
using BugTracker.Data.Entities;
using Microsoft.AspNetCore.Components;

namespace BugTracker.Shared
{
    public partial class EditBugModal
    {
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
        [Parameter] public Bug bug { get; set; }
        Bug Bug { get; set; }
        protected override void OnInitialized()
        {
            System.Console.WriteLine(bug);
        }

    }
}
