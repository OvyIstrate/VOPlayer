using System;
using System.ComponentModel.DataAnnotations;

namespace VOPlayer.Data
{
    public class VideoRegistration
    {
        [Key]
        public Guid Id {get;set;}

        public Guid UserId {get;set;}

        [Required]
        public string VideoLink {get;set;}

        public DateTime CreatedDate {get;set;}
    }
}