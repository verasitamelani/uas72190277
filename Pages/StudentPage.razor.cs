using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazorUas_72190277.Models;
using blazorUas_72190277.Services;
using Microsoft.AspNetCore.Components;

namespace blazorUas_72190277.Pages
{
    public partial class StudentPage
    {
        public List<Student> Student { get; set; } = new List<Student>();

        [Inject]
        public IStudentService StudentService { get; set; }
    
        protected override async Task OnInitializedAsync(){
            Student = (await StudentService.GetAll()).ToList();
        }

    }
}