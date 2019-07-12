using System;

namespace TimeTrackerETF.Models
{
    public class TimeEntryInputModel
    {
        public long ProjectId { get; set; }
        public long UserId { get; set; }
        public DateTime EntryDate { get; set; }
        public int Hours { get; set; }
        public string Description { get; set; }
    }
}
