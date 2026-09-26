using System;
using System.ComponentModel.DataAnnotations;

namespace DevTrack.Domain.Entities
{
    public class IssueComment
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int IssueId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string Comment { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
