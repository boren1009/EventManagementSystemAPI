using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagementSystemAPI.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Location { get; set; }
    }
}
