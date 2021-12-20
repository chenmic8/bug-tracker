using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Data.Entities
{
    //Creating a bug class that will define parameters of a bug
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
