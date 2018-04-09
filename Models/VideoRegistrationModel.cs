using System;
using System.ComponentModel.DataAnnotations;

namespace VOPlayer.Models
{

    public class VideoRegistrationModel 
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public string VideoLink { get; set; }

        public DateTime RegisterDate { get; set; }

    }
}
