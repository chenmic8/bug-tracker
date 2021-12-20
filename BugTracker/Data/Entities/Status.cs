using System.ComponentModel.DataAnnotations;

namespace BugTracker.Data.Entities
{
    //Creating a status class that will define properties of status
    public class Status
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
