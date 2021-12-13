using Blazored.Modal;
using Blazored.Modal.Services;
using BugTracker.Data;
using BugTracker.Data.Entities;
using BugTracker.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Pages
{
    public partial class Backlog
    {
        [CascadingParameter] public IModalService Modal { get; set; }
        [Inject]
        BugService BService { get; set; }

        private List<Bug> bugs;

        protected override async Task OnInitializedAsync()
        {
            //pull list of bugs from database
            bugs = await BService.GetAllBugsAsync();
        }

        [Parameter]
        public EventCallback<bool> OnClose { get; set; }
        private Task ModalCancel()
        {
            return OnClose.InvokeAsync(false);
        }

        private async Task ShowModal()
        {
            var addBugModal = modal.Show<CreateBugModal>("Add New Bug");
            var result = await addBugModal.Result;
            if (!result.Cancelled)
            {
                bugs = await BService.GetAllBugsAsync();
            }
        }
        void ShowEditBug(Bug bug)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(EditBugModal.bug), bug);

            var options = new ModalOptions()
            {
                Class = "blazored-modal edit-modal"
            };
            Modal.Show<EditBugModal>("Edit Bug", parameters, options);
        }
    }
}

