using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Data.Entities
{
    public class Bug
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int HoursRemaining { get; set; }

        public DateTime DateCreated { get; set; }

    }
}
