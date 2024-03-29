﻿namespace MeuPrimeiroCrud.Entities
{
    public class DevEvents
    {

        public DevEvents()
        {
            Speakers = new List<DevEventSpeaker>();
            IsDeleted = false;
        }

        public Guid Id { get; set; }

        public string Title { get; set; } 

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<DevEventSpeaker> Speakers { get; set; }

        public bool IsDeleted { get; set; }

        public void update(string title , string description, DateTime startDate, DateTime endDate )
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;

        }

        public void update()
        {
            IsDeleted = true;

        }
    }
}
