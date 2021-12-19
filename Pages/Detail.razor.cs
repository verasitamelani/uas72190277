using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazorUas_72190277.Models;
using blazorUas_72190277.Services;
using Microsoft.AspNetCore.Components;

namespace blazorUas_72190277.Pages
{
    public partial class Detail
    {
        [Parameter]
        public String id { get; set; }

        [Inject]
        public IStudentService StudentService { get; set; }

        public Student Student { get; set; } = new Student();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Student = await StudentService.GetById(id);
        }
    }
}