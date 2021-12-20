using System.ComponentModel.DataAnnotations;

namespace BugTracker.Data.Entities
{
    //Creating a status class that will define properties of status
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public bool StatusBool { get; set; }
    }
}
