using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazorUas_72190277.Models;
using blazorUas_72190277.Services;
using Microsoft.AspNetCore.Components;

namespace blazorUas_72190277.Pages
{
    public partial class Delete
    {
        [Parameter]
        public string id { get; set;}

        [Inject]
        public IStudentService Studentservice { get; set; }
       
        [Inject]
        public NavigationManager NavigationManager {get; set;}
        
        protected async override Task OnInitializedAsync()
        {
            await Studentservice.Delete(id);
            NavigationManager.NavigateTo("studentpage");
        }


    }
}