using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    [Table("guests")]
    public class Guest
    {
        [Key]
        [Required]
        public int GuestId {get;set;}

        [Display(Name = "Guest:")]
        [Required]
        public int UserId {get;set;}
        
        [Display(Name = "Wedding:")]
        [Required]
        public int WeddingId {get;set;}

        [Required]
        public DateTime CreatedAt {get;set;}

        [Required]
        public DateTime UpdatedAt {get;set;}

        public User User {get;set;}
        public Wedding Wedding {get;set;}
    }

}