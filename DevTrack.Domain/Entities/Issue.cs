using System;
using System.ComponentModel.DataAnnotations;

namespace DevTrack.Domain.Entities
{
    public class Issue
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(4000)]
        public string Description { get; set; }

        [Required]
        public string Priority { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public int CreatedByID { get; set; }

        [Required]
        public int AssignedToID { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime AssignedAt { get; set; }

        [Required]
        public DateTime StartedAt { get; set; }

        [Required]
        public DateTime ResolvedAt { get; set; }

        [Required]
        public DateTime ClosedAt { get; set; }
    }
}
