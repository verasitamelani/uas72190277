using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazorUas_72190277.Models;
using blazorUas_72190277.Services;
using Microsoft.AspNetCore.Components;

namespace blazorUas_72190277.Pages
{
    public partial class DetailEnroll
    {
        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IEnrollService EnrollService { get; set; }
 
        public List<Enroll> Enroll { get; set; } = new List<Enroll>();

        protected override async Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Enroll = (await EnrollService.GetById(Id)).ToList();
        }
    }
}