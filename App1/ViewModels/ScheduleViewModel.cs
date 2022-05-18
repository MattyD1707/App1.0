using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

using Xamarin.Plugin.Calendar.Models;
namespace App1.ViewModels
{
    public class ScheduleViewModel : BaseViewModel
    {
        public EventCollection Events { get; set; }
        public ScheduleViewModel()
        {
            Title = "Schedule";
            Events = new EventCollection
            {
                [DateTime.Now] = new List<EventModel>
                {
                    new EventModel { Name = "Start Time", Description = "10:00" },
                    new EventModel { Name = "End Time", Description = "18:00" }
                }

            };
        }
        
    }
}