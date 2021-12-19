using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazorUas_72190277.Models;
using blazorUas_72190277.Services;
using Microsoft.AspNetCore.Components;

namespace blazorUas_72190277.Pages
{
    public partial class Edit
    {
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentService Studentservice { get; set; }
       
        [Inject]
        public NavigationManager NavigationManager {get; set;}
    
        protected async override Task OnInitializedAsync()
        {
            Student = await Studentservice.GetById(id);
        }

        [Parameter]
        public string id { get; set; }

        protected async Task HandleValidSubmit(){
            Student results = await Studentservice.Update(Student);
            NavigationManager.NavigateTo("/studentpage");
        }
    }
}