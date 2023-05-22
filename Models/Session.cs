using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models
{
    public partial class Session : ObservableObject
    {
        // Static
        public int Id { get; set; }
        public string Title { get; set; }
        public string Room { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string StartTimeDisplay => $"{Start:t}";
        public string DayDisplay => $"{Start:MMM} {Start:d}";
        public Speaker Speaker { get; set; } = new Speaker
        {
            Name = "Walter White",
            Company = "Microsoft",
            Description = "I am not in danger.",
            Title = "Principal of cooking the good stuff"
        };

        // Dynamic
        [ObservableProperty]
        bool inAgenda;
    }
}
