using System;
using System.ComponentModel.DataAnnotations;

namespace DevTrack.Domain.Entities
{
    public class IssueHistory
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int IssueId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string Action { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
