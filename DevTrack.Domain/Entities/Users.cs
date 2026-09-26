using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;

namespace DevTrack.Domain.Entities
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Guid PasswordHash { get; set; }
        [Required]
        public Guid PasswordSalt { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
